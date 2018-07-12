using System;
using System.Collections.Generic;
using System.Linq;
namespace ConferenceManagement.Conferences.CreateFromTalks
{
    public class ReferenceAdministrator : Administrator
    {
        public override Conference execute(
            IEnumerable<Talk> talks,
        int maximumMinutesForMorningSession,
        int maximumMinutesForAfternoonSession
        )
        {
            return new Conference(GenerateThemes(talks, maximumMinutesForMorningSession, maximumMinutesForAfternoonSession));
        }

        private IEnumerable<Theme> GenerateThemes(
             IEnumerable<Talk> talks,
             int maximumMinutesForMorningSession,
             int maximumMinutesForAfternoonSession
             )
        {
            var talksDone = talks.Count() == 0;
            var themes = new List<Theme>();
            while (!talksDone)
            {
                var generatedTheme = this.GenerateTheme(
                     talks,
                 maximumMinutesForMorningSession,
              maximumMinutesForAfternoonSession
              );
                themes.Add(generatedTheme.theme);
                if (generatedTheme.remainingTalks.Count == 0)
                {
                    talksDone = true;
                }
                talks = generatedTheme.remainingTalks;
            }
            return themes;
        }
        private dynamic GenerateTheme(
            IEnumerable<Talk> talks,
            int maximumMinutesForMorningSession,
            int maximumMinutesForAfternoonSession
            )
        {
            var morningSession = GenerateSession(
                talks,
                maximumMinutesForMorningSession,
                9
            );
            var lunchTalk = new Talk("Lunch 60min");
            lunchTalk.startDate = DateTime.Today.AddHours(12);
            morningSession.session.talks.Add(lunchTalk);
            var afternoonSession = GenerateSession(
                morningSession.remainingTalks,
                maximumMinutesForAfternoonSession,
                13
            );
            var networkingTalk = new Talk("Networking Event 60min");
            networkingTalk.startDate = afternoonSession.session.talks[afternoonSession.session.talks.Count - 1].endDate;
            afternoonSession.session.talks.Add(networkingTalk);
            return new
            {
                theme = new Theme(morningSession.session, afternoonSession.session),
                remainingTalks = afternoonSession.remainingTalks
            };
        }
        private dynamic GenerateSession(
            IEnumerable<Talk> talks,
            int maxMinutesForSession,
            int startHourForSession
        )
        {
            var sessionTalks = new List<Talk>();
            var remainingTalks = new List<Talk>();
            talks.Aggregate(0, (int currentSessionDuration, Talk talk) =>
            {
                if (currentSessionDuration + talk.duration <= maxMinutesForSession)
                {
                    talk.startDate = talks.TakeWhile(x => !x.Equals(talk)).LastOrDefault() != null ? talks.TakeWhile(x => !x.Equals(talk)).LastOrDefault().endDate : DateTime.Today.AddHours(startHourForSession);
                    sessionTalks.Add(talk);
                    return currentSessionDuration += talk.duration;
                }
                else
                {
                    remainingTalks.Add(talk);
                    return currentSessionDuration;
                }
            });
            return new
            {
                session = new Session(sessionTalks),
                remainingTalks = remainingTalks
            };
        }
    }
}
