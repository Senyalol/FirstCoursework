using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheKyrsach.Form1;
using static TheKyrsach.Organism;
using static TheKyrsach.World;

namespace TheKyrsach
{

    internal class DataBank
    {

        private string l;
        public int i { get; set; }

        public bool P { get; set; }
        public bool H { get; set; }

        public bool Plants { get; set; }

        public bool I { get; set; }


        public DataBank(string l)
        {
            this.l = l;
        }

        //Метод для добавления организма в лист
        public  World GetDataAboutOrganisms(Organism SomeOrganism)
        {
            World.Instance.AllOrganisms.Add(SomeOrganism);


            return World.Instance;
        }
        
        public World GetDataAboutPredator(Predator SomePredator)
        {
            World.Instance.AddPredator(SomePredator);
            return World.Instance;
        }

        public World GetDataAboutHerbivore(Herbivore SomeHerbivore)
        {
            World.Instance.Herbivores.Add(SomeHerbivore);
            return World.Instance;
        }

        public World GetDataAboutPlant(Plant SomePlant )
        {
            World.Instance.Plants.Add(SomePlant);
            return World.Instance;
        }

        public World GetDataAboutInsect(Insect SomeInscet)
        {
            World.Instance.Insects.Add(SomeInscet);
            return World.Instance;
        }

        //Метод для передачи индекса между формами
        public int SaveDataAboutIndex(int index1)
        {
            this.i = index1;
            return this.i;
        }

        //Метод для редактирования организма
        public World SetDataAboutOrganism(string n,string c, string s, int count , string b,int index)
        {

            for(int i = 0; i < World.Instance.AllOrganisms.Count; i++)
            {

                if(i == index)
                {

                    World.Instance.AllOrganisms[i].Name = n;
                    World.Instance.AllOrganisms[i].Class = c;
                    World.Instance.AllOrganisms[i].Species = s;
                    World.Instance.AllOrganisms[i].Quantity = count;
                    World.Instance.AllOrganisms[i].Behavior = b;
                
                }

            }

                



            

            return World.Instance;
        }


        public World SetDataAboutPredator(string n, string c , string s, int count, string b,int i)
        {

            for (int index = 0; index < World.Instance.Predators.Count; index++)
            {

                if(index == i)
                {
                World.Instance.Predators[index].Name = n;
                World.Instance.Predators[index].Class = c;
                World.Instance.Predators[index].Species = s;
                World.Instance.Predators[index].Quantity = count;
                World.Instance.Predators[index].Behavior = b;

                }


            }


            return World.Instance;
        }

        public World SetDataAboutHerbivore(string n , string c , string s, int count, string b,  int index)
        {

            for(int i = 0; i < World.Instance.Herbivores.Count; i++)
            {

                if(i == index)
                {

            World.Instance.Herbivores[i].Name = n;
            World.Instance.Herbivores[i].Class = c;
            World.Instance.Herbivores[i].Species = s;
            World.Instance.Herbivores[i].Quantity = count;
            World.Instance.Herbivores[i].Behavior = b;
                }

            }



            return World.Instance;
        }

        public World SetDataAboutPlant(string n , string c, string s, int count, string b, int index)
        {
            for(int i = 0; i < World.Instance.Plants.Count; i++)
            {
                if(i == index)
                {

            World.Instance.Plants[i].Name = n;
            World.Instance.Plants[i].Class = c;
            World.Instance.Plants[i].Species = s;
            World.Instance.Plants[i].Quantity = count;
            World.Instance.Plants[i].Behavior = b;
                }

            }


            return World.Instance;
        }

        public World SetDataAboutInscet(string n, string c , string s, int count, string b, int index)
        {

            for(int i = 0; i < World.Instance.Insects.Count; i++)
            {

                if(i == index)
                {

            World.Instance.Insects[i].Name = n;
            World.Instance.Insects[i].Class = c;
            World.Instance.Insects[i].Species = s;
            World.Instance.Insects[i].Quantity = count;
            World.Instance.Insects[i].Behavior = b;
                }

            }




            return World.Instance;
        }

        public World AddPredator(Predator predator)
        {

            World.Instance.Predators.Add(predator);

            return World.Instance;

        }

        public World AddHerbivore(Herbivore trav) {
        
            World.Instance.Herbivores.Add(trav);

            return World.Instance;
        }
        
        public World AddPlant(Plant plant)
        {
            World.Instance.Plants.Add(plant);

            return World.Instance;
        }


        public World RemovePredator(int ind)
        {
            this.i = ind;
            World.Instance.Predators.RemoveAt(this.i);

            return World.Instance;
        }

        public World RemoveHerbivore(int ind)
        {
            World.Instance.Herbivores.RemoveAt(ind);

            return World.Instance;
        }

        public World RemovePlant(int ind)
        {
            World.Instance.Plants.RemoveAt(ind);

            return World.Instance;
        }

        public World RemoveInsect(int ind)
        {
            World.Instance.Insects.RemoveAt(ind);
            return World.Instance;
        }

        public World AddInsect(Insect insect)
        {
            World.Instance.Insects.Add(insect);
            return World.Instance;
        }
        //Метод для проверки 
        public int CheckDataAboutChoose(int i1)
        {
            i = i1;
            return i;
        }
       
      
        //public World ShowDataAboutOrganism()
        //{

        //}

    }



}
