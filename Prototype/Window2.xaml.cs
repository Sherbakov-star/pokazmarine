using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        public Window2()
        {
            InitializeComponent();
            DataTable dt_user = Select("SELECT * FROM [dbo].[mycard]"); // получаем данные из таблицы
            money.Text = Convert.ToString(dt_user.Rows[0][2]);
        }

        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase");                // создаём таблицу в приложении
                                                                            
            SqlConnection sqlConnection = new SqlConnection("server=localhost\\SQLEXPRESS;Trusted_Connection=Yes;DataBase=bank;");// подключаемся к базе данных
            sqlConnection.Open();                                           // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          // создаём команду
            sqlCommand.CommandText = selectSQL;                             // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable);                                 // возращаем таблицу с результатом
            return dataTable;
        }

        private void perevod_Click(object sender, RoutedEventArgs e)
        {
            MainWindow perevod = new MainWindow();
            perevod.Show();
            this.Close();

        }

        private void platezgh_Click(object sender, RoutedEventArgs e)
        {
            Window3 plateg = new Window3();
            plateg.Show();
            this.Close();
        }

        private void history_Click(object sender, RoutedEventArgs e)
        {
            Window4 history = new Window4();
            history.Show();
            this.Close();
        }


    }
}
