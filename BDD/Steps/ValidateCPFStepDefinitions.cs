using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDD.Steps
{
    [Binding]
    public sealed class ValidateCPFStepDefinitions
    {
        private ChromeDriver chromeDriver;
        public ValidateCPFStepDefinitions() => chromeDriver = new ChromeDriver();

        private readonly ScenarioContext _scenarioContext;

        public ValidateCPFStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("i'm in home page")]
        public void GivenTheFirstNumberIs(int number)
        {
            chromeDriver.Url = "https://localhost:44311/";
        }

        [Given("I type the CPF (.*)")]
        public void GivenTheSecondNumberIs(string cpf)
        {
            _scenarioContext.Pending();
        }

        [When("I click on button validate")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _scenarioContext.Pending();
        }

        [Then("I have the successful result")]
        public void ThenTheResultShouldBe(int result)
        {
            _scenarioContext.Pending();
        }
    }
}
