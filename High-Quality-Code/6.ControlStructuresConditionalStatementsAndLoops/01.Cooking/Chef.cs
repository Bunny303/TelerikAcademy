using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cooking
{
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = GetBowl();
            Carrot carrot = GetCarrot();
            Potato potato = GetPotato();
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            //... 
        }

        private Carrot GetCarrot()
        {
            //...
        }

        private Potato GetPotato()
        {
            //...
        }

        private void Cut(Vegetable vegetable)
        {
            //...
        }
    }
}
