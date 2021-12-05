using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{

    //1.Создать класс для моделирования счета в банке.
    //  Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
    //  Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
    //  Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
    //  Создать  несколько экземпляров класса, параметризированного различными типам.
    //  Заполнить его поля и вывести информацию об экземпляре класса на печать.


    class Program
    {
        static void Main(string[] args)
        {
            Accaunt<double> accaunt1 = new Accaunt<double>();
            Console.WriteLine("Заполните информацию по аккаунту");
            Console.WriteLine("Заполните Ф.И.О.");
            string name = Console.ReadLine();
            Console.WriteLine("Заполните номер счета");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Заполните баланс");
            double balance = Convert.ToDouble(Console.ReadLine());
            accaunt1.AccaunWrite(number,name,balance);
            accaunt1.AccauntRead();

            Accaunt<string> accaunt2 = new Accaunt<string>();
            accaunt2.AccaunWrite("№000001", "Алексеев В.А.", 9999999999);
            accaunt2.AccauntRead();
            Console.ReadKey();
        }
    }
    class Accaunt<T>
    {
        private T accountNumber { get; set; }
        private string accountName { get; set; }
        private double accountBalance { get; set; }

        public void AccaunWrite(T number, string name, double balance)
        {
            
            this.accountName = name;
            this.accountNumber = number;
            this.accountBalance = balance;

        }

        public void AccauntRead()
        {
            Console.WriteLine("Информация о счете в банке:\nНомер счета: {0}\nФИО: {1}\nБаланс: {2}\n",accountNumber,accountName,accountBalance );
        }
    }
}
