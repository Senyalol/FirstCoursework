using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;





namespace TheKyrsach
{
    public partial class Form1 : Form
    {
        public Organism Organisms { get; set; }
        public Form1()
        {
            InitializeComponent();
            Organisms = new Organism();
        }

        private bool PredatorOr = false;
        private bool HerbivoreOr = false;
        private bool PlantOr = false;
        private bool InsectOr = false;

        // Глобальные переменные
        public World mir = World.Instance;
        Form2 Forma2 = new Form2();
        Form3 forma3 = new Form3();
        ChooseForm EditForm = new ChooseForm();
        
        // Глобальные переменные



        private string ShowPrompt(string text,string caption) { 
        
            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.Text = caption;


            Label textLabel = new Label()
            {
                Left = 100,
                Top = 10,
                Text = text
            };


            TextBox textBox = new TextBox()
            {
                Left = 50,
                Top = 40,
                Width = 200,
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 100,
                Width = 100,
                Top = 70
            };

            MessageBox.Show("Выбирите один из параметров \n Название \n Класс \n Колличество");
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();

            return textBox.Text;
        }

        private string ShowPrompt1(string text, string caption)
        {

            Form prompt = new Form();
            prompt.Width = 300;
            prompt.Height = 150;
            prompt.Text = caption;


            Label textLabel = new Label()
            {
                Left = 100,
                Top = 10,
                Text = text
            };


            TextBox textBox = new TextBox()
            {
                Left = 50,
                Top = 40,
                Width = 200,
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 100,
                Width = 100,
                Top = 70
            };

            
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.ShowDialog();

            return textBox.Text;
        }

        private string Prompt(string text)
        {

            Form prompt1 = new Form();
            prompt1.Width = 300;
            prompt1.Height = 150;

            Label textLabel1 = new Label()
            {
                Left = 100,
                Top = 10,
                Text = text
            };

            TextBox textBox1 = new TextBox()
            {
                Left = 50,
                Top = 40,
                Width = 200,
            };

            Button confirmation1 = new Button()
            {
                Text = "OK",
                Left = 100,
                Width = 100,
                Top = 70
            };

            confirmation1.Click += (sender, e) => { prompt1.Close(); };
            prompt1.Controls.Add(confirmation1);
            prompt1.Controls.Add(textLabel1);
            prompt1.Controls.Add(textBox1);
            prompt1.ShowDialog();

            return textBox1.Text;

        }


       

     

        public void ShowAllData(Organism o)
        {
            Display.AppendText("===================================================");
            Display.AppendText($"\nНазвание: {o.Name}\n");
            Display.AppendText($"Класс: {o.Class}\n");
            Display.AppendText($"Вид: {o.Species}\n");
            Display.AppendText($"Колличество: {o.Quantity}\n");
            Display.AppendText($"Поведение: {o.Behavior}\n");
            Display.AppendText("===================================================");
        }


        public void ShowAllDataAboutPredator()
        {
            for (int i = 0; i < World.Instance.Predators.Count; i++) {
                Display.AppendText("===================================================");
                Display.AppendText($"\nНазвание: {World.Instance.Predators[i].Name}\n");
                Display.AppendText($"Класс: {World.Instance.Predators[i].Class}\n");
                Display.AppendText($"Вид: {World.Instance.Predators[i].Species}\n");
                Display.AppendText($"Колличество: {World.Instance.Predators[i].Quantity}\n");
                Display.AppendText($"Поведение: {World.Instance.Predators[i].Behavior}\n");
                Display.AppendText("===================================================");
            }
        }

        public void ShowAllDataAboutHerbivore()
        {
            for(int i = 0; i < World.Instance.Herbivores.Count; i++)
            {
                Display.AppendText("===================================================");
                Display.AppendText($"\nНазвание: {World.Instance.Herbivores[i].Name}\n");
                Display.AppendText($"Класс: {World.Instance.Herbivores[i].Class}\n");
                Display.AppendText($"Вид: {World.Instance.Herbivores[i].Species}\n");
                Display.AppendText($"Колличество: {World.Instance.Herbivores[i].Quantity}\n");
                Display.AppendText($"Поведение: {World.Instance.Herbivores[i].Behavior}\n");
                Display.AppendText("===================================================");

            }

        }

