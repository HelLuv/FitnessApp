using System;
using System.Collections;
using System.Collections.Generic;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Активность
    /// </summary>
    [Serializable]
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Exercise> Exercises { get; set; }
        public double CaloriesPerMinute { get; set; }

        public Activity() { }

        public Activity(string name, double caloriesPerMinute)
        {
            // TODO: Проверка

            Name = name;
            CaloriesPerMinute = caloriesPerMinute;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
