using System;

namespace Organization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var neko = new Account(17231, "neko", "Мяу Мряу Мурмяу", 23, AccessRightsType.Admin);
            Console.WriteLine(neko);
            Console.WriteLine(neko.IsAdult() ? "Совершеннолетний" : "Несовершеннолетний");

            Console.WriteLine(neko.IsAdmin() ? "Является администратором" : "Не является администратором");
            Console.WriteLine(neko.IsManager() ? "Является менеджером" : "Не является менеджером");
            Console.WriteLine(neko.IsEmployee() ? "Является сотрудником" : "Не является сотрудником");
            Console.WriteLine(neko.IsGuest() ? "Является гостем" : "Не является гостем");
        }
    }
}