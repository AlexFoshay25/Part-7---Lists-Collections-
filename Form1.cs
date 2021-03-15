using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_7___Lists__Collections_
{
    public partial class Form1 : Form
    {
        List<int> numbers = new List<int>();
        List<string> heroes = new List<string>();

        

        

        Random generator = new Random();

        public Form1()
        {
            InitializeComponent();



        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnSortNumbers_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;

            lblStatus.Text = $"Status: Numbers Sorted";

            
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;

            lblStatus.Text = $"Status: Heroes Sorted";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            heroes.Add("Batman");

            heroes.Add("Superman");


            lstNumbers.DataSource = numbers;

            lstHeroes.DataSource = heroes;



        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;

            lblStatus.Text = $"Status: New Numbers List";


        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();

            heroes.Add("Superman");
            heroes.Add("Batman");

            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;

            lblStatus.Text = $"Status: New Heroes List";
        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {
            lstNumbers.SelectedIndex.RemoveAt();

            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;


        }
    }
}
