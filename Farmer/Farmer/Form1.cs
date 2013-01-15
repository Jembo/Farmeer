using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmer
{
    public partial class Form1 : Form
    {
        Farmer Farmer;
        public Form1()
        {
            InitializeComponent();
            Farmer = new Farmer() { NumberOfCows = 15};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("{0} bags and {1} cows", Farmer.BagsOfFeed, Farmer.NumberOfCows);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Farmer.NumberOfCows = (int)numericUpDown1.Value;
        }
    }



    class Farmer
    {

        public Farmer()
        {
            feedMultiplier = 30;
        }

        public int BagsOfFeed { get; private set; }
        private int feedMultiplier;
        public int FeedProperty { get { return feedMultiplier; } }

        private int numberofcows;

        public int NumberOfCows
        {
            get 
            {
                return numberofcows;
            }
            set
            {
                numberofcows = value;
                BagsOfFeed = numberofcows * feedMultiplier;
            }
        }
    }
}
