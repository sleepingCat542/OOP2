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
        Model1 model = new Model1();
        static TextBox book;
        static TextBox name;
        static TextBox author;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            model.Book.Load();
            model.Reader.Load();
            dgActors.ItemsSource = model.Book.Local.ToBindingList();
            dgUsers.ItemsSource = model.Reader.Local.ToBindingList();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            model.Dispose();
        }


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
                
                model.SaveChanges();
                Window_Loaded(new object(), new RoutedEventArgs());
                txt_Book.Text = "";
                txt_Author.Text = "";
                txt_Name.Text = "";
            }
        }

        public static async Task FindObject()
        {
            using (Model1 db = new Model1())
            {
                string str = "";
                if (book.Text.Length != 0)
                {
                    try
                    {
                        var bookFind = db.Book.Where(ac => ac.Book1 == book.Text).Single();
                        int id = bookFind.IDbook;
                        var a = await db.Book.FindAsync(id);
                        str = a.IDbook + " " + a.Book1;
                        MessageBox.Show(str);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Не найдено" +ex.Message);
                    }

                }
                if (name.Text.Length != 0)
                {
                    try
                    {
                        var user = db.Reader.Where(us => us.Surname == name.Text).Single();
                        int id = user.IDReader;
                        var a = await db.Reader.FindAsync(id);
                        str = a.IDReader + " " + a.Surname;
                        MessageBox.Show(str);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не найдено" + ex.Message);
                    }
                }
                if (author.Text.Length != 0)
                {
                    try
                    {
                        var auth = db.Book.Where(us => us.Author == author.Text).Single();
                        int id = auth.IDbook;
                        var a = await db.Book.FindAsync(id);
                        str = a.IDbook + " " + a.Book1+a.Author;
                        MessageBox.Show(str);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не найдено" + ex.Message);
                    }
                }
                db.SaveChanges();
                book.Text = "";
                name.Text = "";
                author.Text = "";
            }
        }

        private void btn_find_Click(object sender, RoutedEventArgs e)
        {
            book = txt_Book;
            name = txt_Name;
            author = txt_Author;
            FindObject().GetAwaiter();
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
                            Book a = model.Book.Find(id);
                            a.Book1 = txt_Book.Text;
                            model.Entry(a).State = EntityState.Modified;
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
                            Reader u = model.Reader.Find(id);
                            u.Surname = txt_Name.Text;
                            model.Entry(u).State = EntityState.Modified;
                        }
                    }
                }
                model.SaveChanges();
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
                        if (actor != null)
                        {
                            Book a = model.Book.Find(id);
                            model.Book.Remove(a);
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
                            Reader u = model.Reader.Find(id);
                            model.Reader.Remove(u);
                        }
                    }
                }
                model.SaveChanges();
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
            using (Model1 db = new Model1())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        Reader user = db.Reader.FirstOrDefault(p => p.Surname == "Ивовович");
                        MessageBox.Show(user.Surname);
                        string str = "ID\tName\n";
                        var query = db.Database.SqlQuery<Reader>("select * from Reader;");
                        for (int i = 0; i < query.Count(); i++)
                        {
                            str += query.ElementAt(i).IDReader + "\t" +
                                query.ElementAt(i).Surname + "\t\n";
                        }
                        MessageBox.Show(str);
                        db.SaveChanges();
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
}
