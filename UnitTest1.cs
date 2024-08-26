using PlaywrightAutomationDemo.Pages;

namespace PlaywrightAutomationDemo
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Tests : PageTest
    {
        [Test]
        public async Task Test1()
        {
            await Page.GotoAsync("http://www.eaapp.somee.com");

            var login = new LoginPage(Page);
            await login.ClickLogin();
            await login.Login("admin", "password");
            bool employeeDetailsExist = await login.IsEmployeeDetailsExists();
            Assert.That(employeeDetailsExist, Is.True);
        }
    }
}
