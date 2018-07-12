using System.Collections.Generic;

namespace ConferenceManagement.Conferences.CreateFromTalks
{
    public abstract class Administrator
    {
        public abstract Conference execute(
            IEnumerable<Talk> tasks,
            int maximumMinutesForMorningSession,
            int maximumMinutesForAfternoonSession
            );
    }
}