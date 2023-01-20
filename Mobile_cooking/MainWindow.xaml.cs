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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using Mobile_cooking.Models;
using System.Data.Common;

namespace Mobile_cooking
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection connection;
        //public ObservableCollection<ListViewItem> listItems { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\Mobile_cooking\Mobile_cooking\Database1.mdf;Integrated Security=True";
            connection = new SqlConnection (connectionString);
        }

        public void ListReciept(String reciept)
        {
            using (SqlCommand cmd = connection.CreateCommand())
            {
                List<Book> list = new List<Book>();
                //cmd.CommandText = reciept;
                SqlDataReader res = cmd.ExecuteReader();

                while (res.Read())
                {
                    list.Add(new Book()
                    {
                        Id = res.GetInt32(0),
                        Name = res.GetString(1),
                        Description = res.GetString(2)
                    });
                }
                res.Close();
                
            }
        }

        private void FirstButon_Click(object sender, RoutedEventArgs e)
        {
            ListReciept(Name);            
        }

        private void SecondButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaladButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CakeButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SouseButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DesertButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DrinkButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FoundButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ServiceButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Розроблювачі: Соломон Юрій та Сироткіна Світлана");
        }

        private void QuestionButon_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void MenuButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButon_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListViewItem item)
            {                
                Description.Text = item.Content as string;
                Ingredients.Text = "1233";
                Image.FindName("");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
    }
}
