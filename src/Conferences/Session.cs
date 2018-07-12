using System.Collections.Generic;

namespace ConferenceManagement.Conferences
{
    public class Session
    {
        public IEnumerable<Talk> talks { get; }

        public Session(IEnumerable<Talk> talks)
        {
            this.talks = talks;
        }
    }
}