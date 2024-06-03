using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheKyrsach.Form1;

namespace TheKyrsach
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        //public void ChangeFiltr()
        //{



        //}
        public bool T1 { get; set; }
        public bool T2 { get; set; }
        public bool T3 { get; set; }
        public bool T4 { get; set; }

        public bool PredatorBool = false; //{ get; set; }

        public bool HerbivoreBool = false; //{ get; set; }

        public bool PlantBool = false; //{ get; set; }

        public bool InsectBool = false;//{ get; set; }

        public int index { get; set; }

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


        // Метод для установки значений переменных
        public void SetBoolValues(bool t1, bool t2, bool t3, bool t4)
        {
            T1 = t1;
            T2 = t2;
            T3 = t3;
            T4 = t4;
        }
        public bool ISOrganisPredator(bool some)
        {
            some = true;
            PredatorBool = some;
            return true;
        }

        public bool ISOrganisHerbivore(bool some)
        {
            some = true;
            HerbivoreBool = some;
            return true;
        }

        public bool ISOrganisPlant(bool some)
        {
            some = true;
            PlantBool = some;
            return true;
        }

        public bool ISOrganisInsect(bool some)
        {
            some = true;
            this.InsectBool = some;
            return true;
        }
        public int SetIndexValue(int ind)
        {
            index = ind;
            return index;
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

        //Кнопка редактирования
        private void AcceptButton_Click(object sender, EventArgs e)
        {

            if (T1)
            {
                DataBank BankTemp = new DataBank("g");
                string n = NameText.Text;
                string c = ClassText.Text;
                string s = SpeciesText.Text;
                int cs = Convert.ToInt32(CountText.Text);
                string b = BehaviourText.Text;

                Organism o = new Organism();
                o.Name = n;
                o.Class = c;
                o.Species = s;
                o.Quantity = cs;
                o.Behavior = b;

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


                if (Checkers(n))
                {


                    if (Checkers(c))
                    {

                        if (Checkers(s))
                        {

                            if (NumberCheckers(CountText.Text))
                            {
                                if(c == "Хищник" || c == "хищник")
                                {

                                    if (!organismExists2)
                                    {
                                         BankTemp.SetDataAboutOrganism(n, c, s, cs, b, index);
                                         BankTemp.SetDataAboutPredator(n, c, s, cs, b, index);
                                    }

                                    else
                                    {
                                        MessageBox.Show("Данный вид уже используется в программе");
                                    }


                                }

                                else
                                {
                                    MessageBox.Show("Вы не можете изменить класс вида Хищник на " + c);
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












                this.NameText.Text = null;
                this.ClassText.Text = null;
                this.SpeciesText.Text = null;
                this.CountText.Text = null;
                this.BehaviourText.Text = null;
                this.Hide();

            }

            else if (T2)
            {
                DataBank BankTempH = new DataBank("g");
                string n = NameText.Text;
                string c = ClassText.Text;
                string s = SpeciesText.Text;
                int cs = Convert.ToInt32(CountText.Text);
                string b = BehaviourText.Text;

                Organism o = new Organism();
                o.Name = n;
                o.Class = c;
                o.Species = s;
                o.Quantity = cs;
                o.Behavior = b;

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

                if (Checkers(n))
                {


                    if (Checkers(c))
                    {

                        if (Checkers(s))
                        {

                            if (NumberCheckers(CountText.Text))
                            {
                                if (c == "Травоядное" || c == "травоядное")
                                {
                                    if (!organismExists2)
                                    {
                                      BankTempH.SetDataAboutOrganism(n, c, s, cs, b, index);
                                      BankTempH.SetDataAboutHerbivore(n, c, s, cs, b, index);

                                    }

                                    else
                                    {
                                        MessageBox.Show("Данный вид уже используется в программе");
                                    }

                                }

                                else
                                {
                                    MessageBox.Show("Вы не можете изменить класс вида Травоядное на " + c);
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

                


                






                this.NameText.Text = null;
                this.ClassText.Text = null;
                this.SpeciesText.Text = null;
                this.CountText.Text = null;
                this.BehaviourText.Text = null;
                this.Hide();

            }

            else if (T3)
            {
                DataBank BankTempP = new DataBank("g");
                string n = NameText.Text;
                string c = ClassText.Text;
                string s = SpeciesText.Text;
                int cs = Convert.ToInt32(CountText.Text);
                string b = BehaviourText.Text;

                Organism o = new Organism();
                o.Name = n;
                o.Class = c;
                o.Species = s;
                o.Quantity = cs;
                o.Behavior = b;

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

                if (Checkers(n))
                {


                    if (Checkers(c))
                    {

                        if (Checkers(s))
                        {

                            if (NumberCheckers(CountText.Text))
                            {
                                if (c == "Растение" || c == "растение")
                                {
                                    if (!organismExists2)
                                    {
                                        BankTempP.SetDataAboutOrganism(n, c, s, cs, b, index);
                                        BankTempP.SetDataAboutPlant(n, c, s, cs, b, index);

                                    }

                                    else
                                    {
                                        MessageBox.Show("Данный вид уже используется в программе");
                                    }


                                }

                                else
                                {
                                    MessageBox.Show("Вы не можете изменить класс вида растение на " + c);
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

                



               





                this.NameText.Text = null;
                this.ClassText.Text = null;
                this.SpeciesText.Text = null;
                this.CountText.Text = null;
                this.BehaviourText.Text = null;
                this.Hide();
            }

            else  if (T4)
            {
                DataBank BankTempI = new DataBank("g");
                string n = NameText.Text;
                string c = ClassText.Text;
                string s = SpeciesText.Text;
                int cs = Convert.ToInt32(CountText.Text);
                string b = BehaviourText.Text;

                Organism o = new Organism();
                o.Name = n;
                o.Class = c;
                o.Species = s;
                o.Quantity = cs;
                o.Behavior = b;

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

                if (Checkers(n))
                {


                    if (Checkers(c))
                    {

                        if (Checkers(s))
                        {

                            if (NumberCheckers(CountText.Text))
                            {
                                if (c == "Насекомое" || c == "насекомое")
                                {
                                    if (!organismExists2)
                                    {
                                        BankTempI.SetDataAboutOrganism(n, c, s, cs, b, index);
                                        BankTempI.SetDataAboutInscet(n, c, s, cs, b, index);
                                    }

                                    else
                                    {
                                        MessageBox.Show("Данный вид уже используется в программе");
                                    }

                                }

                                else
                                {
                                    MessageBox.Show("Вы не можете изменить класс вида насекомое на " + c);
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
                


               





                this.NameText.Text = null;
                this.ClassText.Text = null;
                this.SpeciesText.Text = null;
                this.CountText.Text = null;
                this.BehaviourText.Text = null;
                this.Hide();
            }

//            else
//            {
//                DataBank BankTemp1 = new DataBank("g");
//                bool PredatorB = BankTemp1.P;
//                bool HerbivoreB = BankTemp1.H;
//                bool PlantB = BankTemp1.Plants;
//                bool InsectB = BankTemp1.I;
//                // int number = BankTemp1.i;


//                string n = NameText.Text;
//                string c = ClassText.Text;
//                string s = SpeciesText.Text;
//                int cs = Convert.ToInt32(CountText.Text);
//                string b = BehaviourText.Text;
//                //Global

//                if (Checkers(n))
//                {


//                    if (Checkers(c))
//                    {

//                        if (Checkers(s))
//                        {

//                            if (NumberCheckers(CountText.Text))
//                            {


//                                if (PredatorBool == true)
//                                {
//                                    BankTemp1.SetDataAboutOrganism(n, c, s, cs, b, index);
//                                    BankTemp1.SetDataAboutPredator(n, c, s, cs, b, index);
//                                }

//                                else if (HerbivoreBool)
//                                {
//                                    BankTemp1.SetDataAboutOrganism(n, c, s, cs, b, index);
//                                    BankTemp1.SetDataAboutHerbivore(n, c, s, cs, b, index);
//                                }

//                                else if (PlantBool)
//                                {
//                                    BankTemp1.SetDataAboutOrganism(n, c, s, cs, b, index);
//                                    BankTemp1.SetDataAboutPlant(n, c, s, cs, b, index);
//                                }

//                                else if (InsectBool)
//                                {
//                                    BankTemp1.SetDataAboutOrganism(n, c, s, cs, b, index);
//                                    BankTemp1.SetDataAboutInscet(n, c, s, cs, b, index);
//                                }

//                                else
//                                {
//                                    MessageBox.Show("Фатальный баг");
//                                }

//                            }

//                            else
//            {
//                MessageBox.Show("Поле популяции введено неверно");
//            }

//        }

//                        else
//                        {
//                            MessageBox.Show("Поле вида введено неверно");
//                        }

//}

//                    else
//{
//    MessageBox.Show("Поле класса введено неверно");
//}

//                }


//                else
//{

//    MessageBox.Show("Поле названия введено неверно");

//}







////Global
//                this.NameText.Text = null;
//                this.ClassText.Text = null;
//                this.SpeciesText.Text = null;
//                this.CountText.Text = null;
//                this.BehaviourText.Text = null;
//                this.Hide();
//            }




        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
