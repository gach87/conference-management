using System.Collections.Generic;

namespace ConferenceManagement.Conferences
{
    public abstract class TalksRepository
    {
        public abstract IEnumerable<Talk> list();
    }
}