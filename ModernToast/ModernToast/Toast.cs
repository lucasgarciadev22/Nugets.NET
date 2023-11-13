using ModernToast.Usercontrols;

namespace ModernToast
{
    public static class Toast
    {
        public const string DEFAULT_TITLE_COLOR = "#FFFFFF";
        public const string DEFAULT_TITLE_LIGHT_COLOR = "#000000";
        public const string DEFAULT_TEXT_COLOR = "#808080";
        public const string DEFAULT_TEXT_LIGHT_COLOR = "#A9A9A9";

        public const string DEFAULT_BACKGROUND_COLOR = "#4b4b4b";
        public const string DEFAULT_INFO_COLOR = "#72BDE8";
        public const string WARNING_BACKGROUND_COLOR = "#F0AD4E";
        public const string SUCCESS_BACKGROUND_COLOR = "#28A745";
        public const string ERROR_BACKGROUND_COLOR = "#FF4C5D";

        public static void CreateToast
        (
            this ToastAreaControl toastArea,
            int duration,
            string text,
            int width,
            ToastType type = ToastType.DEFAULT,
            string backgroundColor = DEFAULT_BACKGROUND_COLOR,
            bool showCloseButton = false,
            bool showImage = false
        )
        {
            toastArea
                .ToastArea
                .Children
                .Add(new ToastControl(
                    duration,
                    text,
                    width,
                    type,
                    backgroundColor,
                    showCloseButton,
                    showImage));
        }

        public static void CreateToast
        (
            this ToastAreaControl toastArea,
            int duration,
            string title,
            string text,
            int width,
            ToastType type = ToastType.DEFAULT,
             string backgroundColor = DEFAULT_BACKGROUND_COLOR,
            bool showCloseButton = false,
            bool showImage = false
        )
        {
            toastArea
                .ToastArea
                .Children
                .Add(new ToastControl(
                    duration,
                    title,
                    text,
                    width,
                    type,
                    backgroundColor,
                    showCloseButton,
                    showImage));
        }
    }
}
