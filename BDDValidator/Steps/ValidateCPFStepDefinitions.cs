using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace BDDValidator.Steps
{
    [Binding]
    public sealed class ValidateCPFStepDefinitions
    {
        private ChromeDriver _chromeDriver;

        private readonly ScenarioContext _scenarioContext;

        public ValidateCPFStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _chromeDriver = new ChromeDriver(@"C:\Users\Administrador\source\repos\WebTddBdd\BDDValidator\Drivers\windows");
        }

        [Given(@"i'm in home page")]
        public void GivenImInHomePage()
        {
            _chromeDriver.Url = "https://localhost:5001/";
        }

        [Given(@"I type the CPF ""(.*)""")]
        public void GivenITypeTheCPF(string cpf)
        {
            _chromeDriver.FindElementByCssSelector("#Nome").SendKeys("Danilo BDD");
            _chromeDriver.FindElementByCssSelector("#CPF").SendKeys("666.116.300-31");
        }

        [When(@"I click on button validate")]
        public void WhenIClickOnButtonValidate()
        {
            _chromeDriver.FindElementByCssSelector("input[type='submit']").Click();
        }

        [Then(@"I have the successful result")]
        public void ThenIHaveTheSuccessfulResult()
        {
            Assert.IsTrue(_chromeDriver.FindElementsByCssSelector(".alert-success").Count > 0);
            _chromeDriver.Close();
            _chromeDriver.Dispose();
        }
    }
}
