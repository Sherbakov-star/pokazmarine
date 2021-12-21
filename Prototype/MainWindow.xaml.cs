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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prototype
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 nazad = new Window2();
            nazad.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(sum.Text);
            int b = Convert.ToInt32(money.Text);

            DataTable dt_user5 = Select("SELECT * FROM [dbo].[mycard]"); // получаем данные из таблицы
            string c = Convert.ToString(dt_user5.Rows[0][1]);
            var MyCard1 = App.DB.mycard.ToList();
            var name_card = App.DB.mycard.Where(p => p.mycard1 == "4149567823645978").FirstOrDefault();

            int i = Convert.ToInt32(name_card.balance);


            var ListBook = App.DB.perevod.ToList();
            var name_select = App.DB.perevod.Where(p => p.nomerkarty == nomer.Text).FirstOrDefault();
            if (name_select.nomerkarty.ToString() == nomer.Text)
            {
              
               
                i -= a;
                name_card.balance = i;
               

                int g = Convert.ToInt32(name_select.balance);
                g += a;
                name_select.balance = g;
                MessageBox.Show("Успешно");
                //App.DB.perevod.Update(name1);
                App.DB.SaveChanges();

            }
            else
            {
                MessageBox.Show("Неверный номер карты");
            }
            money.Text = Convert.ToString(i);

           
            //perevod name3 = new perevod()
            //{

            //    nomerkarty = nomer.Text,
            //    balance = a,
            //};
            //MessageBox.Show("Успешно");
            //App.DB.perevod.Add(name3);
            //App.DB.SaveChanges();


        }
    }
}
