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
using System.Collections.Specialized;
using System.Configuration;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string str;
        public static string str2;
        public static string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        SqlConnection connection;       // для создания канала связи между программой и источником данных 
        SqlCommand command;
        SqlDataAdapter adapter1;        // для заполнения DataSet (образ бд) и обновления БД 
        SqlDataAdapter adapter2;
        DataTable dataOwner;             // таблица бд  dataComp
        DataTable dataAccount;            //dataProc
        bool fl = false;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string sqlExpression = "SELECT * FROM Account";
                dataAccount = new DataTable();
                command = new SqlCommand(sqlExpression, connection);
                adapter1 = new SqlDataAdapter(command);
                adapter1.Fill(dataAccount);
                dataGridAcc.ItemsSource = dataAccount.DefaultView;

                string sqlExpression2 = "SELECT * FROM Owner";
                dataOwner = new DataTable();
                command = new SqlCommand(sqlExpression2, connection);
                adapter2 = new SqlDataAdapter(command);
                adapter2.Fill(dataOwner);
                dataGridOwn.ItemsSource = dataOwner.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void UpdateDB()
        {
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(adapter1);  // автоматич генер-т команды, кот позволяют согласовать изменения, 
            SqlCommandBuilder comandbuilder2 = new SqlCommandBuilder(adapter2); // вносимые в объект dataset, со связанной бд
            adapter1.Update(dataAccount);
            adapter2.Update(dataOwner);
        }

        private void GetOwners()
        {
            string sqlExpression = "inser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    var reader = command.ExecuteReader();
                    reader.Close();
                    Window_Loaded(new object(), new RoutedEventArgs());
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            fl = true;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateDB();
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridAcc.SelectedItems != null)
            {
                for (int i = 0; i < dataGridAcc.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = dataGridAcc.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            if (dataGridOwn.SelectedItems != null)
            {
                for (int i = 0; i < dataGridOwn.SelectedItems.Count; i++)
                {
                    DataRowView datarowView = dataGridOwn.SelectedItems[i] as DataRowView;
                    if (datarowView != null)
                    {
                        DataRow dataRow = (DataRow)datarowView.Row;
                        dataRow.Delete();
                    }
                }
            }
            UpdateDB();
        }

        private void StoredProc_Click(object sender, RoutedEventArgs e)
        {
            if (fl)
                MessageBox.Show("Хранимая процедура была выполнена!");
            else
                GetOwners();
        }

        private void Script_Click(object sender, RoutedEventArgs e)
        {
            SqlTransaction tx = null;
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    tx = connection.BeginTransaction();  //начали транзакцию
                    SqlCommand command = connection.CreateCommand();
                    command.Transaction = tx;//Чтобы все операции с объектом SqlCommand выполнялись как одна транзакция, надо присвоить объект транзакции его свойству Transaction
                    try
                    {
                        command.CommandText = "Delete Owner where Passport='MP3242423'";
                        command.ExecuteNonQuery();
                        command.CommandText = "INSERT INTO Owner (Full_Name, Birthday, Passport) VALUES('Жировкин А.А.', '1996-04-23', 'MP3342546')";
                        command.ExecuteNonQuery();

                        tx.Commit();
                        MessageBox.Show("транзакция выполнена");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("транзакция не выполнена" + ex.Message);
                        tx.Rollback();
                    }

                    Window_Loaded(new object(), new RoutedEventArgs());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

    }
}

