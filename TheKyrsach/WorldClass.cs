using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheKyrsach
{
    public class World
    {
        private static World instance;

        public static World Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new World();
                }
                return instance;
            }
        }

        private World()
        {
            Predators = new List<Organism>();
            Herbivores = new List<Organism>();
            Plants = new List<Organism>();
            Insects = new List<Organism>();
        }

        public List<Organism> Predators { get; set; }
        public List<Organism> Herbivores { get; set; }
        public List<Organism> Plants { get; set; }
        public List<Organism> Insects { get; set; }

        public List<Organism> AllOrganisms = new List<Organism>();


        public void AddPredator(Organism predator)
        {
            Predators.Add(predator);
        }

        public void AddHerbivore(Organism herbivore)
        {
            Herbivores.Add(herbivore);
        }

        public void AddPlant(Organism plant)
        {
            Plants.Add(plant);
        }

        public void AddInsect(Organism insect)
        {
            Insects.Add(insect);
        }

        public void AddOrganism(Organism entity)
        {
            AllOrganisms.Add(entity);
        }

        public void RemoveOrganism(int n)
        {
            AllOrganisms.RemoveAt(n);

        }

        public List<Organism> GetPredators()
        {
            return Predators;
        }

        public List<Organism> GetHerbivores()
        {
            return Herbivores;
        }

        public List<Organism> GetPlants()
        {
            return Plants;
        }

        public List<Organism> GetInsects()
        {
            return Insects;
        }




    }

}
