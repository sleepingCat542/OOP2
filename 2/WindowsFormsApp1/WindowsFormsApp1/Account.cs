using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Account
    {
        public string number { get; set; }
        [XmlIgnore]
        public string[] listOfDepositType = new string[]
        {
            "С капитализацией ", "До востребования", "Срочные вклады", "Накопительные вклады",
            "Расчетные вклады", "Целевые на детей", "Номерные вклады"
        };
        public string depositType { get; set; }
        public string balance { get; set; }
        public string openingDate { get; set; }
        public Owner Owner { get; set; }
        public History History { get; set; }
        public bool smsAlert { get; set; }
        public bool internetBanking { get; set; }

        public Account() { }
        public Account(string num, string type, string money, string data, Owner own, History hist)
        {
            number = num;
            depositType = type;
            balance = money;
            openingDate = data;
            Owner = own;
            History = hist;
            smsAlert = false;
            internetBanking = false;

        }
        public string ShowAllInformation()
        {
            string bank;
            string sms;
            if (this.internetBanking) bank = "подключён";
            else bank = "не подключён";
            if (this.smsAlert) sms = "подключена";
            else sms = "не подключена";
            return "\r\n\r\nНомер счёта: " + this.number +
                "\r\nТекущий баланс: " + this.balance+" рублей" +
                "\r\nТип вклада: " + this.depositType +
                "\r\nПодключение смс оповещений: " + sms +
                "\r\nПодключение интернет-банкинга: " + bank +
                "\r\nДата открытия счёта: " + this.openingDate +
                "\r\n\n\tИнформация о владельце:\r\nИмя: " + this.Owner.Name + "\r\nФамилия: " + this.Owner.Surname +
                "\r\nОтчество: " + this.Owner.MidName +
                "\r\nСерия и номер паспорта: " + this.Owner.passportSeries + " " + this.Owner.passportId+
                "\r\nДата рождения: " + this.Owner.Birthday +
                "\r\n\n\tИнформация об операциях: "+
                "\r\nОперация: " + this.History.TypeOfOperation +
                "\r\nСумма: " + this.History.count +
                "\r\nДата проведения операции: " + this.History.dataOfOreration;
        }

    }
}
