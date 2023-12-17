using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class Coffee: DrinkBehavior
    {
        private bool _isAddish;

        public Coffee(bool isAddish)
        {
            _isAddish = isAddish;
        }
        protected override void Brew()
        {
            Console.WriteLine("Кофе заварен");
        }
        protected override void AddСomponents()
        {
            if (IsAddish())
            {
                Console.WriteLine("В кофе добавлен сахар с молоком");
            }
            else
            {
                Console.WriteLine("Кофе без добавок");
            }
        }
        protected override bool IsAddish()
        {
            return _isAddish;
        }
    }
}
