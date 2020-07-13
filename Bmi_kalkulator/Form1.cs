using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bmi_kalkulator
{
    public partial class Form1 : Form
    {
        public class Kalkulator
        {
            public double Dodawanie(double num1, double num2)
            {
                return num1 + num2;
            }
            public double Odejmowanie(double num1, double num2)
            {
                return num1 - num2;
            }
        }

            public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bmi2DataSet.Tabela' table. You can move, or remove it, as needed.
            this.tabelaTableAdapter.Fill(this.bmi2DataSet.Tabela);
            // TODO: This line of code loads data into the 'bmiDataSet1.wiek' table. You can move, or remove it, as needed.
            this.wiekTableAdapter.Fill(this.bmiDataSet1.wiek);
            // TODO: This line of code loads data into the 'bmiDataSet1.tabela_bmi' table. You can move, or remove it, as needed.
            this.tabela_bmiTableAdapter1.Fill(this.bmiDataSet1.tabela_bmi);

          
            textWaga.Text = "0";
            textWzrost.Text = "0";
            textWiek.Text = "0";
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textWaga_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BMI_TextChanged(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        ///  button2_Click odpowiedzialny jest za usuwanie wartosci z pól textowych.
        /// </summary>
        /// <param name= "textWzrost.Clear()"> Usuwa wartosc z pola wzrost </param>
        /// <param name= "textWaga.Clear()"> Usuwa wartosc z pola waga </param>
        /// <param name= "textWynik.Clear()"> Usuwa wartosc z pola wynik </param>
        /// <param name= "textWiek.Clear()"> Usuwa wartosc z pola wiek </param>
        /// <param name="textWynik.BackColor = Color.White;"> Daje polu wynik biały kolor</param>

        private void button2_Click(object sender, EventArgs e)
        {
          

            textWzrost.Clear();
            textWaga.Clear();
            textWynik.Clear();
            textWiek.Clear();

            linkLabel1.Text = "";
            textWynik.BackColor = Color.White;
         
            textWaga.Text = "0";
            textWzrost.Text = "0";
            textWiek.Text = "0";
         
        }

        private void textWzrost_TextChanged(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// button4 odpowiedzialny jest za wyliczanie bmi, wartosci z pól textowych są zamieniane na wartości typu double i wyliczane. Wynik zwracany jest w textWynik.Text
        /// </summary>
        /// <param name="double w = Convert.ToDouble(textWaga.Text);">Zmiena textowe pole waga na typ double, jest to konieczne do wykonania obliczeń</param>
        /// <param name="double h = Convert.ToDouble(textWzrost.Text);">Zmiena textowe pole wzrost na typ double, jest to konieczne do wykonania obliczeń</param>
        /// <param name="double wynik = w / (h * h) * 10000;">Oblicza wynik</param>
        /// <param name="wynik = (double)System.Math.Round(wynik, 2);">Skraca wynik do dwóch miejs po przecinku</param>
        /// <param name="textWynik.Text = wynik.ToString();">Zamienia double wynik na string żeby wyświetlić go w polu tekstowym</param>

        public void button4_Click(object sender, EventArgs e)
        {
           

                double w = Convert.ToDouble(textWaga.Text);
                double h = Convert.ToDouble(textWzrost.Text);

          
                double wynik = w / (h * h) * 10000; 
                wynik = (double)System.Math.Round(wynik, 2);

                textWynik.Text = wynik.ToString();
                double wiek = Convert.ToDouble(textWiek.Text);

         

            
            if (wiek > 18 && wiek < 24)
            {
                if (wynik > 18.5 && wynik < 24.9)
                { textWynik.BackColor = Color.Green; }
                else
                    textWynik.BackColor = Color.White;
            }
            else if (wiek > 24 && wiek < 34)
            {
                if (wynik > 20.5 && wynik < 25.9)
                { textWynik.BackColor = Color.Green; }
                else
                    textWynik.BackColor = Color.White;
            }
           else if (wiek > 35 && wiek < 44)
            {
                if (wynik > 21.5 && wynik < 26.9)
                { textWynik.BackColor = Color.Green; }
                else
                    textWynik.BackColor = Color.White;
            }
           else if (wiek > 45 && wiek < 54)
            {
                if (wynik > 22.5 && wynik < 27.9)
                { textWynik.BackColor = Color.Green; }
                else
                    textWynik.BackColor = Color.White;
            }
            else if (wiek > 55 && wiek < 64)
            {
                if (wynik > 23.5 && wynik < 28.9)
                { textWynik.BackColor = Color.Green; }
                else
                    textWynik.BackColor = Color.White;

            }
           else if (wiek > 65)
            {
                if (wynik > 24.5 && wynik < 29.9)
                { textWynik.BackColor = Color.Green; }
                else
                    textWynik.BackColor = Color.White;
            }
           
        }

        private void BMI(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void textWiek_TextChanged(object sender, EventArgs e)
        {

        }

        private void Opis_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
