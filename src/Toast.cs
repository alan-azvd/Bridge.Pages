using Bridge;
using System;

namespace Bridge.Pages
{
    public class Toast
    {
        public static ToastOptions options { get; set; }

        public static void Success(String message)
        {
            Script.Call("toastr.success", message);
        }

        public static void Success(String message, String title)
        {
            Script.Call("toastr.success", message, title);
        }

        public static void Info(String message)
        {
            Script.Call("toastr.info", message);
        }

        public static void Info(String message, String title)
        {
            Script.Call("toastr.info", message, title);
        }

        public static void Warning(String message)
        {
            Script.Call("toastr.warning", message);
        }

        public static void Warning(String message, String title)
        {
            Script.Call("toastr.warning", message, title);
        }

        public static void Error(String message)
        {
            Script.Call("toastr.error", message);
        }

        public static void Error(String message, String title)
        {
            Script.Call("toastr.error", message, title);
        }
    }

    [ObjectLiteral]
    public class ToastOptions
    {
        public bool closeButton { get; set; } = false;
        public bool debug { get; set; } = false;
        public bool newestOnTop { get; set; } = false;
        public bool progressBar { get; set; } = false;
        public String positionClass { get; set; } = "toast-top-right";
        public bool preventDuplicates { get; set; } = false;
        public Action onclick { get; set; }
        public int showDuration { get; set; } = 300;
        public int hideDuration { get; set; } = 1000;
        public int timeOut { get; set; } = 5000;
        public int extendedTimeOut { get; set; } = 1000;
        public String showEasing { get; set; } = "swing";
        public String hideEasing { get; set; } = "linear";
        public String showMethod { get; set; } = "fadeIn";
        public String hideMethod { get; set; } = "fadeOut";
    }

    public class ToastConfig
    {
        public static void config(ToastOptions options)
        {
            Script.Set("toastr.options", options);
        }
    }
}