using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheKyrsach.Form1;

namespace TheKyrsach
{
   
    public partial class Form2 : Form
    {
        //public Form1 forma1;
        public Form2(/*Form1 form1*/)
        {
            InitializeComponent();
            //forma1 = form1;
        }

        //Проверка на числа и цифры
        private bool CheckForDigitsAndNumbers(string input)
        {
            bool containsDigits = input.Any(char.IsDigit);
            bool containsNumbers = input.Any(char.IsNumber);

            if (containsDigits || containsNumbers)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //Возвращает истину , если строка содержит только числа
        private bool IsStringContainingOnlyNumbers(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false; // Если найден нецифровой символ, возвращаем false
                }
            }
            return true; // Если все символы - цифры, возвращаем true
        }

        //Проверка на спец символы
        private bool ContainsSpecialCharacters(string input)
        {
            string specialCharacters = @"!@#$%^&*()_+{}|:""<>?[]\\;',./~`-";

            foreach (char c in input)
            {
                if (specialCharacters.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }

        //Проверяет, является ли строка полностью из букв
        private bool IsNameValid(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsAwardsValid(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c) && !char.IsWhiteSpace(c) && c != '-')
                {
                    return false;
                }
            }

            return true;
        }

        //Проверка на пробел
        private bool ContainsWhiteSpace(string input)
        {
            foreach (char c in input)
            {
                if (char.IsWhiteSpace(c))
                {
                    return true;
                }
            }
            return false;
        }

        private bool Checkers(string input)
        {
            if (!CheckForDigitsAndNumbers(input))
            {

                if (!ContainsSpecialCharacters(input))
                {
                    if (IsNameValid(input))
                    {
                        return true;
                    }
                }


            }



            return false;
        }

        private bool NumberCheckers(string input)
        {
            if (CheckForDigitsAndNumbers(input))
            {

                if (!ContainsSpecialCharacters(input))
                {
                    if (!IsNameValid(input))
                    {
                        return true;
                    }
                }


            }



            return false;
        }