        public void ShowAllDataAboutPlant()
        {

            for (int i = 0; i < World.Instance.Plants.Count; i++)
            {
                Display.AppendText("===================================================");
                Display.AppendText($"\nНазвание: {World.Instance.Plants[i].Name}\n");
                Display.AppendText($"Класс: {World.Instance.Plants[i].Class}\n");
                Display.AppendText($"Вид: {World.Instance.Plants[i].Species}\n");
                Display.AppendText($"Колличество: {World.Instance.Plants[i].Quantity}\n");
                Display.AppendText($"Поведение: {World.Instance.Plants[i].Behavior}\n");
                Display.AppendText("===================================================");
            }

        }

        public void ShowAllDataAboutInsect()
        {
            for(int i = 0; i < World.Instance.Insects.Count; i++)
            {
                Display.AppendText("===================================================");
                Display.AppendText($"\nНазвание: {World.Instance.Insects[i].Name}\n");
                Display.AppendText($"Класс: {World.Instance.Insects[i].Class}\n");
                Display.AppendText($"Вид: {World.Instance.Insects[i].Species}\n");
                Display.AppendText($"Колличество: {World.Instance.Insects[i].Quantity}\n");
                Display.AppendText($"Поведение: {World.Instance.Insects[i].Behavior}\n");
                Display.AppendText("===================================================");

            }

        }

        //Кнопка вывода
        private void ShowData_Click(object sender, EventArgs e)
        {
           

            Display.Clear();

          

                foreach (Organism organism in mir.AllOrganisms)
                {
                    
                    ShowAllData(organism);

                }

       

        }
        
        //Кнопка добавления
        private void AddEntity_Click(object sender, EventArgs e)
        {
            Forma2.Show();

            
        }

        //Готово!

        //Кнопка очистки
        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.Display.Clear();
        }

        //Готово


        //Кнопка удаления
        private void DeleteEntity_Click(object sender, EventArgs e)
        {
            string data = "Введите значение";
            string ChooseData = ShowPrompt(data, "Сделайте выбор");
            
            if (ChooseData == "Название")
            {

                string nazvanie = Prompt("Введите название");
                
                for(int i = mir.AllOrganisms.Count - 1; i >= 0; i--)
                {

                    if (mir.AllOrganisms[i].Name == nazvanie)
                    {
                        MessageBox.Show(mir.AllOrganisms[i].Name + " был удален");
                        mir.AllOrganisms.RemoveAt(i);

                        for (int i1 = mir.Predators.Count - 1; i1 >= 0; i1--)
                        {
                            if (mir.Predators[i1].Name == nazvanie)
                            {
                                mir.Predators.RemoveAt(i1);
                            }
                        }

                        for (int i2 = mir.Herbivores.Count - 1; i2 >= 0; i2--)
                        {
                            if (mir.Herbivores[i2].Name == nazvanie)
                            {
                                mir.Herbivores.RemoveAt(i2);
                            }
                        }

                        for (int i3 = mir.Plants.Count - 1; i3 >= 0; i3--)
                        {
                            if (mir.Plants[i3].Name == nazvanie)
                            {
                                mir.Plants.RemoveAt(i3);
                            }
                        }

                        for (int i4 = mir.Insects.Count - 1; i4 >= 0; i4--)
                        {
                            if (mir.Insects[i4].Name == nazvanie)
                            {
                                mir.Insects.RemoveAt(i4);
                            }
                        }
                        
                    }



                }



            }

            else if(ChooseData == "Класс")
            {
                string clas = Prompt("Введите название");

                for (int i = mir.AllOrganisms.Count - 1; i >= 0; i--)
                {

                    if (mir.AllOrganisms[i].Class == clas)
                    {
                        MessageBox.Show(mir.AllOrganisms[i].Name + " был удален");
                        mir.AllOrganisms.RemoveAt(i);

                        for (int i1 = mir.Predators.Count - 1; i1 >= 0; i1--)
                        {
                            if (mir.Predators[i1].Class == clas)
                            {
                                mir.Predators.RemoveAt(i1);
                            }
                        }

                        for (int i2 = mir.Herbivores.Count - 1; i2 >= 0; i2--)
                        {
                            if (mir.Herbivores[i2].Class == clas)
                            {
                                mir.Herbivores.RemoveAt(i2);
                            }
                        }

                        for (int i3 = mir.Plants.Count - 1; i3 >= 0; i3--)
                        {
                            if (mir.Plants[i3].Class == clas)
                            {
                                mir.Plants.RemoveAt(i3);
                            }
                        }

                        for (int i4 = mir.Insects.Count - 1; i4 >= 0; i4--)
                        {
                            if (mir.Insects[i4].Class == clas)
                            {
                                mir.Insects.RemoveAt(i4);
                            }
                        }

                    }



                }


            }

            else if (ChooseData == "Колличество")
            {
                string Cont = Prompt("Введите колличество");
                int n = Convert.ToInt32(Cont);

                for(int i = mir.AllOrganisms.Count - 1; i >= 0; i--)
                {
                    MessageBox.Show(mir.AllOrganisms[i].Name + " был удален");
                    mir.AllOrganisms.RemoveAt(i);

                    for (int i1 = mir.Predators.Count - 1; i1 >= 0; i1--)
                    {
                        if (mir.Predators[i1].Quantity == n)
                        {
                            mir.Predators.RemoveAt(i1);
                        }
                    }

                    for (int i2 = mir.Herbivores.Count - 1; i2 >= 0; i2--)
                    {
                        if (mir.Herbivores[i2].Quantity == n)
                        {
                            mir.Herbivores.RemoveAt(i2);
                        }
                    }

                    for (int i3 = mir.Plants.Count - 1; i3 >= 0; i3--)
                    {
                        if (mir.Plants[i3].Quantity == n)
                        {
                            mir.Plants.RemoveAt(i3);
                        }
                    }

                    for (int i4 = mir.Insects.Count - 1; i4 >= 0; i4--)
                    {
                        if (mir.Insects[i4].Quantity == n)
                        {
                            mir.Insects.RemoveAt(i4);
                        }
                    }

                }

            }


        }

