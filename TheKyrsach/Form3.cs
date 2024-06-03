using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheKyrsach.Form1;
//using static TheKyrsach.DataBankClas;



namespace TheKyrsach
{
    public partial class Form3 : Form
    {
        static private Form1 DataGet;


        DisplayText DText = new DisplayText();
        PredatorForm PForm = new PredatorForm();
        HerbivoreForm HForm = new HerbivoreForm();
        PlantForm PFo = new PlantForm();
        InscectFormcs InForm = new InscectFormcs();
        ChooseForm ChForm = new ChooseForm();

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(ChooseForm cf)
        {
            InitializeComponent();
            ChForm = cf;

        }

        public Form3(Form1 f)
        {
            InitializeComponent();
            DataGet = f;

        }

        //Конструктор для формы просмотра информации 
        public Form3(DisplayText d)
        {
            InitializeComponent();
            DText = d;
        }

        //Конструктор для открытия формы добавления информации о хищнике
        public Form3(PredatorForm PF)
        {
            InitializeComponent();
            PForm = PF;
        }

        //Конструктор для открытия формы добавления информации о травоядном
        public Form3(HerbivoreForm HF)
        {
            InitializeComponent();
            HForm = HF;
        }

        //Конструктор для открытия формы добавления информации о растении
        public Form3(PlantForm PF)
        {
            InitializeComponent();
            PFo = PF;
        }

        //Конструктор для открытия формы добавления информации о насекомом
        public Form3(InscectFormcs IForm)
        {
            InitializeComponent();
            InForm = IForm;
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




        bool PredatorTF = false;
        bool HerbivoresTF = false;
        bool PlantsTF = false;
        bool InsectsTF = false;


        //Хищники
        private void PredatorButton_Click(object sender, EventArgs e)
        {
            PredatorTF = true;
            HerbivoresTF = false;
            PlantsTF = false;
            InsectsTF = false;
        }

        //Травоядные
        private void HerbivoresButton_Click(object sender, EventArgs e)
        {
            PredatorTF = false;
            HerbivoresTF = true;
            PlantsTF = false;
            InsectsTF = false;


        }

        //Растения
        private void PlantButton_Click(object sender, EventArgs e)
        {
            PredatorTF = false;
            HerbivoresTF = false;
            PlantsTF = true;
            InsectsTF = false;
        }

        //Насекомые
        private void InsectButton_Click(object sender, EventArgs e)
        {
            PredatorTF = false;
            HerbivoresTF = false;
            PlantsTF = false;
            InsectsTF = true;
        }

        //Панель элементов "Добавить" (в разработке)
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (PredatorTF)
            {
                PForm.Show();
            }

            else if (HerbivoresTF)
            {
                HForm.Show();
            }

            else if (PlantsTF)
            {
                PFo.Show();
            }

            else if (InsectsTF)
            {
                InForm.Show();
            }

        }

        //Панель элементов "Просмотр"  (вроде готов)
        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //List<Organism> SomeList = new List<Organism>(DataGet.mir.AllOrganisms);

            DataBank Check = new DataBank("fnaf");


            //Если выбрали хищника
            if (PredatorTF)
            {
                PredatorTF = true;
                HerbivoresTF = false;
                PlantsTF = false;
                InsectsTF = false;

                DText.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);

                DText.Show();

            }

            //Если выбрали травоядное
            else if (HerbivoresTF)
            {
                PredatorTF = false;
                HerbivoresTF = true;
                PlantsTF = false;
                InsectsTF = false;

                DText.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);

