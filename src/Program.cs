using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceManagement.Conferences;

namespace ConferenceManagement
{
    public class Program
    {
        static void Main(string[] args)
        {

            if (args.Count() == 2)
            {
                Console.WriteLine("Talks text file was selected, value: {0}", args[1]);
                createConferenceFromTalks(new Conferences.TextFileRepository(args[1]));
            }
            else
            {
                Console.WriteLine("No talks file option was selected, using memory repository");
                createConferenceFromTalks(new Conferences.TalksMemoryRepository());
            }


        }

        private static void createConferenceFromTalks(TalksRepository repository)
        {
            var createFromTalksInterface = new Conferences.CreateFromTalks.ReferenceConsoleInterface(
                new Conferences.CreateFromTalks.ReferenceAdministrator()
            );
            try
            {
                createFromTalksInterface.execute(repository.list(), 180, 240);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
