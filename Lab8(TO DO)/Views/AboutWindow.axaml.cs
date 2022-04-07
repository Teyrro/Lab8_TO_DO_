using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Lab8_TO_DO.Views
{
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("OkButton").Click += async delegate
            {
                this.Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
