# ModernToast
Modern custom toast popups for WPF applications

## Quick Start

1. Download ModernToast from nuget.org

2. Import ModernToast in XAML

```xaml
xmlns:ToastArea="clr-namespace:ModernToast.Usercontrols;assembly=ModernToast"
```

3. Create and position your popups area, where the toasts will be rendered and stacked on view

```xaml
<Toast:ToastAreaControl x:Name="ToastArea" VerticalAlignment="Bottom" HorizontalAlignment="Right" Width="500"/>
```

4. Finally, just call the desired `CreateToast` method overload from `ToastArea`. You can choose many options like colors, sizes and duration

```c#
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ToastArea.CreateToast(5, "Title", "Notification text", 300);
        }
```

```c#



Overloads include visibility time, title, text, image and manually close button visibility
