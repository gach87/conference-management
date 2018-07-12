using System.Collections.Generic;

namespace ConferenceManagement.Conferences.CreateFromTalks
{
    public abstract class ConsoleInterface
    {
        public abstract void execute(
            IEnumerable<Talk> tasks,
            int maximumMinutesForMorningSession,
            int maximumMinutesForAfternoonSession
        );
    }
}