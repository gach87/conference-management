using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ConferenceManagement.Conferences.CreateFromTalks
{
    public class ReferenceAdministratorTests : AdministratorSpecifications
    {
        [Fact]
        public override void shouldReturnAConferenceFromAListOfGivenTalks()
        {
            //Arrange
            var talks = new List<Talk>
            {
                new Talk("Writing Fast Tests Against Enterprise Rails 60min"),
                new Talk("Overdoing it in Python 45min"),
                new Talk("Lua for the Masses 30min"),
                new Talk("Ruby Errors from Mismatched Gem Versions 45min"),
                new Talk("Common Ruby Errors 45min"),
                new Talk("Rails for Python Developers lightning"),
                new Talk("Communicating Over Distance 60min"),
                new Talk("Accounting - Driven Development 45min"),
                new Talk("Woah 30min"),
                new Talk("Sit Down and Write 30min"),
                new Talk("Pair Programming vs Noise 45min"),
                new Talk("Rails Magic 60min"),
                new Talk("Ruby on Rails: Why We Should Move On 60min"),
                new Talk("Clojure Ate Scala(on my project) 45min"),
                new Talk("Programming in the Boondocks of Seattle 30min"),
                new Talk("Ruby vs.Clojure for Back - End Development 30min"),
                new Talk("Ruby on Rails Legacy App Maintenance 60min"),
                new Talk("A World Without HackerNews 30min"),
                new Talk("User Interface CSS in Rails Apps 30min")
            };
            var administrator = new ReferenceAdministrator();
            //Act
            var actualResult = administrator.execute(talks, 180, 240);
            //Assert
            Assert.Equal(talks.Count, actualResult.themes.Aggregate(0, (int talkCount, Theme theme) =>
             {
                 talkCount += theme.morning.talks.Count() + theme.afternoon.talks.Count()-2; 
                 return talkCount;
             }));
        }
    }
}