using EPiServer.Web;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
using System.Security.Principal;
using EPiServer.Security;

namespace MartinsdalKommun.Jobs
{
    [ScheduledPlugIn(
        DisplayName = "Arkivering", 
        GUID = "086c04d6-da9a-4e27-a708-31846cedfd87")]
    public class ScheduledJobArchive : ScheduledJobBase
    {
        private readonly IContentRepository _contentRepository;
        private readonly ISiteDefinitionRepository _siteDefinitionRepository;
        private readonly IPrincipalAccessor _principalAccessor;

        private bool _stopSignaled;

        public ScheduledJobArchive(IContentRepository contentRepository, 
            ISiteDefinitionRepository siteDefinitionRepository,
            IPrincipalAccessor principalAccessor)
        {
            _contentRepository = contentRepository;

            _siteDefinitionRepository = siteDefinitionRepository;

            _principalAccessor = principalAccessor;

            IsStoppable = true;
        }
        //public void ArchiveJob()
        //{
        //    Execute();
        //    Stop();
        //}

        public override string Execute()
        {

            //_principalAccessor.Principal = new GenericPrincipal(
            //    new GenericIdentity("ArchiveJob"),
            //    new[] { "ArchiveJobRole" });

            var site = _siteDefinitionRepository.List().FirstOrDefault();

            //var startPageReference = SiteDefinition.Current.StartPage;

            var startPage = _contentRepository.Get<Models.Pages.StartPage>(site.StartPage);

            var landingPageRoot = startPage.LandingPageRoot;
            var archiveRoot = startPage.ArchiveRoot;

            var limit = DateTime.Now.AddDays(-30);

            var pages = _contentRepository.GetChildren<Models.Pages.InformationPage>(landingPageRoot);

            var pagesToArchive = pages
                .Where(page =>
                    //page.Changed < limit &&
                    page.StartPublish < limit)
                .ToList();

            foreach (var page in pagesToArchive)
            {
                if (_stopSignaled)
                {
                    return "Jobbet stoppades";
                }

                _contentRepository.Move(page.ContentLink, archiveRoot, 0, 0);
            }

            return "Jobbet utförs";
        }
        public override void Stop() {
            _stopSignaled = true;
        }
    }
}
