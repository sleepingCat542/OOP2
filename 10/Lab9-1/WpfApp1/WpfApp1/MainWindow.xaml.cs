using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        //Model1 model = new Model1();
        //static TextBox book;
        //static TextBox name;
        //static TextBox author;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgUsers.ItemsSource = null;
            dgActors.ItemsSource = null;
            //model.Book.Load();
            //model.Reader.Load();
            dgActors.ItemsSource = unitOfWork.Books.Get();
            dgUsers.ItemsSource = unitOfWork.Readers.Get();
        }

        //private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    model.Dispose();
        //}



        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            using (Model1 model = new Model1())
            {
                Book book1 = null;
                
                if (txt_Name.Text.Length != 0 && txt_Book.Text.Length != 0 && txt_Author.Text.Length != 0)
                {
                    
                    book1 = new Book { Book1 = txt_Book.Text, Author = txt_Author.Text };
                    model.Book.Add(book1);
                    Reader read1 = new Reader { Surname = txt_Name.Text, Book = book1 };
                    model.Reader.Add(read1);
                }
                else if (txt_Book.Text.Length != 0 && txt_Author.Text.Length != 0)
                {
                    book1 = new Book { Book1 = txt_Book.Text, Author = txt_Author.Text };
                    model.Book.Add(book1);
                }
                else
                {
                    MessageBox.Show("Заполните все поля для добавления книги.");
                }
                
                //model.SaveChanges();
                Window_Loaded(new object(), new RoutedEventArgs());
                txt_Book.Text = "";
                txt_Author.Text = "";
                txt_Name.Text = "";
            }
        }

        //public static async Task FindObject()
        //{
            
        //}

        private void btn_find_Click(object sender, RoutedEventArgs e)
        {
            //book = txt_Book;
            //name = txt_Name;
            //author = txt_Author;
            string str = "";
                if (txt_Book.Text.Length != 0)
                {
                    try
                    {
                    var bookFind = unitOfWork.Books.Get(ac => ac.Book1 == txt_Book.Text);
                    Book[] el = new Book[bookFind.Count()];
                    int i = 0;
                    foreach (Book b in bookFind)
                    {
                        el[i] = unitOfWork.Books.FindById(b.IDbook);
                        str += el[i].IDbook + " " + el[i].Book1+"\n";
                        i++;
                    }
                    MessageBox.Show(str);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Не найдено" + ex.Message);
                    }

                }
                if (txt_Name.Text.Length != 0)
                {
                    try
                    {
                        var user = unitOfWork.Readers.Get(us => us.Surname == txt_Name.Text);
                        Reader[] el = new Reader[user.Count()];
                        int i = 0;
                    foreach (Reader b in user)
                    {
                        el[i] = unitOfWork.Readers.FindById(b.IDReader);
                        str += el[i].IDReader + " " + el[i].Surname+ "\n";
                        i++;
                    }
                        MessageBox.Show(str);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не найдено" + ex.Message);
                    }
                }
                if (txt_Author.Text.Length != 0)
                {
                    try
                    {
                    var auth = unitOfWork.Books.Get(us => us.Author == txt_Author.Text);
                    Book[] el = new Book[auth.Count()];
                    int i = 0;
                    foreach (Book b in auth)
                    {
                        el[i] = unitOfWork.Books.FindById(b.IDbook);
                        str += el[i].IDbook + " " + el[i].Book1 + el[i].Author + "\n";
                        i++;
                    }
                    
                        MessageBox.Show(str);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не найдено" + ex.Message);
                    }
                }
                txt_Author.Text = "";
                txt_Book.Text = "";
                txt_Name.Text = "";
            }
        

        private void btn_update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgActors.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgActors.SelectedItems.Count; i++)
                    {
                        Book actor = dgActors.SelectedItems[i] as Book;
                        int id = actor.IDbook;
                        if (actor != null)
                        {
                            Book a = unitOfWork.Books.FindById(id);
                            a.Book1 = txt_Book.Text;
                            unitOfWork.Books.Update(a);
                        }
                    }
                }
                if (dgUsers.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgUsers.SelectedItems.Count; i++)
                    {
                        Reader user = dgUsers.SelectedItems[i] as Reader;
                        int id = user.IDReader;
                        if (user != null)
                        {
                            Reader u = unitOfWork.Readers.FindById(id);
                            u.Surname = txt_Name.Text;
                            unitOfWork.Readers.Update(u);
                        }
                    }
                }
                Window_Loaded(new object(), new RoutedEventArgs());
                txt_Book.Text = "";
                txt_Name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgActors.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgActors.SelectedItems.Count; i++)
                    {
                        Book actor = dgActors.SelectedItems[i] as Book;
                        int id = actor.IDbook;
                        Book a = unitOfWork.Books.FindById(id);
                        unitOfWork.Books.Remove(a);
                    }
                }

                if (dgUsers.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < dgUsers.SelectedItems.Count; i++)
                    {
                        Reader user = dgUsers.SelectedItems[i] as Reader;
                        int id = user.IDReader;            
                        Reader a = unitOfWork.Readers.FindById(id);
                        unitOfWork.Readers.Remove(a);
                    }
                }
                Window_Loaded(new object(), new RoutedEventArgs());
                txt_Book.Text = "";
                txt_Name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_transact_Click(object sender, RoutedEventArgs e)
        {

                using (var transaction = unitOfWork.Readers.Transaction())
                {
                    try
                    {
                        Reader user = unitOfWork.Readers.Get(p => p.Surname == "Ивовович").Single();
                        MessageBox.Show(user.Surname);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("rollback" +ex.Message);
                        transaction.Rollback();
                    }
                }
            
        }
    }
}
