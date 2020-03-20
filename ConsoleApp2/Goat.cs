using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// 山羊类
    /// </summary>
    public class Goat : IAnimal
    {
        public string Name { get ; set ; }
        public string Live { get ; set ; }
        public string Hobbe { get; set ; }
        public string Habit { get; set ; }

        public void Eat()
        {
            Console.Write($"{Name}生活在{Live}、喜欢吃{Hobbe}、");
        }

        public void Sleep()
        {
            Console.WriteLine($"习惯在{Habit}睡觉");
        }
    }
}
