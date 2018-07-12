namespace ConferenceManagement.Conferences
{
    public class Theme
    {
        public Session morning { get; }
        public Session afternoon { get; }

        public Theme(Session morning, Session afternoon)
        {
            this.morning = morning;
            this.afternoon = afternoon;

        }
    }
}