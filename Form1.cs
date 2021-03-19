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
            UpdateListbox();

            lblStatus.Text = $"Status: Numbers Sorted";

            
        }

        private void btnSortHeroes_Click(object sender, EventArgs e)
        {
            heroes.Sort();
            UpdateListbox();

            lblStatus.Text = $"Status: Heroes Sorted";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            heroes.Add("BATMAN");

            heroes.Add("SUPERMAN");


            lstNumbers.DataSource = numbers;

            lstHeroes.DataSource = heroes;



        }

        private void btnNewNumbers_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            for (int i = 0; i < 20; i++)
                numbers.Add(generator.Next(100));

            UpdateListbox();

            lblStatus.Text = $"Status: New Numbers List";


        }

        private void btnNewHeroes_Click(object sender, EventArgs e)
        {
            heroes.Clear();

            heroes.Add("SUPERMAN");
            heroes.Add("BATMAN");

            UpdateListbox();

            lblStatus.Text = $"Status: New Heroes List";


        }

        private void btnRemoveNumber_Click(object sender, EventArgs e)
        {

            //lstNumbers.SelectedIndex;

            if (lstNumbers.SelectedIndex > -1)
            {
                numbers.RemoveAt(lstNumbers.SelectedIndex);
            }

            UpdateListbox();

            lblStatus.Text = $"Status: Selected Number Removed";


        }

        private void btnRemoveAllNumbers_Click(object sender, EventArgs e)
        {
                while (numbers.Remove((int)lstNumbers.SelectedItem)) ;

            UpdateListbox();

            lblStatus.Text = $"Status: All Numbers Removed";




        }
        private void UpdateListbox()
        {
            lstNumbers.DataSource = null;
            lstNumbers.DataSource = numbers;

            lstHeroes.DataSource = null;
            lstHeroes.DataSource = heroes;
        }

        private void btnRemoveHero_Click(object sender, EventArgs e)
        {
            if (heroes.Contains(txtRemoveHero.Text.Trim().ToUpper()))
            {
                heroes.Remove(txtRemoveHero.Text.ToUpper());
                UpdateListbox();
            
                lblStatus.Text = ($"Status: {txtRemoveHero.Text} + has been removed");
                txtRemoveHero.Text = "";
            }
            else
            {
                lblStatus.Text = ($"Status: { txtRemoveHero.Text} + does not exist in the list of current heroes");
                txtRemoveHero.Text = "";
            }

        }
        private void btnAddHero_Click(object sender, EventArgs e)
        {
            string newHero = txtAddHero.Text.Trim();
            if (newHero != "")
            {
                if (heroes.Contains(newHero.ToUpper()))
                {
                    lblError.Text = "Please enter a new Hero in the list";
                    lblStatus.Text = "Error";
                    txtAddHero.Text = "";
                }
                else
                {
                    heroes.Add(newHero.ToUpper());
                    UpdateListbox();
                    lblStatus.Text = ($"New Hero named {newHero} has been added");
                    txtAddHero.Text = "";
                }
            }
            

        }

        private void btnAscending_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            heroes.Sort();
            UpdateListbox();

            lblStatus.Text = $"Status: Numbers Sorted";
            lblStatus.Text = $"Status: Heroes Sorted";
        }

        private void btnDescending_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            numbers.Reverse();
            heroes.Reverse();
            UpdateListbox();

            lblStatus.Text = $"Status: Numbers Sorted";
            lblStatus.Text = $"Status; Heros Sorted";
        }
    }
}