        //Готово 


        //Кнопка "Категории"
        private void FiltrButton_Click(object sender, EventArgs e)
        {
            

            forma3.Show();
         // forma3.Hide();

        }

        //Готово (вроде)



        //Кнопка поиска
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //string SearchValue = ShowPrompt1("Введите info", "Поиск");

            // Display.Clear();

            // for(int i = 0; i < mir.AllOrganisms.Count; i++)
            // {

            //     if(mir.AllOrganisms[i].Name == SearchValue || mir.AllOrganisms[i].Class == SearchValue || mir.AllOrganisms[i].Species == SearchValue)
            //     {
            //         ShowAllData(mir.AllOrganisms[i]);
            //     }


            // }


            // for(int i = 0; i <mir.AllOrganisms.Count; i++)
            // {

            //     if (mir.AllOrganisms[i].Quantity == Convert.ToInt32(SearchValue))
            //     {
            //         ShowAllData(mir.AllOrganisms[i]);
            //     }

            //     else
            //     {
            //         int quantity;
            //         if (int.TryParse(SearchValue, out quantity) && mir.AllOrganisms[i].Quantity == quantity)
            //         {
            //             ShowAllData(mir.AllOrganisms[i]);
            //         }
            //     }



            // }

            string SearchValue = ShowPrompt1("Введите info", "Поиск");

            Display.Clear();

            for (int i = 0; i < mir.AllOrganisms.Count; i++)
            {
                if (mir.AllOrganisms[i].Name == SearchValue || mir.AllOrganisms[i].Class == SearchValue || mir.AllOrganisms[i].Species == SearchValue)
                {
                    ShowAllData(mir.AllOrganisms[i]);
                }
            }

