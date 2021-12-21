using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prototype
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 passwordWindow = new Window1();
          
                if (pass.Password == "123456a" && passagain.Password == pass.Password)
                {
                    passwordWindow.Close();
                    Window2 mainwin = new Window2();
                    mainwin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }        
        }
      
    }
}
