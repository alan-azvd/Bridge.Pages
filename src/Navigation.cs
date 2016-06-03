using Bridge;
using System;

namespace Bridge.Pages
{
    public class Navigation<T> where T : Page
    {
        public static void Go()
        {
            Activator.CreateInstance<T>();
        }

        public static void Go(params object[] param)
        {
            String s = String.Empty;
            foreach(var obj in param)
            {
                String o = String.Empty;

                if(obj.GetType().Equals(typeof(String)))
                {
                    o = "'" + obj.ToString() + "'";
                }
                else
                {
                    o = obj.ToString();
                }
                s = s + o + ",";
            }
            s = s.Remove(s.LastIndexOf(","));
            Script.Eval(String.Format("new {0}({1})", typeof(T).GetClassName(), s));
        }
    }
}
