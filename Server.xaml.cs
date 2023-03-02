using ActiproSoftware.Windows.Themes;
using ActiproSoftware.Windows.Themes.Generation;
using System.Windows.Controls;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Server.xaml
    /// </summary>
    public partial class Server : Page
    {
        public Server()
        {
            ThemeManager.BeginUpdate();
            try
            {
                // Register the theme definitions for your application
                ThemeManager.RegisterThemeDefinition(new ThemeDefinition("Custom")
                {
                    Intent = ThemeIntent.Black,
                    ButtonBackgroundGradientKind = GradientKind.None,
                    ButtonCornerRadius = 0,
                    CheckBoxCornerRadius = 0,
                    TabCornerRadius = 0,
                    ToolBarButtonCornerRadius = 0,
                });

                // Use the Actipro styles for native WPF controls that look great with Actipro's control products
                ThemeManager.AreNativeThemesEnabled = true;

                // Set the current app theme via a registered theme definition name
                ThemeManager.CurrentTheme = "Custom";
            }
            finally
            {
                ThemeManager.EndUpdate();
            }
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
