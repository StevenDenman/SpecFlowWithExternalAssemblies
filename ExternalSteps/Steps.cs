using TechTalk.SpecFlow;

namespace ExternalSteps
{
    [Binding]
    public class Steps
    {
        [Given(@"I want to use an external step")]
        public void GivenIWantToUseAnExternalStep()
        {
            System.Console.WriteLine("Success!");
        }
    }
}
