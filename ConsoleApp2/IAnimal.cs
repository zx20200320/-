using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IAnimal
    {
        /// <summary>
        /// 名称
        /// </summary>
       string Name{ get; set; }
        /// <summary>
        /// 生活区域
        /// </summary>
        string Live { get; set; }
        /// <summary>
        /// 爱好
        /// </summary>
        string Hobbe { get; set; }
        /// <summary>
        /// 习惯
        /// </summary>
        string Habit { get; set; }

        /// <summary>
        /// 吃东西的方法
        /// </summary>
        void Eat();
        /// <summary>
        /// 睡觉的方法
        /// </summary>
        void Sleep();
    }
}
