using System;
using ConferenceManagement.Conferences;
using Xunit;

namespace ConferenceManagement.Conferences
{
    public class TalksTests : TalksSpecifications
    {
        [Fact]
        public override void shouldCreateTalkFromStringContainingDurationInMinutes()
        {
            //Arrange
            var duration = "User Interface CSS in Rails Apps 30min";
            var expectedName = "User Interface CSS in Rails Apps ";
            var expectedDuration = 30;
            //Act
            var newTalk = new Talk(duration);
            //Assert
            Assert.Equal(expectedName, newTalk.name);
            Assert.Equal(expectedDuration, newTalk.duration);
        }
        [Fact]
        public override void shouldSetThenEndDateWhenProvidingTheStartDateAsStartDatePlusDurationOfTheTalk()
        {
            //Arrange
            var expectedEndDate = DateTime.Today.AddMinutes(30);
            var name = "User Interface CSS in Rails Apps 30min";
            var newTalk = new Talk(name);
            //Act
            newTalk.startDate = DateTime.Today;
            //Assert
            Assert.Equal(expectedEndDate, newTalk.endDate);
        }
    }
}