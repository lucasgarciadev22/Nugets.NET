using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ModernToast.Usercontrols
{
    public partial class ToastControl : UserControl
    {
        private readonly int _duration;
        private readonly bool _showCloseButton;
        private readonly string _title = string.Empty;
        private readonly string _text;
        private readonly ToastType _type;
        private readonly string _backgroundColor;
        private readonly bool _showImage;

        public ToastControl
        (
            int duration,
            string text,
            int width,
            ToastType type,
            string backgroundColor,
            bool showCloseButton,
            bool showImage
        )
        {
            InitializeComponent();

            Toast.Width = width;
            _duration = duration;
            _text = text;
            _backgroundColor = backgroundColor;
            _type = type;
            _showCloseButton = showCloseButton;
            _showImage = showImage;

            ExecuteControl();
        }

        public ToastControl
        (
            int duration,
            string title,
            string text,
            int width,
            ToastType type,
            string backgroundColor,
            bool showCloseButton,
            bool showImage
        )
        {
            InitializeComponent();

            Toast.Width = width;
            _duration = duration;
            _text = text;
            _backgroundColor = backgroundColor;
            _title = title;
            _type = type;
            _showCloseButton = showCloseButton;
            _showImage = showImage;

            ExecuteControl();
        }

        private async void ExecuteControl()
        {
            TbNotificationContent.Text = _text;

            Color color = (Color)ColorConverter.ConvertFromString(_backgroundColor);
            SolidColorBrush brush = new SolidColorBrush(color);

            Container.Background = brush;

            if (!string.IsNullOrEmpty(_title))
                TbNotificationTitle.Text = _title;
            else
                (TbNotificationContent.Parent as Grid).RowDefinitions.RemoveAt(0);

            if (_showImage)
                ImgIcon.Source = ResolveImage();

            BtnCloseNotification.Visibility = _showCloseButton ? Visibility.Visible
                                                               : Visibility.Hidden;
            try
            {
                await Task.Run(() =>
                {
                    Thread.Sleep(new TimeSpan(0, 0, _duration));
                });

                if (Parent is StackPanel parentPopup)
                    parentPopup.Children.Remove(this);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        private void CloseNotification_Click(object sender, RoutedEventArgs e)
        {
            if (Parent is StackPanel parentPopup)
                parentPopup.Children.Remove(this);
        }

        private ImageSource ResolveImage()
        {
            switch (_type)
            {
                default:
                case ToastType.DEFAULT:
                    return null;
                case ToastType.SUCCESS:
                    return new BitmapImage(new Uri(@"../src/img/success.png", UriKind.Relative));
                case ToastType.INFO:
                    return new BitmapImage(new Uri(@"../src/img/info.png", UriKind.Relative));
                case ToastType.WARNING:
                    return new BitmapImage(new Uri(@"../src/img/warning.png", UriKind.Relative));
                case ToastType.ERROR:
                    return new BitmapImage(new Uri(@"../src/img/error.png", UriKind.Relative));
                case ToastType.QUESTION:
                    return new BitmapImage(new Uri(@"../src/img/question.png", UriKind.Relative));
            }
        }

    }
}
