using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkBehavior tea = new Tea();
            tea.Make();
            DrinkBehavior coffee = new Coffee(true);
            coffee.Make();
            Console.Read();
        }
    }
}
