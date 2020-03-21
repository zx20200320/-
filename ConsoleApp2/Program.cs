using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            tiger.Name = "老虎";
            tiger.Live = "森林";
            tiger.Hobbe = "肉";
            tiger.Habit = "地上";
            tiger.Eat();
            tiger.Sleep();


            Donkey donkey = new Donkey();
            donkey.Name = "毛驴";
            donkey.Live = "草原";
            donkey.Hobbe = "草";
            donkey.Habit = "地上";
            donkey.Eat();
            donkey.Sleep();


            Carp carp = new Carp();
            carp.Name = "鲤鱼";
            carp.Live = "水里";
            carp.Hobbe = "虾米";
            carp.Habit = "水里";
            carp.Eat();
            carp.Sleep();


            Goat goat = new Goat();
            goat.Name = "山羊";
            goat.Live = "山里";
            goat.Hobbe = "草";
            goat.Habit = "地上";
            goat.Eat();
            goat.Sleep();

            Console.WriteLine("gsfdgsfd");
            Console.WriteLine("工时费大概是大法官");
            Console.ReadKey();
        }
    }
}
