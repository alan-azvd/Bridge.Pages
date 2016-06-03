using System;

namespace Bridge.Pages
{
    public abstract class Page: BasePage
    {
        public Page()
        {
            load("page");
        }
    }
}
