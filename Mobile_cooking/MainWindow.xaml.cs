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
using Mobile_cooking.Entities;

namespace Mobile_cooking
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SqlConnection connection;
        private const String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\source\repos\Mobile_cooking\Mobile_cooking\Database1.mdf;Integrated Security=True";
        private readonly DAL.Reciepts reciepts; // для работы с таблицей названий рецептов
        private readonly DAL.Descritions descritions;
        private readonly DAL.Ingredients ingredients;

        public MainWindow()
        {
            InitializeComponent();           
            connection  = new SqlConnection (connectionString);
            reciepts    = new DAL.Reciepts(connection);
            descritions = new DAL.Descritions(connection);
            ingredients = new DAL.Ingredients(connection);
        }

        #region Кнопки выбора списков названий рецептов

        private void FirstButon_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
             foreach(Entities.Reciept reciept in reciepts.Getlist1())
            {
                builder.AppendLine(reciept.Name);
            }
            ListViewName.Text = builder.ToString();           
        }

        private void SecondButon_Click(object sender, RoutedEventArgs e)
        {
            ListViewName.Text = "";
            StringBuilder builder = new StringBuilder();
            foreach (Entities.Reciept reciept in reciepts.Getlist2())
            {
                builder.AppendLine(reciept.Name);
            }
            ListViewName.Text = builder.ToString();
        }

        private void SaladButon_Click(object sender, RoutedEventArgs e)
        {
            ListViewName.Text = "";
            StringBuilder builder = new StringBuilder();
            foreach (Entities.Reciept reciept in reciepts.Getlist3())
            {
                builder.AppendLine(reciept.Name);
            }
            ListViewName.Text = builder.ToString();
        }

        private void CakeButon_Click(object sender, RoutedEventArgs e)
        {
            ListViewName.Text = "";
            StringBuilder builder = new StringBuilder();
            foreach (Entities.Reciept reciept in reciepts.Getlist4())
            {
                builder.AppendLine(reciept.Name);
            }
            ListViewName.Text = builder.ToString();
        }

        private void SouseButon_Click(object sender, RoutedEventArgs e)
        {
            ListViewName.Text = "";
            StringBuilder builder = new StringBuilder();
            foreach (Entities.Reciept reciept in reciepts.Getlist5())
            {
                builder.AppendLine(reciept.Name);
            }
            ListViewName.Text = builder.ToString();
        }

        private void DesertButon_Click(object sender, RoutedEventArgs e)
        {
            ListViewName.Text = "";
            StringBuilder builder = new StringBuilder();
            foreach (Entities.Reciept reciept in reciepts.Getlist6())
            {
                builder.AppendLine(reciept.Name);
            }
            ListViewName.Text = builder.ToString();
        }

        private void DrinkButon_Click(object sender, RoutedEventArgs e)
        {
            ListViewName.Text = "";
            StringBuilder builder = new StringBuilder();
            foreach (Entities.Reciept reciept in reciepts.Getlist7())
            {
                builder.AppendLine(reciept.Name);
            }
            ListViewName.Text = builder.ToString();
        }
        #endregion

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            foreach (Entities.Description description in descritions.GetDescription())
            {               
                builder.AppendLine(description.Method);
            }
            Description.Text = builder.ToString();

            StringBuilder builder1 = new StringBuilder();
            foreach (Entities.Ingredient ingredient in ingredients.GetIngredients())
            {
                builder1.AppendLine(ingredient.Ingredients);
            }
            Ingredients_text.Text = builder1.ToString();
        }

        private void FoundButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ServiceButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Свіжу зелень (петрушку, кріп, базилік, кінзу) можна зберігати як квіти:" +
                " поставити в склянку з водою і тримати на кухонному столі чи підвіконні." +
                " По-перше, це красиво." +
                " А, по-друге, це дозволить травам бути свіжими на пару днів довше, ніж в холодильнику.");
        }

        private void QuestionButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Розроблювачі: Соломон Юрій та Сироткіна Світлана");
        }

        private void MenuButon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseButon_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }       

        /// <summary>
        /// При загрузке программы подключаемся к базе данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
                try
                {                    
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }          
        }      
    }
}
