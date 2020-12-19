using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fitness.BL.Controller
{
    public class DatabaseSaver : IDataSaver
    {
        public List<T> Load<T>() where T : class
        {
            var options = GetOptions();
            using (var db = new FitnessContext(options))
            {
                var result = db.Set<T>().Where(t => true).ToList();
                return result;
            }
        }
        public void Save<T>(List<T> item) where T : class
        {
            var options = GetOptions();
            using (var db = new FitnessContext(options))
            {
                db.Set<T>().AddRange(item);
                db.SaveChanges();
            }
        }

        private DbContextOptions<FitnessContext> GetOptions()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("fitnessconfig.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<FitnessContext>();
            return optionsBuilder
                .UseSqlServer(connectionString)
                .Options;
        }
    }
}
