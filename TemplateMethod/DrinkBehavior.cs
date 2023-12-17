using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal abstract class DrinkBehavior
    {
        public void Make()
        {
            BoilerWater();
            Brew();
            PourIntoMug();
            if (IsAddish())
            {
                AddСomponents();
            }
        }

        public void BoilerWater()
        {
            Console.WriteLine("\nКипятим воду");
        }

        public void PourIntoMug()
        {
            Console.WriteLine("Наливаем в кружку");
        }

        protected abstract void Brew();
        protected abstract void AddСomponents();
        protected virtual bool IsAddish()
        {
            return true;
        }
    }
}
