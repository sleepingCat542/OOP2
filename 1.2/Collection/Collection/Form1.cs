using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<People> collection;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void SortDown_Click(object sender, EventArgs e)
        {
            try
            {
                listView2.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Коллекция пустая!");
                }
                else
                {
                    collection.Sort();
                    collection.Reverse();
                    foreach (People pe in collection)
                    {
                        listView2.Items.Add($"{pe.name},  {pe.age}, {pe.lovePet}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortUp_Click(object sender, EventArgs e)
        {
            try
            {
                listView2.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Коллекция пустая!");
                }
                else
                {
                    collection.Sort();
                    foreach (People pe in collection)
                    {
                        listView2.Items.Add($"{ pe.name},  { pe.age}, { pe.lovePet}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)//генерация
        {
            try
            {
                if(textBox1.Text=="")
                {
                    throw new Exception("Введите значение!");
                }
                int size = Convert.ToInt32(textBox1.Text);
                if (size > 30)
                    throw new Exception("Не надо так много\nЗадайте число до 30");
                listView1.Clear();
                listView2.Clear();
                if (textBox1.Text == "" || textBox1.Text == "0")
                {
                    this.collection = null;
                    throw new Exception("Коллекция пустая!");
                }
                else
                {
                    int countOfPeople = Convert.ToInt32(textBox1.Text);
                    collection = new List<People>(countOfPeople);
                    People people;
                    for (int i = 0; i < countOfPeople; i++)
                    {
                        people = new People();
                        collection.Add(people);
                    }
                    foreach (People pe in collection)
                    {
                        listView1.Items.Add($"{ pe.name},  { pe.age}, { pe.lovePet}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLINQ1_Click(object sender, EventArgs e)
        {
            try
            {
                listView2.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Коллекция пустая!");
                }
                else
                {
                    listView2.Items.Add("Люди, которые любят собак или кошек:");
                    var query = collection
                        .Where(p => p.lovePet == "Собака" || p.lovePet == "Кошка")
                        .Select(p => p);
                    foreach (var s in query)
                    {
                        listView2.Items.Add($"{s.name}, {s.age}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLINQ2_Click(object sender, EventArgs e)
        {
            try
            {
                listView2.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Коллекция пустая!");
                }
                else
                {
                    listView2.Items.Add("Три старших человека:");
                    var query = collection
                        .OrderByDescending(p => p.age)
                        .Take(3)
                        .Select(p => p);
                    foreach (var pe in query)
                    {
                        listView2.Items.Add($"{ pe.name},  { pe.age}, { pe.lovePet}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLINQ3_Click(object sender, EventArgs e)
        {
            try
            {
                listView2.Clear();
                if (collection == null || collection.Count == 0)
                {
                    throw new Exception("Коллекция пустая!");
                }
                else
                {
                    listView2.Items.Add("В имени есть буква и на 2-ом месте:");
                    var query = collection
                        .Where(p => p.name.Contains('и'))
                        .Where(p => p.name[1] == 'и')
                        .Select(p => p);
                    foreach (var pe in query)
                    {
                        listView2.Items.Add($"{ pe.name},  { pe.age}, { pe.lovePet}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    button1_Click(sender, e);
                }
                else if (e.KeyCode != Keys.D0 && e.KeyCode != Keys.D1 && e.KeyCode != Keys.D2 && e.KeyCode != Keys.D3
                    && e.KeyCode != Keys.D4 && e.KeyCode != Keys.D5 && e.KeyCode != Keys.D6 && e.KeyCode != Keys.D7 && e.KeyCode != Keys.D8
                    && e.KeyCode != Keys.D9 && e.KeyCode != Keys.Back)
                {
                    throw new Exception("Нельзя нажимать эту клавишу");
                }
            }
            catch (Exception ex)
            {
                textBox1.Clear();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
