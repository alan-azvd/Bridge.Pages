using Bridge.jQuery2;
using System;

namespace Bridge.Pages
{
    public abstract class BasePage
    {
        protected String View { get; set; }

        protected void load(String container)
        {
            if (String.IsNullOrEmpty(View))
                View = "pages/" + getComponentName() + ".html";

            jQuery.Select(container).Load(View, null, (responseText, textStatus, jqXHR) => {
                onLoad();
            });
        }

        protected abstract void onLoad();

        private string getComponentName()
        {
            int index = this.GetClassName().LastIndexOf(".");
            String componentName = this.GetClassName().Substring(index + 1);
            return componentName.ToLower();
        }
    }
}
