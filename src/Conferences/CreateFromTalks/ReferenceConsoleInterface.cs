using System;
using System.Collections.Generic;

namespace ConferenceManagement.Conferences.CreateFromTalks
{
    public class ReferenceConsoleInterface : ConsoleInterface
    {
        private readonly Administrator administrator;
        public ReferenceConsoleInterface(Administrator administrator) => this.administrator = administrator;
        public override void execute(IEnumerable<Talk> tasks, int maximumMinutesForMorningSession, int maximumMinutesForAfternoonSession)
        {
            var conference = administrator.execute(tasks, maximumMinutesForMorningSession, maximumMinutesForAfternoonSession);
            int themeCount = 1;
            foreach (var theme in conference.themes)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Theme " + themeCount);
                Console.WriteLine(" ");
                foreach (var talk in theme.morning.talks)
                {
                    Console.WriteLine(talk.startDate.ToString("hh:mm tt") + " " + talk.name + " " + talk.duration + "min");
                };
                Console.WriteLine(" ");
                foreach (var talk in theme.afternoon.talks)
                {
                    Console.WriteLine(talk.startDate.ToString("hh:mm tt") + " " + talk.name + " " + talk.duration + "min");
                };
                themeCount++;
            };

        }
    }
}