using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKyrsach
{
    // Базовый класс "Мир"

    public class Predator : Organism
    {
        public string HuntingMethod { get; set; }

        public void Hunt()
        {

        }

    }

    public class Herbivore : Organism
    {
        public string Diet { get; set; }

        public void Eat()
        {
            // Логика поиска и поедания пищи травоядного
        }
    }

    public class Plant : Organism
    {
        public string Type { get; set; }

        public void Grow()
        {
            // Логика роста растения
        }
    }
    // Класс "Насекомое"

    public class Insect : Organism
    {
        public string Wings { get; set; }

        public void Fly()
        {
            // Логика полета насекомого
        }
    }
    internal class HeirsClasses
    {
    }
}
