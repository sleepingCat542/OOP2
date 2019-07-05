using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Collection
{
    class People : IComparable<People>, IComparer<People>
    {
        public int age;
        //public int group;
       public string lovePet;
            //public int course;
            public string name;
            private string[] arrayOfNames = new string[10]
            {"Дарья", "Валентин", "Никита", "Владимир", "Николай", "Алеся", "Влада", "Эрика", "Анфиса", "Мария"};
            private string[] arrayOfPets = new string[8]
            {"Кошка","Собака", "Змея", "Хомяк", "Черепаха", "Попугай", "Кролик", "Паук"};

        public People()
            {
                Random random = new Random();
                Thread.Sleep(20);
                this.age = (int)random.Next(10, 60);
                this.lovePet = arrayOfPets[random.Next(0, 8)];
                this.name = arrayOfNames[random.Next(0, 10)];
            }

            public int Compare(People p1, People p2)
            {
                return p2.CompareTo(p1);
            }

            public int CompareTo(People people)
            {
                if (people == null)
                {
                    return 1;
                }
                else
                {
                    if (this.age > people.age)
                    {
                        return 1;
                    }
                    else if (this.age < people.age)
                    {
                        return -1;
                    }
                    else
                    {
                    return this.name.CompareTo(people.name);
                    }
                }
            }
        }
    }
