using System;

using System.Linq;
using System.Text.RegularExpressions;

namespace ConferenceManagement.Conferences
{
    public class Talk
    {
        private DateTime start;

        public DateTime startDate
        {
            get { return start; }
            set
            {
                start = value;
                endDate = value.AddMinutes(Convert.ToDouble(duration));
            }
        }
        public DateTime endDate { get; private set; }
        public string name { get; }
        public int duration { get; }

        public Talk(string name)
        {
            this.name = Regex.Split(name, @"[^a-z A-Z.]")[0];
            this.duration = name.Contains("lightning") ? 5 : Convert.ToInt32(Regex.Split(name, @"\D+")[1]);
        }
    }   
}