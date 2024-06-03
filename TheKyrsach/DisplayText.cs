using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheKyrsach
{
    public partial class DisplayText : Form
    {
        public DisplayText()
        {
            InitializeComponent();
        }


        //Вывести информацию о хищнике
        public void ShowAllDataAboutPredator()
        {
            for (int i = 0; i < World.Instance.Predators.Count; i++)
            {

                DData.AppendText("===================================================");
                DData.AppendText($"\r\nНазвание: {World.Instance.Predators[i].Name}\r\n");
                DData.AppendText($"Класс: {World.Instance.Predators[i].Class}\r\n");
                DData.AppendText($"Вид: {World.Instance.Predators[i].Species}\r\n");
                DData.AppendText($"Колличество: {World.Instance.Predators[i].Quantity}\r\n");
                DData.AppendText($"Поведение: {World.Instance.Predators[i].Behavior}\r\n");
                DData.AppendText("===================================================");

            }
        }

        //Вывести информацию о травоядном
        public void ShowAllDataAboutHerbivore()
        {
            for (int i = 0; i < World.Instance.Herbivores.Count; i++)
            {
                DData.AppendText("===================================================");
                DData.AppendText($"\r\nНазвание: {World.Instance.Herbivores[i].Name}\r\n");
                DData.AppendText($"Класс: {World.Instance.Herbivores[i].Class}\r\n");
                DData.AppendText($"Вид: {World.Instance.Herbivores[i].Species}\r\n");
                DData.AppendText($"Колличество: {World.Instance.Herbivores[i].Quantity}\r\n");
                DData.AppendText($"Поведение: {World.Instance.Herbivores[i].Behavior}\r\n");
                DData.AppendText("===================================================");
            }
        }

        //Вывести информацию о растении
        public void ShowAllDataAboutPlant()
        {
            for (int i = 0; i < World.Instance.Plants.Count; i++) { 
                DData.AppendText("===================================================");
            DData.AppendText($"\r\nНазвание: {World.Instance.Plants[i].Name}\r\n");
            DData.AppendText($"Класс: {World.Instance.Plants[i].Class}\r\n");
            DData.AppendText($"Вид: {World.Instance.Plants[i].Species}\r\n");
            DData.AppendText($"Колличество: {World.Instance.Plants[i].Quantity}\r\n");
            DData.AppendText($"Поведение: {World.Instance.Plants[i].Behavior}\r\n");
            DData.AppendText("===================================================");
        }
    }
        //Вывести информацию о насекомом
        public void ShowAllDataAboutInscet()
        {
            for (int i = 0; i < World.Instance.Insects.Count; i++)
            {

                DData.AppendText("===================================================");
                DData.AppendText($"\r\nНазвание: {World.Instance.Insects[i].Name}\r\n");
                DData.AppendText($"Класс: {World.Instance.Insects[i].Class}\r\n");
                DData.AppendText($"Вид: {World.Instance.Insects[i].Species}\r\n");
                DData.AppendText($"Колличество: {World.Instance.Insects[i].Quantity}\r\n");
                DData.AppendText($"Поведение: {World.Instance.Insects[i].Behavior}\r\n");
                DData.AppendText("===================================================");

            }
        }


        //Глобальные переменные и обьекты классов
        DataBank check;
      
        public bool T1 { get; set; }
        public bool T2 { get; set; }
        public bool T3 { get; set; }
        public bool T4 { get; set; }

        // Метод для установки значений переменных
        public void SetBoolValues(bool t1, bool t2, bool t3, bool t4)
        {
            T1 = t1;
            T2 = t2;
            T3 = t3;
            T4 = t4;
        }


        //Обработчики событий


        //Кнопка для отображения информации
        private void ShowAllDataButton_Click(object sender, EventArgs e)
        {

            DData.Clear();

            if ( T1 )
            {
                ShowAllDataAboutPredator();

            }


            else if ( T2 )
            {
                ShowAllDataAboutHerbivore();
            }


            else if (T3)
            {
                ShowAllDataAboutPlant();
            }


            else if (T4)
            {
                ShowAllDataAboutInscet();
            }


        }

        //Кнопка для очистки дисплея (Работает)
        private void ClearButton_Click(object sender, EventArgs e)
        {
            DData.Clear();
        }

        //Кнопка для закрытия формы
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



    }
}
