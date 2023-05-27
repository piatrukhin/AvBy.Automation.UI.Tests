using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.Locator;

namespace AvBy.Automation.UI.Tests.Pages.Elements
{
    public class HeaderMenu 
    {
        public WrappedElement VehicleTab => new(With.XPath("//*[text() = 'Транспорт']"), "Vehicle Tab");
        public WrappedElement NewsTab => new(With.XPath("//a[@href = '/news']"), "News Tab");
        public WrappedElement CheckVINTab => new(With.XPath("//a[@href = '/vin']"), "Check VIN Tab");
        public WrappedElement SubmitAdTab => new(With.XPath("//a[@href= 'https://av.by/new_ad' ]"), "Submit Ad Tab");
        public WrappedElement LogInTab => new(With.XPath("//a[@href='/login']"), "Login Tab");
    }
}
