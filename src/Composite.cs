using System;

namespace Bridge.Pages
{
    public abstract class Composite: BasePage
    {
        public Composite(String container)
        {
            load(container);
        }
    }
}