        private void OK_Click(object sender, EventArgs e)
        {
            this.Show();           

            string nameOrgan = NameO.Text;
            string classOrgan = ClassO.Text;
            string speciesOrgan = SpeciesO.Text;
            int countOrgan = Convert.ToInt32(CountO.Text);
            string BehaviourOrgan = BehaviourO.Text;


            //double numberCheck;
            //int numCheck;
            //char s;

            if (Checkers(nameOrgan))
            {

                if (Checkers(classOrgan))
                {

                    if (Checkers(speciesOrgan))
                    {

                        if (NumberCheckers(CountO.Text))
                        {



                    if (classOrgan == "Хищник" || classOrgan == "хищник")
                    {
                        Organism o = new Organism();
                        Predator p = new Predator();
                        o.Name = nameOrgan;
                        o.Class = classOrgan;
                        o.Species = speciesOrgan;
                        o.Quantity = countOrgan;
                        o.Behavior = BehaviourOrgan;

                        p.Name = nameOrgan;
                        p.Class = classOrgan;
                        p.Species = speciesOrgan;
                        p.Quantity = countOrgan;
                        p.Behavior = BehaviourOrgan;

                                bool organismExists = false;
                                for (int i = 0; i < World.Instance.AllOrganisms.Count; i++)
                                {
                                    if (World.Instance.AllOrganisms[i].Name == o.Name)
                                    {
                                        organismExists = true;
                                        break;
                                    }

                                    else if (World.Instance.AllOrganisms[i].Species == o.Species)
                                    {
                                        organismExists = true;
                                        break;

                                    }


                                }

                                if (!organismExists)
                                {
                                    DataBank tempBank = new DataBank("S");
                                    tempBank.GetDataAboutOrganisms(o);
                                    tempBank.GetDataAboutPredator(p);
                                 
                                }

                                else
                                {
                                    MessageBox.Show("Данный вид уже используется в программе");
                                }


                            }

                    else if (classOrgan == "Травоядное" || classOrgan == "травоядное")
                    {



                        Organism o = new Organism();
                        Herbivore h = new Herbivore();
                        o.Name = nameOrgan;
                        o.Class = classOrgan;
                        o.Species = speciesOrgan;
                        o.Quantity = countOrgan;
                        o.Behavior = BehaviourOrgan;

                        h.Name = nameOrgan;
                        h.Class = classOrgan;
                        h.Species = speciesOrgan;
                        h.Quantity = countOrgan;
                        h.Behavior = BehaviourOrgan;

                                bool organismExists2 = false;
                                for (int i = 0; i < World.Instance.AllOrganisms.Count; i++)
                                {
                                    if (World.Instance.AllOrganisms[i].Name == o.Name)
                                    {
                                        organismExists2 = true;
                                        break;
                                    }

                                    else if (World.Instance.AllOrganisms[i].Species == o.Species)
                                    {
                                        organismExists2 = true;
                                        break;

                                    }


                                }

                                if (!organismExists2)
                                {
                                    DataBank tempBank = new DataBank("S");
                                    tempBank.GetDataAboutOrganisms(o);
                                    tempBank.GetDataAboutHerbivore(h);

                                }

                                else
                                {
                                    MessageBox.Show("Данный вид уже используется в программе");
                                }


                            }

                            else if (classOrgan == "Растение" || classOrgan == "растение")
                    {
                        Organism o = new Organism();
                        Plant p = new Plant();
                        o.Name = nameOrgan;
                        o.Class = classOrgan;
                        o.Species = speciesOrgan;
                        o.Quantity = countOrgan;
                        o.Behavior = BehaviourOrgan;

                        p.Name = nameOrgan;
                        p.Class = classOrgan;
                        p.Species = speciesOrgan;
                        p.Quantity = countOrgan;
                        p.Behavior = BehaviourOrgan;

                                bool organismExists3 = false;
                                for (int i = 0; i < World.Instance.AllOrganisms.Count; i++)
                                {
                                    if (World.Instance.AllOrganisms[i].Name == o.Name)
                                    {
                                        organismExists3 = true;
                                        break;
                                    }

                                    else if (World.Instance.AllOrganisms[i].Species == o.Species)
                                    {
                                        organismExists3 = true;
                                        break;

                                    }


                                }


                                if (!organismExists3)
                                {
                                    DataBank tempBank = new DataBank("S");
                                    tempBank.GetDataAboutOrganisms(o);
                                    tempBank.GetDataAboutPlant(p);

                                }

                                else
                                {
                                    MessageBox.Show("Данный вид уже используется в программе");
                                }

                            }

                    else if (classOrgan == "Насекомое" || classOrgan == "насекомое")
                    {
                        Organism o = new Organism();
                        Insect insect = new Insect();
                        o.Name = nameOrgan;
                        o.Class = classOrgan;
                        o.Species = speciesOrgan;
                        o.Quantity = countOrgan;
                        o.Behavior = BehaviourOrgan;

                        insect.Name = nameOrgan;
                        insect.Class = classOrgan;
                        insect.Species = speciesOrgan;
                        insect.Quantity = countOrgan;
                        insect.Behavior = BehaviourOrgan;

                                bool organismExists4 = false;
                                for (int i = 0; i < World.Instance.AllOrganisms.Count; i++)
                                {
                                    if (World.Instance.AllOrganisms[i].Name == o.Name)
                                    {
                                        organismExists4 = true;
                                        break;
                                    }

                                    else if (World.Instance.AllOrganisms[i].Species == o.Species)
                                    {
                                        organismExists4 = true;
                                        break;

                                    }


                                }

                                if (!organismExists4)
                                {
                                    DataBank tempBank = new DataBank("S");
                                    tempBank.GetDataAboutOrganisms(o);
                                    tempBank.GetDataAboutInsect(insect);
                                }

                                else
                                {
                                    MessageBox.Show("Данный вид уже используется в программе");
                                }

                            }

                    else
                    {

                        MessageBox.Show("Класса " + classOrgan + " не существует");
                    }

                        }

                        else
                        {
                            MessageBox.Show("Популяция вида введена неверно");
                        }


                    }

                    else
                    {
                        MessageBox.Show("Поле вида введено неверно");
                    }
                }

                else
                {
                    MessageBox.Show("Поле Класса введено неверно");
                }

            }

            else
            {
                MessageBox.Show("Поле названия введено неверно");
            }

            NameO.Text = null;
            ClassO.Text = null;
            SpeciesO.Text = null;
            CountO.Text = null;
            BehaviourO.Text = null;

            this.Hide();
            


        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
