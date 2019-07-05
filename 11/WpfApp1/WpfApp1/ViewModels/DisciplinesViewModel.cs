using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    class DisciplinesViewModel : ViewModelBase
    {
        public Disciplines Disciplines;

        public DisciplinesViewModel(Disciplines disciplines)
        {
            this.Disciplines = disciplines;
        }

        public string Name
        {
            get { return Disciplines.Name; }
            set
            {
                Disciplines.Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Lector
        {
            get { return Disciplines.Lector; }
            set
            {
                Disciplines.Lector = value;
                OnPropertyChanged("Lector");
            }
        }

        public int Hours
        {
            get { return Disciplines.Hours; }
            set
            {
                Disciplines.Hours = value;
                OnPropertyChanged("Hours");
            }
        }

        public int Liseners
        {
            get { return Disciplines.Liseners; }
            set
            {
                Disciplines.Liseners = value;
                OnPropertyChanged("Liseners");
            }
        }

        public int Count
        {
            get { return Disciplines.Count; }
            set
            {
                Disciplines.Count = value;
                OnPropertyChanged("Count");
            }
        }

        #region Commands

        #region Добавить

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null)
                {
                    getItemCommand = new DelegateCommand(GetItem);
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        {
            if(Count<Liseners)
                Count++;
        }

        #endregion

        #region Отменить

        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);
                }
                return giveItemCommand;
            }
        }

        private void GiveItem()
        {
            if(Liseners > 0)
            Count--;
        }

        private bool CanGiveItem()
        {
            return Count > 0;
        }

        #endregion

        #endregion
    }

}
