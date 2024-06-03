using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TheKyrsach
{
    public partial class PlantForm : Form
    {
        public PlantForm()
        {
            InitializeComponent();
        }

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

        //Кнопка для отмены
        private void CanselButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Кнопка для добавления
        private void AddPlantButton_Click(object sender, EventArgs e)
        {
            DataBank SomeDataAboutPredator = new DataBank("3");

            Plant pvz = new Plant();
            Organism o = new Organism();
            string nameOrgan = NameI.Text;
            string classOrgan = ClassI.Text;
            string speciesOrgan = SepciesI.Text;
            int Count = Convert.ToInt32(CountI.Text);

            

            if (Checkers(nameOrgan))
            {


                if (Checkers(classOrgan))
                {

                    if (Checkers(speciesOrgan))
                    {

                        if (NumberCheckers(CountI.Text))
                        {
                            if (classOrgan == "Растение" || classOrgan == "растение")
                            {
                                pvz.Name = NameI.Text;
                                pvz.Class = ClassI.Text;
                                pvz.Species = SepciesI.Text;
                                pvz.Quantity = Convert.ToInt32(CountI.Text);
                                pvz.Behavior = BehavourI.Text;

                                o.Name = NameI.Text;
                                o.Class = ClassI.Text;
                                o.Species = SepciesI.Text;
                                o.Quantity = Convert.ToInt32(CountI.Text);
                                o.Behavior = BehavourI.Text;

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
                                    SomeDataAboutPredator.GetDataAboutOrganisms(o);
                                    SomeDataAboutPredator.AddPlant(pvz);

                                    MessageBox.Show("Растение " + pvz.Name + " было добавлено");

                                }

                                else
                                {
                                    MessageBox.Show("Данный вид уже используется в программе");
                                }

                            }

                            else
                            {
                                MessageBox.Show("Вы не можете изменить класс вида Растение на " + classOrgan);
                            }

                        }

                        else
                        {
                            MessageBox.Show("Поле популяции введено неверно");
                        }

                    }

                    else
                    {
                        MessageBox.Show("Поле вида введено неверно");
                    }

                }

                else
                {
                    MessageBox.Show("Поле класса введено неверно");
                }

            }


            else
            {

                MessageBox.Show("Поле названия введено неверно");

            }

           

            

          






            NameI.Text = null;
            ClassI.Text = null;
            SepciesI.Text = null;
            CountI.Text = null;
            BehavourI.Text = null;

            this.Hide();
        }
    }
}
