using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._7
{
    public partial class Form1 : Form
    {
        Random Slump = new Random();
        int antal = 5;
        int[] tärningar = new int[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKasta_Click(object sender, EventArgs e)
        {
            
            
            kastaTärningar(tärningar, 5);
            visaTärningar(tärningar, 5);
        }
        void kastaTärningar(int[] tärningar, int antal) 
        {
            for (int i=0; i < antal; i++)
            {
                int antalPrickar = Slump.Next(1, 7); // Slumpar mellan sifforna 1 till 6 åt varje tärning
                tärningar[i] = antalPrickar;
            }
        }
        void visaTärningar(int[] tärningar, int antal)
        {
            tbxResultat.Text = "";
            for (int i=0;i < antal; i++) 
            {
                tbxResultat.AppendText("Tärning " + (i + 1) + ": " + tärningar[i] + "\r\n");
            }
        }
    }
}
