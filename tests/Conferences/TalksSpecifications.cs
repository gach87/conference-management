namespace ConferenceManagement.Conferences
{
    public abstract class TalksSpecifications
    {
        public abstract void shouldCreateTalkFromStringContainingDurationInMinutes();
        public abstract void shouldSetThenEndDateWhenProvidingTheStartDateAsStartDatePlusDurationOfTheTalk();
    }
}