using AvBy.Automation.UI.Tests.Pages.Base;
using AvBy.Automation.UI.Tests.Pages.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvBy.Automation.UI.Tests.Pages
{
    public class LoginPage : BasePage
    {
        public static HeaderMenu HeaderMenu => new();
        public static LoginMenu LoginMenu => new();
    }
}
