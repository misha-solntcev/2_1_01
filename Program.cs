/*1.Напишите программу, которая запрашивает количество секунд в виде целого
значения и затем отображает эквивалентное значение в сутках, часах, минутах и
секундах. Для представления количества часов в сутках, количества минут в часе и
количества секунд в минуте используйте символические константы.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int data = 60*60*24*33 + (60*60*3) + (60*3) + 33;

            /// Первый способ:

            int day = data / (60*60*24);
            int hour = (data - day * (60*60*24)) / (60*60);
            int minute = (data - day * (60 * 60 * 24) - hour * (60*60)) / 60;
            int seconds = data - day * (60 * 60 * 24) - hour * (60 * 60) - minute * (60);  

            Console.WriteLine("data: {0}, /// {1} суток, {2} часов, {3} минут, {4} секунд",
                data, day, hour, minute, seconds);
            
            /// Второй способ:

            day = data/(60*60*24);
            hour = data%(60*60*24)/(60*60);
            minute = data%(60*60*24)%(60*60)/60;
            seconds = data%(60*60*24)%(60*60)%(60);

            Console.WriteLine("data: {0}, /// {1} суток, {2} часов, {3} минут, {4} секунд",
                data, day, hour, minute, seconds);
            Console.ReadLine();
        }
    }
}
