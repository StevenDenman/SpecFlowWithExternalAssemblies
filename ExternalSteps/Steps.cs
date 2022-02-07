using TechTalk.SpecFlow;

namespace ExternalSteps
{
    [Binding]
    public class Steps
    {
        private readonly ExternalConfig Config;

        public Steps(ExternalConfig config)
        {
            Config = config;
            Config.Id = "From External Steps";
        }

        [Given(@"I want to use an external step")]
        public void GivenIWantToUseAnExternalStep()
        {
            System.Console.WriteLine(Config.Id);
        }
    }
}
