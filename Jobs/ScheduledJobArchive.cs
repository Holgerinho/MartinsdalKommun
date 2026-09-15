using EPiServer.Core.Internal;
using EPiServer.PlugIn;
using EPiServer.Scheduler;

namespace MartinsdalKommun.Jobs
{
    [ScheduledPlugIn(DisplayName = "Arkivering", GUID = "086c04d6-da9a-4e27-a708-31846cedfd87")]
    public class ScheduledJobArchive : ScheduledJobBase
    {
        private readonly IContentRepository _contentRepository;

        private bool _stopSignaled;

        public ScheduledJobArchive(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public override string Execute()
        {
            if (_stopSignaled)
            {
                return "Jobbet stoppades";
            }
            return "Jobbet utförs";
        }

        public override void Stop() {
            _stopSignaled = true;
        }


    }
}
