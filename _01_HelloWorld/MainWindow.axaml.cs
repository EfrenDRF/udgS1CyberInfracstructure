using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Text.RegularExpressions;

namespace _01_HelloWorld
{
    public partial class MainWindow : Window
    {
        private TextBox textPsw1;
        private TextBox textPsw2;
        private TextBlock labelMsg;
        private bool regexMach = false;      




        public MainWindow()
        {
            InitializeComponent();

            textPsw1 = this.FindControl<TextBox>("textPsw");
            textPsw2 = this.FindControl<TextBox>("textConfPws");
            labelMsg = this.FindControl<TextBlock>("label");
 

#if DEBUG
            this.AttachDevTools();
#endif
        }
        
        public void button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            if (textPsw1.Text == textPsw2.Text)
            {

                regexMach = Regex.IsMatch(textPsw1.Text , "[a-z]+");

                if (true == regexMach)
                {
                    regexMach = Regex.IsMatch(textPsw1.Text, "[A-Z]+");

                    if (true == regexMach)
                    {
                        regexMach = Regex.IsMatch(textPsw1.Text, "[0-9]+");
                        
                        regexMach = Regex.IsMatch(textPsw1.Text, "[!-/-:-@-{-~}]+");
                        
                        if (true == regexMach)
                        {
                            var messageBoxStandardWindow = MessageBox.Avalonia.MessageBoxManager.GetMessageBoxStandardWindow("Success", "Password has been validated :)");
                            messageBoxStandardWindow.Show();
                            labelMsg.Text = "";
                            textPsw1.Text = "";
                            textPsw2.Text = "";
                        }
                        else
                        {
                            labelMsg.Text = "psw must containt at least one special character";
                        }
                    }
                    else
                    {
                        labelMsg.Text = "psw must containt at least one capital latter character";
                    }
                }
                else
                {
                    labelMsg.Text = "psw must containt at least one lower latter character";
                }
 
            }
            else
            {
                labelMsg.Text = "psw are not the same";
            }
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}