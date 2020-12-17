using Fitness.BL.Controller;
using Fitness.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Fitness NH");
            Console.WriteLine("Введите имя пользователя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол:");
            var gender = Console.ReadLine();
            
            Console.WriteLine("Введите дату рождения:");
            var birthDate = DateTime.Parse(Console.ReadLine()); //TODO: Переписать c TryParse

            Console.WriteLine("Введите вес:");
            var weight = double.Parse(Console.ReadLine()); //TODO: Переписать c TryParse
            
            Console.WriteLine("Введите рост:");
            var height = double.Parse(Console.ReadLine()); //TODO: Переписать c TryParse

            var userController = new UserController(name, gender, birthDate, weight, height);
            
            BinaryFormatter formatter = new BinaryFormatter();

            using (var fileStream = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, userController);
            }
        }
        
    }
}
