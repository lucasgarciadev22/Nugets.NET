using System.Windows;
using System.Windows.Media;

namespace ModernToast.Example
{
    public partial class MainWindow : Window
    {
        private readonly int _width;
        private const string DARK_BG_COLOR = "#151A27";
        private const string LIGHT_BG_COLOR = "#EEEEEE";

        public MainWindow()
        {
            _width = 350;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToastArea.CreateToast(5, "Notification text", 250);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ToastArea.CreateToast(5, "Title", "Notification text", 300);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ToastArea.CreateToast(
                5,
                "Notification text",
                _width,
                ToastType.SUCCESS,
                Toast.DEFAULT_BACKGROUND_COLOR,
                false,
                true);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ToastArea.CreateToast(
                5,
                "Notification text",
                _width,
                ToastType.WARNING,
                Toast.DEFAULT_BACKGROUND_COLOR,
                true,
                true);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ToastArea.CreateToast(
                5,
                "Notification title",
                "Notification text",
                _width,
                ToastType.QUESTION,
                Toast.DEFAULT_INFO_COLOR,
                true,
                true);

            ToastArea.CreateToast(
                5,
                "Notification title",
                "Notification text",
                _width,
                ToastType.INFO,
                Toast.DEFAULT_INFO_COLOR,
                true,
                true);

            ToastArea.CreateToast(
                5,
                "Notification title",
                "Notification text",
                _width,
                ToastType.SUCCESS,
                Toast.SUCCESS_BACKGROUND_COLOR,
                true,
                true);

            ToastArea.CreateToast(
                5,
                "Notification title",
                "Notification text",
                _width,
                ToastType.WARNING,
                Toast.WARNING_BACKGROUND_COLOR,
                true,
                true);

            ToastArea.CreateToast(
                5,
                "Notification title",
                "Notification text",
                _width,
                ToastType.ERROR,
                Toast.ERROR_BACKGROUND_COLOR,
                true,
                true);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SolidColorBrush currentBrush = TestWindow.Background as SolidColorBrush;

            if (currentBrush != null)
            {
                if (currentBrush.Color == (Color)ColorConverter.ConvertFromString(LIGHT_BG_COLOR))
                    SetDarkBackground();
                else
                    SetLightBackground();
            }
            else
                SetLightBackground();
        }

        private void SetLightBackground()
        {
            Color color = (Color)ColorConverter.ConvertFromString(LIGHT_BG_COLOR);
            SolidColorBrush brush = new SolidColorBrush(color);
            TestWindow.Background = brush;
        }

        private void SetDarkBackground()
        {
            Color color = (Color)ColorConverter.ConvertFromString(DARK_BG_COLOR);
            SolidColorBrush brush = new SolidColorBrush(color);
            TestWindow.Background = brush;
        }
    }
}
