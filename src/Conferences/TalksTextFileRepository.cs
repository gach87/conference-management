using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConferenceManagement.Conferences
{
    public class TextFileRepository : TalksRepository
    {
        private readonly string fileLocation;
        public TextFileRepository(string fileLocation)
        {
            this.fileLocation = fileLocation;
        }
        public override IEnumerable<Talk> list()
        {
            var talks = new List<Talk>();
            using (StreamReader reader = new StreamReader(this.fileLocation))
            {
                reader.ReadToEnd()
                .Split("\n")
                .Where(line => line != "")
                .Select(talkText => new Talk(talkText))
                .ToList()
                .ForEach(talk => talks.Add(talk));
            }
            return talks;
        }
    }
}