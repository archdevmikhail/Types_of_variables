// Урок 3 - Типы переменных
// Создадим несколько своих классов и переменных разных типов,
// а также метод для вывода значений за место true и false
 
namespace Types_of_variables 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var account = new BankAccount();

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"Имя пользователя: {user.Name}");
            Console.WriteLine($"Возраст: {user.Age}");
            Console.WriteLine($"ИНН: {user.Inn}");

            Console.WriteLine($"Номер клиента: {account.BankId}"); 
            Console.WriteLine($"Номер счёта: {account.Ban}"); 
            Console.WriteLine($"Баланс счёта: {account.Balance}"); 
            Console.WriteLine($"Валюта счёта: {account.Currency}"); 
            Console.WriteLine($"Налоговая ставка: {account.TaxRate}%");
            Console.WriteLine($"Группа клиента: {account.GroupUser}");
            Console.WriteLine($"Статус блокировки: {account.GetBlackListStatus()}");

            Console.ReadKey();
        }
    }


    class User
    {
        public string Name { get; set; } = "Иванов Иван";
        public short Age { get; set; } = 37;
        public long Inn { get; set; } = 68378547873858;
    }

    class BankAccount
    {
        
        public int BankId { get; set; } = 1067642476;
        public long Ban { get; set; } = 5578478567898754367;
        public double Balance { get; set; } = 10500.70;
        public char Currency { get; set; } = '$';
        public decimal TaxRate { get; set; } = 1.7m;
        public byte GroupUser { get; set; } = 21;
        public bool BlackList { get; set; } = false;
        public string GetBlackListStatus() 
        {
            return BlackList ? "В чёрном списке" : "Нет в чёрном списке"; 
        }
        // "?" - в данном случае это Тернарный оператор
    }
}
