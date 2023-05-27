namespace RMTBanking.Automation.UI.Tests.Core.Conditions.WebDriverConditions
{
    public class JavaScriptLoadingComplete : JsReturnedTrue
    {
        private const string Script = @"try
                        {
                            if (document.readyState != 'complete')
                            {
                                return false;
                            }
                            if (window.jQuery)
                            {
                                if (window.jQuery.active)
                                {
                                    return false;
                                } else if (window.jQuery.ajax && window.jQuery.ajax.active) {
                                    return false;
                                }
                            }                            
                            return true;
                        }
                        catch (ex)
                        {
                            return false;
                        }";

        public JavaScriptLoadingComplete() : base(Script)
        {
        }
    }
}
