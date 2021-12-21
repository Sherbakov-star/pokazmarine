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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
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
            var MyCard1 = App.DB.mycard.ToList();
            var name_card = App.DB.mycard.Where(p => p.mycard1 == "4149567823645978").FirstOrDefault();
            int i = Convert.ToInt32(name_card.balance);
            i -= Convert.ToInt32(mobile.Text);
            name_card.balance = i;
            MessageBox.Show("Успешно");
            App.DB.SaveChanges();
            money.Text = Convert.ToString(i);

            history namehi = new history()
            {
                payment ="Мобильная связь",
                sum =Convert.ToInt32(mobile.Text), 
            };
            App.DB.history.Add(namehi);
            App.DB.SaveChanges();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var MyCard1 = App.DB.mycard.ToList();
            var name_card = App.DB.mycard.Where(p => p.mycard1 == "4149567823645978").FirstOrDefault();
            int i = Convert.ToInt32(name_card.balance);
            i -= Convert.ToInt32(bus.Text);
            name_card.balance = i;
            MessageBox.Show("Успешно");
            App.DB.SaveChanges();
            money.Text = Convert.ToString(i);

            history namehi = new history()
            {
                payment = "Транспортная карта",
                sum = Convert.ToInt32(bus.Text),
            };
            App.DB.history.Add(namehi);
            App.DB.SaveChanges();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var MyCard1 = App.DB.mycard.ToList();
            var name_card = App.DB.mycard.Where(p => p.mycard1 == "4149567823645978").FirstOrDefault();
            int i = Convert.ToInt32(name_card.balance);
            i -= Convert.ToInt32(dom.Text);
            name_card.balance = i;
            MessageBox.Show("Успешно");
            App.DB.SaveChanges();
            money.Text = Convert.ToString(i);

            history namehi = new history()
            {
                payment = "Коммунальные платежи",
                sum = Convert.ToInt32(dom.Text),
            };
            App.DB.history.Add(namehi);
            App.DB.SaveChanges();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var MyCard1 = App.DB.mycard.ToList();
            var name_card = App.DB.mycard.Where(p => p.mycard1 == "4149567823645978").FirstOrDefault();
            int i = Convert.ToInt32(name_card.balance);
            i -= Convert.ToInt32(nalog.Text);
            name_card.balance = i;
            MessageBox.Show("Успешно");
            App.DB.SaveChanges();
            money.Text = Convert.ToString(i);

            history namehi = new history()
            {
                payment = "Налоги",
                sum = Convert.ToInt32(nalog.Text),
            };
            App.DB.history.Add(namehi);
            App.DB.SaveChanges();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var MyCard1 = App.DB.mycard.ToList();
            var name_card = App.DB.mycard.Where(p => p.mycard1 == "4149567823645978").FirstOrDefault();
            int i = Convert.ToInt32(name_card.balance);
            i -= Convert.ToInt32(shtraf.Text);
            name_card.balance = i;
            MessageBox.Show("Успешно");
            App.DB.SaveChanges();
            money.Text = Convert.ToString(i);

            history namehi = new history()
            {
                payment = "Штрафы",
                sum = Convert.ToInt32(shtraf.Text),
            };
            App.DB.history.Add(namehi);
            App.DB.SaveChanges();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var MyCard1 = App.DB.mycard.ToList();
            var name_card = App.DB.mycard.Where(p => p.mycard1 == "4149567823645978").FirstOrDefault();
            int i = Convert.ToInt32(name_card.balance);
            i -= Convert.ToInt32(med.Text);
            name_card.balance = i;
            MessageBox.Show("Успешно");
            App.DB.SaveChanges();
            money.Text = Convert.ToString(i);

            history namehi = new history()
            {
                payment = "Медицинские услуги",
                sum = Convert.ToInt32(med.Text),
            };
            App.DB.history.Add(namehi);
            App.DB.SaveChanges();
        }
    }
}
