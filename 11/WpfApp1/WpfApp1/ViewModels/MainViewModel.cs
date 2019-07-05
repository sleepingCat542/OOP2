using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
        class MainViewModel : ViewModelBase
        {
            public ObservableCollection<DisciplinesViewModel> DisciplinesList { get; set; }

            #region Constructor

            public MainViewModel(List<Disciplines> dist)
            {
                DisciplinesList = new ObservableCollection<DisciplinesViewModel>(dist.Select(b => new DisciplinesViewModel(b)));
            }

            #endregion
        }    
}