                DText.Show();

            }

            //Если выбрали растения
            else if (PlantsTF)
            {
                PredatorTF = false;
                HerbivoresTF = false;
                PlantsTF = true;
                InsectsTF = false;

                DText.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);

                DText.Show();


            }

            //Если выбрали насекомых
            else if (InsectsTF)
            {
                PredatorTF = false;
                HerbivoresTF = false;
                PlantsTF = false;
                InsectsTF = true;

                DText.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);

                DText.Show();

            }

        }

        //Удалить
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ChooseFindOrganism = Prompt("Введите инфо");


            if (PredatorTF)
            {

                for (int i = 0; i < World.Instance.Predators.Count; i++)
                {

                    
                        if (World.Instance.Predators[i].Name == ChooseFindOrganism)
                        {
                            DataBank Pbank = new DataBank("s");
                        int numind = Pbank.SaveDataAboutIndex(i);
                        Pbank.RemovePredator(numind);
                            
                            MessageBox.Show("Хищник " + World.Instance.Predators[i].Name + " был удален");
                        }
                    



                }

                //for (int i = 0; i < World.Instance.Predators.Count; i++)
                //{

                //    if (World.Instance.Predators[i].Class == ChooseFindOrganism)
                //    {
                //        World.Instance.Predators.RemoveAt(i);
                //        MessageBox.Show("Хищник " + World.Instance.Predators[i].Name + " был удален");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Predators.Count; i++)
                //{

                //    if (World.Instance.Predators[i].Species == ChooseFindOrganism)
                //    {
                //        World.Instance.Predators.RemoveAt(i);
                //        MessageBox.Show("Хищник " + World.Instance.Predators[i].Name + " был удален");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Predators.Count; i++)
                //{
                //    int number = Convert.ToInt32(ChooseFindOrganism);

                //    if (World.Instance.Predators[i].Quantity == number)
                //    {
                //        World.Instance.Predators.RemoveAt(i);
                //        MessageBox.Show("Хищник " + World.Instance.Predators[i].Name + " был удален");
                //    }

                //}



            }

            else if (HerbivoresTF)
            {

                for (int i = 0; i < World.Instance.Herbivores.Count; i++)
                {

                   
                        if (World.Instance.Herbivores[i].Name == ChooseFindOrganism)
                        {
                        DataBank Hbank = new DataBank("g");
                        int numind = Hbank.SaveDataAboutIndex(i);
                        Hbank.RemoveHerbivore(numind);
                            MessageBox.Show("Травоядное " + World.Instance.Herbivores[i].Name + " было удалено");
                        }
                    

                    

                }

                //for (int i = 0; i < World.Instance.Herbivores.Count; i++)
                //{

                //    if (World.Instance.Herbivores[i].Class == ChooseFindOrganism)
                //    {
                //        World.Instance.Herbivores.RemoveAt(i);
                //        MessageBox.Show("Травоядное " + World.Instance.Herbivores[i].Name + " было удалено");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Herbivores.Count; i++)
                //{

                //    if (World.Instance.Herbivores[i].Species == ChooseFindOrganism)
                //    {
                //        World.Instance.Herbivores.RemoveAt(i);
                //        MessageBox.Show("Травоядное " + World.Instance.Herbivores[i].Name + " было удалено");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Herbivores.Count; i++)
                //{
                //    int number = Convert.ToInt32(ChooseFindOrganism);

                //    if (World.Instance.Herbivores[i].Quantity == number)
                //    {
                //        World.Instance.Herbivores.RemoveAt(i);
                //        MessageBox.Show("Травоядное " + World.Instance.Herbivores[i].Name + " было удалено");
                //    }

                //}


            }

            else if (PlantsTF)
            {
                for (int i = 0; i < World.Instance.Plants.Count; i++)
                {

                   
                        if (World.Instance.Plants[i].Name == ChooseFindOrganism)
                        {
                            DataBank Pbank = new DataBank("sa");
                            int numind = Pbank.SaveDataAboutIndex(i);
                            Pbank.RemovePlant(numind);
                            
                            MessageBox.Show("Растение " + World.Instance.Plants[i].Name + " было удалено");
                        }
                    


                }

                //for (int i = 0; i < World.Instance.Plants.Count; i++)
                //{

                //    if (World.Instance.Plants[i].Class == ChooseFindOrganism)
                //    {
                //        World.Instance.Plants.RemoveAt(i);
                //        MessageBox.Show("Растение " + World.Instance.Plants[i].Name + " было удалено");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Plants.Count; i++)
                //{

                //    if (World.Instance.Plants[i].Species == ChooseFindOrganism)
                //    {
                //        World.Instance.Plants.RemoveAt(i);
                //        MessageBox.Show("Растение " + World.Instance.Plants[i].Name + " было удалено");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Plants.Count; i++)
                //{
                //    int number = Convert.ToInt32(ChooseFindOrganism);

                //    if (World.Instance.Plants[i].Quantity == number)
                //    {
                //        World.Instance.Plants.RemoveAt(i);
                //        MessageBox.Show("Растение " + World.Instance.Plants[i].Name + " было удалено");
                //    }

                //}

            }

            else if (InsectsTF)
            {
                for (int i = 0; i < World.Instance.Insects.Count; i++)
                {

                  
                        if (World.Instance.Insects[i].Name == ChooseFindOrganism)
                        {
                            DataBank Ibank = new DataBank("gha");
                            int numind = Ibank.SaveDataAboutIndex(i);    
                            Ibank.RemoveInsect(numind);
                            MessageBox.Show("Насекомое " + World.Instance.Insects[i].Name + " было удалено");
                        }
                    

                    

                }

                //for (int i = 0; i < World.Instance.Insects.Count; i++)
                //{

                //    if (World.Instance.Insects[i].Class == ChooseFindOrganism)
                //    {
                //        World.Instance.Insects.RemoveAt(i);
                //        MessageBox.Show("Насекомое " + World.Instance.Insects[i].Name + " было удалено");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Insects.Count; i++)
                //{

                //    if (World.Instance.Insects[i].Species == ChooseFindOrganism)
                //    {
                //        World.Instance.Insects.RemoveAt(i);
                //        MessageBox.Show("Насекомое " + World.Instance.Insects[i].Name + " было удалено");
                //    }

                //}

                //for (int i = 0; i < World.Instance.Insects.Count; i++)
                //{
                //    int number = Convert.ToInt32(ChooseFindOrganism);

                //    if (World.Instance.Insects[i].Quantity == number)
                //    {
                //        World.Instance.Insects.RemoveAt(i);
                //        MessageBox.Show("Насекомое " + World.Instance.Insects[i].Name + " было удалено");
                //    }

                //}

            }

        }

        //Редактировать

        //Editor
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBank Check = new DataBank("fnaf");

            if (PredatorTF)
            {

                string FindIndex = Prompt("Введите info");

                for (int i = 0; i < World.Instance.Predators.Count; i++)
                {

                    if (World.Instance.Predators[i].Name == FindIndex)
                    {

                        PredatorTF = true;
                        HerbivoresTF = false;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Predators.Count; i++)
                {

                    if (World.Instance.Predators[i].Class == FindIndex)
                    {

                        PredatorTF = true;
                        HerbivoresTF = false;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Predators.Count; i++)
                {

                    if (World.Instance.Predators[i].Species == FindIndex)
                    {

                        PredatorTF = true;
                        HerbivoresTF = false;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

            }

            else if (HerbivoresTF)
            {
                string FindIndex = Prompt("Введите info");

                for (int i = 0; i < World.Instance.Herbivores.Count; i++)
                {

                    if (World.Instance.Herbivores[i].Name == FindIndex)
                    {

                        PredatorTF = false;
                        HerbivoresTF = true;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Herbivores.Count; i++)
                {

                    if (World.Instance.Herbivores[i].Class == FindIndex)
                    {

                        PredatorTF = false;
                        HerbivoresTF = true;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Herbivores.Count; i++)
                {

                    if (World.Instance.Herbivores[i].Species == FindIndex)
                    {

                        PredatorTF = false;
                        HerbivoresTF = true;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }
            }

            else if (PlantsTF)
            {
                string FindIndex = Prompt("Введите info");

                for (int i = 0; i < World.Instance.Plants.Count; i++)
                {

                    if (World.Instance.Plants[i].Name == FindIndex)
                    {

                        PredatorTF = false;
                        HerbivoresTF = false;
                        PlantsTF = true;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Plants.Count; i++)
                {

                    if (World.Instance.Plants[i].Class == FindIndex)
                    {

                        PredatorTF = false;
                        HerbivoresTF = false;
                        PlantsTF = true;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Plants.Count; i++)
                {

                    if (World.Instance.Plants[i].Species == FindIndex)
                    {

                        PredatorTF = false;
                        HerbivoresTF = false;
                        PlantsTF = true;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }
            }

            else if (InsectsTF)
            {
                string FindIndex = Prompt("Введите info");

                for (int i = 0; i < World.Instance.Insects.Count; i++)
                {

                    if (World.Instance.Insects[i].Name == FindIndex)
                    {

                        PredatorTF = true;
                        HerbivoresTF = false;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Insects.Count; i++)
                {

                    if (World.Instance.Insects[i].Class == FindIndex)
                    {

                        PredatorTF = true;
                        HerbivoresTF = false;
                        PlantsTF = false;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

                for (int i = 0; i < World.Instance.Plants.Count; i++)
                {

                    if (World.Instance.Plants[i].Species == FindIndex)
                    {

                        PredatorTF = false;
                        HerbivoresTF = false;
                        PlantsTF = true;
                        InsectsTF = false;

                        ChForm.SetBoolValues(PredatorTF, HerbivoresTF, PlantsTF, InsectsTF);
                        ChForm.SetIndexValue(i);

                        ChForm.Show();
                    }

                }

            }


        }

        //Exit
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}