using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoesWPFMenu
{
    class MenuItem
    {
        public Random Randomizer = new Random();

        public string[] Proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };

        public string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };

        public string[] Breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string Description = "";

        public string Price;

        public void Generate()
        {
            string randomProtein = Proteins[Randomizer.Next(Proteins.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            Description = randomProtein + " with " + randomCondiments + " on " + randomBreads;

            decimal pounds = Randomizer.Next(2, 5);
            decimal pence = Randomizer.Next(1, 98);
            decimal price = pounds + (pence * .01M);
            Price = price.ToString("c"); //"c" ensures the format to local currencys.
        }
    }
}