            int quantity;
            if (int.TryParse(SearchValue, out quantity))
            {
                for (int i = 0; i < mir.AllOrganisms.Count; i++)
                {
                    if (mir.AllOrganisms[i].Quantity == quantity)
                    {
                        ShowAllData(mir.AllOrganisms[i]);
                    }
                }
            }


        }

        



        //Кнопка Редактирования
        private void EditButton_Click(object sender, EventArgs e)
        {
            
            string SearchValue = ShowPrompt1("Введите название", "Поиск");

            for (int i = 0; i < mir.AllOrganisms.Count; i++)
            {
                if (mir.AllOrganisms[i].Name == SearchValue)
                {

                    DataBank BT = new DataBank("s");

                    if (mir.AllOrganisms[i].Class == "Хищник" || mir.AllOrganisms[i].Class == "хищник")
                    {
                        PredatorOr = true;
                        HerbivoreOr = false;
                        PlantOr = false;
                        InsectOr = false;

                        EditForm.SetBoolValues(PredatorOr, HerbivoreOr, PlantOr, InsectOr);
                        EditForm.SetIndexValue(i);

                        EditForm.Show();
                    }


                    else if (mir.AllOrganisms[i].Class == "Травоядное" || mir.AllOrganisms[i].Class == "травоядное")
                    {
                        PredatorOr = false;
                        HerbivoreOr = true;
                        PlantOr = false;
                        InsectOr = false;

                        EditForm.SetBoolValues(PredatorOr,HerbivoreOr,PlantOr,InsectOr);
                        EditForm.SetIndexValue(i);


                        EditForm.Show();
                    }

                    else if (mir.AllOrganisms[i].Class == "Растение" || mir.AllOrganisms[i].Class == "растение")
                    {
                        PredatorOr = false;
                        HerbivoreOr = false;
                        PlantOr = true;
                        InsectOr = false;

                        EditForm.SetBoolValues(PredatorOr, HerbivoreOr, PlantOr, InsectOr);
                        EditForm.SetIndexValue(i);


                        EditForm.Show();
                    }

                    else if (mir.AllOrganisms[i].Class == "Насекомое" || mir.AllOrganisms[i].Class == "насекомое")
                    {
                        PredatorOr = false;
                        HerbivoreOr = false;
                        PlantOr = false;
                        InsectOr = true;

                        EditForm.SetBoolValues(PredatorOr, HerbivoreOr, PlantOr, InsectOr);
                        EditForm.SetIndexValue(i);


                        EditForm.Show();
                    }

                }

                



            }
        }
        //Работает 

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Работает

        private void SaveDataButton_Click(object sender, EventArgs e)
        {
            string DataBaseFile = "DataBaseFile.txt";

            using(StreamWriter sw = new StreamWriter(DataBaseFile))
            {
                int Schet = 0;

                for(int i = 0;i < mir.AllOrganisms.Count; i++)
                {

                    sw.WriteLine(Schet);
                    sw.WriteLine(mir.AllOrganisms[i].Name);
                    sw.WriteLine(mir.AllOrganisms[i].Class);
                    sw.WriteLine(mir.AllOrganisms[i].Species);
                    sw.WriteLine(mir.AllOrganisms[i].Quantity);
                    sw.WriteLine(mir.AllOrganisms[i].Behavior);

                    Schet++;
                }


            }


            MessageBox.Show("Данные успешно сохранены");

        }
        //Работает

        //Кнопка для фильтрации видов
        private void Fbutton_Click(object sender, EventArgs e)
        {
            Display.Clear();
            MessageBox.Show("Укажите последовательность");
            string First = Prompt("1");
            string Second = Prompt("2");
            string Third = Prompt("3");
            string Four = Prompt("4");




            //Если первый - Хищник
            if (First == "Хищник" || First == "хищник" || First == "хищники" || First == "Хищники")
            {
                ShowAllDataAboutPredator();

                if (Second == "Травоядное" || Second == "травоядное" || Second == "Травоядные" || Second == "травоядные")
                {
                    ShowAllDataAboutHerbivore();

                    if (Third == "Растения" || Third == "растения" || Third == "Растение" || Third == "растение")
                    {
                        ShowAllDataAboutPlant();

                        if (Four == "Насекомое" || Four == "насекомое" || Four == "Насекомые" || Four == "насекомые")
                        {
                            ShowAllDataAboutInsect();
                        }
                    }

                    else if (Third == "Насекомое" || Third == "насекомое" || Third == "Насекомые" || Third == "насекомые")
                    {
                        ShowAllDataAboutInsect();
                        if (Four == "Растения" || Four == "растения" || Four == "Растение" || Four == "растение")
                        {
                            ShowAllDataAboutPlant();
                        }

                    }

                }

                else if (Second == "Растения" || Second == "растения" || Second == "Растение" || Second == "растение")
                {
                    ShowAllDataAboutPlant();
                    if (Third == "Травоядное" || Third == "травоядное" || Third == "Травоядные" || Third == "травоядные")
                    {
                        ShowAllDataAboutHerbivore();

                        if (Four == "Насекомое" || Four == "насекомое" || Four == "Насекомые" || Four == "насекомые")
                        {
                            ShowAllDataAboutInsect();
                        }

                    }

                    else if (Third == "Насекомое" || Third == "насекомое" || Third == "Насекомые" || Third == "насекомые")
                    {
                        ShowAllDataAboutInsect();
                        if (Four == "Травоядное" || Four == "травоядное" || Four == "Травоядные" || Four == "травоядные")
                        {
                            ShowAllDataAboutHerbivore();
                        }
                    }
                }

                else if (Second == "Насекомое" || Second == "насекомое" || Second == "Насекомые" || Second == "насекомые")
                {
                    ShowAllDataAboutInsect();

                    if (Third == "Растения" || Third == "растения" || Third == "Растение" || Third == "растение")
                    {
                        ShowAllDataAboutPlant();
                        if (Four == "Травоядное" || Four == "травоядное" || Four == "Травоядные" || Four == "травоядные")
                        {
                            ShowAllDataAboutHerbivore();
                        }
                    }

                    else if (Third == "Травоядное" || Third == "травоядное" || Third == "Травоядные" || Third == "травоядные")
                    {
                        ShowAllDataAboutHerbivore();
                        if (Four == "Растения" || Four == "растения" || Four == "Растение" || Four == "растение")
                        {
                            ShowAllDataAboutPlant();
                        }

                    }

                }

            }

            //Если первое - травоядное
            if (First == "Травоядное" || First == "травоядное" || First == "Травоядные" || First == "травоядные")
            {
                ShowAllDataAboutHerbivore();
                if (Second == "Растения" || Second == "растения" || Second == "Растение" || Second == "растение")
                {
                    ShowAllDataAboutPlant();
                    if (Third == "Хищник" || Third == "хищник" || Third == "Хищники" || Third == "хищники")
                    {
                        ShowAllDataAboutPredator();
                        if (Four == "Насекомое" || Four == "насекомое" || Four == "Насекомые" || Four == "насекомые")
                        {
                            ShowAllDataAboutInsect();
                        }
                    }

                    else if (Third == "Насекомое" || Third == "насекомое" || Third == "Насекомые" || Third == "насекомые")
                    {
                        ShowAllDataAboutInsect();
                        if (Four == "Хищник" || Four == "хищник" || Four == "Хищники" || Four == "хищники")
                        {
                            ShowAllDataAboutPredator();
                        }
                    }

                }

                else if (Second == "Насекомое" || Second == "насекомое" || Second == "Насекомые" || Second == "насекомые")
                {
                    ShowAllDataAboutInsect();
                    if (Third == "Хищник" || Third == "хищник" || Third == "Хищники" || Third == "хищники")
                    {
                        ShowAllDataAboutPredator();
                        if (Four == "Растение" || Four == "растение" || Four == "Растения" || Four == "растения")
                        {
                            ShowAllDataAboutPlant();
                        }

                    }

                    else if (Third == "Растение" || Third == "растение" || Third == "Растения" || Third == "растения")
                    {
                        ShowAllDataAboutPlant();
                        if (Four == "Хищник" || Four == "хищник" || Four == "Хищники" || Four == "хищники")
                        {
                            ShowAllDataAboutPredator();
                        }
                    }

                }


                else if (Second == "Хищник" || Second == "хищник" || Second == "Хищники" || Second == "хищники")
                {
                    ShowAllDataAboutPredator();
                    if (Third == "Растения" || Third == "растения" || Third == "Растение" || Third == "растение")
                    {
                        ShowAllDataAboutPlant();
                        if (Four == "Насекомое" || Four == "насекомое" || Four == "Насекомые" || Four == "насекомые")
                        {
                            ShowAllDataAboutInsect();
                        }
                    }

                    else if (Third == "Насекомое" || Third == "насекомое" || Third == "Насекомые" || Third == "насекомые")
                    {
                        ShowAllDataAboutInsect();
                        if (Four == "Растения" || Four == "растения" || Four == "Растение" || Four == "растение")
                        {
                            ShowAllDataAboutPlant();
                        }
                    }


                }

            }

            //Если первое - растение
            if (First == "Растение" || First == "растение" || First == "Растения" || First == "растения")
            {
                ShowAllDataAboutPlant();
                if (Second == "Хищник" || Second == "хищник" || Second == "Хищники" || Second == "хищники")
                {
                    ShowAllDataAboutPredator();
                    if(Third == "Травоядное" || Third == "травоядное" || Third == "Травоядные" || Third == "травоядные")
                    {
                        ShowAllDataAboutHerbivore();
                        if(Four == "Насекомое" || Four == "насекомое" || Four == "Насекомые" || Four == "насекомые")
                        {
                            ShowAllDataAboutInsect();
                        }
                    }

                    else if(Third == "Насекомое" || Third == "насекомое" || Third == "Насекомые" || Third == "насекомые")
                    {
                        ShowAllDataAboutInsect();
                        if(Four == "Травоядное" || Four == "травоядное" || Four == "Травоядные" || Four == "травоядные")
                        {
                            ShowAllDataAboutHerbivore();
                        }
                    }

                }

                else if (Second == "Травоядное" || Second == "травоядное" || Second == "Травоядные" || Second == "травоядные")
                {
                    ShowAllDataAboutHerbivore();
                    if(Third == "Хищник" || Third == "хищник" || Third == "Хищники" || Third == "хищники")
                    {
                        ShowAllDataAboutPredator();
                        if(Four == "Насекомое" || Four == "насекомое" || Four == "Насекомые" || Four == "насекомые")
                        {
                            ShowAllDataAboutInsect();
                        }

                    }

                    else if(Third == "Насекомое")
                    {
                        ShowAllDataAboutInsect();
                        if(Four == "Хищник" || Four == "хищник" || Four == "Хищники" || Four == "хищники")
                        {
                            ShowAllDataAboutPredator();
                        }

                    }

                }

                else if(Second == "Насекомое" || Second == "насекомое" || Second == "Насекомые" || Second == "насекомые")
                {
                    ShowAllDataAboutInsect();
                    if(Third == "Хищник" || Third == "хищник" || Third == "Хищники" || Third == "хищники")
                    {
                        ShowAllDataAboutPredator() ;
                        if(Four == "Травоядное" || Four == "травоядное" || Four == "Травоядные" || Four == "травоядные")
                        {
                            ShowAllDataAboutHerbivore() ;
                        }
                    }

                    else if(Third == "Травоядное" || Third == "травоядное" || Third == "Травоядные" || Third == "травоядные")
                    {
                        ShowAllDataAboutHerbivore();
                        if(Four == "Хищник" || Four == "хищник" || Four == "Хищники" || Four == "хищники")
                        {
                            ShowAllDataAboutPredator();
                        }

                    }
                }

            }

            //Если первое - насекомое
            if(First == "Насекомое" || First == "насекомое" || First == "Насекомые" || First == "насекомые")
            {
                ShowAllDataAboutInsect();
                if(Second == "Растение" || Second == "растение" || Second == "Растения" || Second == "растения")
                {
                    ShowAllDataAboutPlant();
                    if(Third == "Травоядное" || Third == "травоядное" || Third == "Травоядные" || Third == "травоядные")
                    {
                        ShowAllDataAboutHerbivore();
                        if(Four == "Хищник" || Four == "хищник" || Four == "Хищники" || Four == "хищники")
                        {
                            ShowAllDataAboutPredator();
                        }
                    }

                    else if(Third == "Хищник" || Third == "хищник" || Third == "Хищники" || Third == "хищники")
                    {
                        ShowAllDataAboutPredator();
                        if(Four == "Травоядное" || Four == "травоядное" || Four == "Травоядные" || Four == "травоядные")
                        {
                            ShowAllDataAboutHerbivore();
                        }
                    }


                }

                else if(Second == "Травоядное" || Second == "травоядное" || Second == "Травоядные" || Second == "травоядные")
                {
                    ShowAllDataAboutHerbivore();
                    if(Third == "Хищники")
                    {
                        ShowAllDataAboutPredator();
                        if(Four == "Растение" || Four == "растение" || Four == "Растения" || Four == "растения")
                        {
                            ShowAllDataAboutPlant();
                        }
                    }

                    else if(Third == "Растение")
                    {
                        ShowAllDataAboutPlant();
                        if(Four == "Хищники" || Four == "хищники" || Four == "Хищник" || Four == "хищник")
                        {
                            ShowAllDataAboutPredator();
                        }
                    }

                }

                else if(Second == "Хищники" || Second == "хищники" || Second == "Хищник" || Second == "хищник")
                {
                    if(Third == "Растения" || Third == "растения" || Third == "Растение" || Third == "растение")
                    {
                        ShowAllDataAboutPlant();
                        if(Four == "Травоядные" || Four == "травоядные" || Four == "Травоядное" || Four == "травоядное")
                        {
                            ShowAllDataAboutHerbivore();
                        }
                    }

                    else if(Third == "Травоядные" || Third == "травоядные" || Third == "Травоядное" || Third == "травоядное")
                    {
                        ShowAllDataAboutHerbivore();
                        if(Four == "Растения" || Four == "растения" || Four == "Растение" || Four == "растение")
                        {
                            ShowAllDataAboutPlant();
                        }
                    }

                }

            }

        }


        //Готово!   


        //Добавить сущность


    }
}
