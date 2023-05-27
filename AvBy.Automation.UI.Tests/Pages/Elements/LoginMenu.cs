using RMTBanking.Automation.UI.Tests.Core.Element;
using RMTBanking.Automation.UI.Tests.Core.Locator;

namespace AvBy.Automation.UI.Tests.Pages.Elements
{
    public class LoginMenu
    {
        public WrappedElement LoginField => new(With.XPath("//input[@name = 'phone.number' or @name = 'login']"), "Number Field");
        public WrappedElement PasswordField => new(With.XPath("//input[@id = 'password' or @id = 'passwordPhone']"), "Password Field");
        public WrappedElement FillFieldAlert => new(With.XPath("//*[text() = 'Заполните поле']"), "Fill Field Alert");
        public WrappedElement CloseLogInWindow => new(With.ClassName("drawer__close"), "Close Login Window");
        public WrappedElement ByMailOrLogButton => new(With.XPath("//button[text() = 'почте или логину']"), "By E-Mail or Login");

        public WrappedElement LogInButton => new(With.XPath("//button[@class='button button--action']"), "Login Button");
        public WrappedElement LogInTab => new(With.XPath("//a[@href='/login']"), "Login Tab");
        public WrappedElement ForgotPasswordButton => new(With.Css("button.button--link.button--small"), "Forgot Password Button");
        public WrappedElement SignUpButton => new(With.XPath("//button[text() = 'Регистрация']"), "Sign Up Button");
        //public WrappedElement LogInDisabledButton => new(With.XPath("//button[text() = 'Войти' and @disabled='disabled']"), "Login Disabled");
        public WrappedElement PasswordVisibilityToggle => new(With.XPath("//*[@title='Показать/скрыть пароль']"), "Password Visibility Toggle");
        public WrappedElement PasswordCharactersAlert => new(With.XPath("//*[text() = 'Неверный телефон или пароль. Если забыли пароль, восстановите его']"), "Password Characters Alert");


    }
}
