using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightAutomationDemo.Pages
{
    public class LoginPage
    {
        private IPage _page;
        public LoginPage(IPage page) => _page = page;

        private ILocator _linkLogin => _page.Locator("text=Login");
        private ILocator _txtUsername => _page.Locator("#UserName");
        private ILocator _txtPassword => _page.Locator("#Password");
        private ILocator _btnLogin => _page.Locator("text=Log in");
        private ILocator _linkEmployeeDetails => _page.Locator("text=Employee Details");
        public async Task ClickLogin()=>await _linkLogin.ClickAsync(); 
        public async Task Login(string username, string password)
        {
            await _txtPassword.FillAsync(password);
            await _txtUsername.FillAsync(username);
            await _btnLogin.ClickAsync();
        }

        public async Task<bool> IsEmployeeDetailsExists()=> await _linkEmployeeDetails.IsVisibleAsync();
    }
}
