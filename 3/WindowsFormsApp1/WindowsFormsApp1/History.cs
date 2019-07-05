using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class History
    {
        public string[] operationType = new string[] {"Перевод", "Снятие", "Добавление"};
        public string TypeOfOperation {get; set;}
        public string count { get; set; }
        public string dataOfOreration {get; set;}

        public History() { }
        public History(string typeOp, string countOp, string dataOp)
        {
            TypeOfOperation = typeOp;
            count = countOp;
            dataOfOreration = dataOp;
        }
    }
}
