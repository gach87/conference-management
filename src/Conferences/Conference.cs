using System.Collections.Generic;

namespace ConferenceManagement.Conferences
{
    public class Conference
    {
        public IEnumerable<Theme> themes { get; }
        public Conference()
        {

        }
        public Conference(IEnumerable<Theme> themes)
        {
            this.themes = themes;
        }
    }
}