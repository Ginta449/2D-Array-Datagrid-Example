using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Question_2_CA_by_GintaAndDeirdre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] weather = { "Spring", "Summer", "Autumn", "Winter" };
        string[] dates = { "2016", "2017", "2018", "2019" };

        int[,] rainfall = new int[4, 4]//initialize 2d array of integers
               {
                {150, 163, 147, 138},
                {100, 89, 88, 87},
                {157, 97, 96, 94 },
                {184, 133, 129, 117}


           };

        int[] seasonMinMax = new int[4];
        int[] yearsMinMax = new int[4];

        Dictionary<string, int> display = new Dictionary<string, int>();

        private void Form1_Load(object sender, EventArgs e)
        {

            dtgRainfall.Enabled = false;
            dtgRainfall.DefaultCellStyle.BackColor = Color.Gray;

            for (int i = 0; i < weather.Length; i++)//iterate trhough array of strings
            {
                dtgRainfall.Rows.Add(weather[i]);//print the string array in datagrid first row
            }


           

            for (int i = 0; i < rainfall.GetLength(0); i++)//must use double for loop to get the values
            {
                for (int j = 0; j < rainfall.GetLength(1); j++)
                {
                    dtgRainfall.Rows[i].Cells[1].Value = rainfall[i, 0];//print the 2d array values in datagrid
                    dtgRainfall.Rows[i].Cells[2].Value = rainfall[i, 1];
                    dtgRainfall.Rows[i].Cells[3].Value = rainfall[i, 2];
                    dtgRainfall.Rows[i].Cells[4].Value = rainfall[i, 3];
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnDryYear_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < rainfall.GetLength(0); i++)
            {
                yearsMinMax[i] = 0;

                for (int j = 0; j < rainfall.GetLength(1); j++)
                {
                    yearsMinMax[i] += rainfall[j, i];
                }

                
            }

            int minY = yearsMinMax.Min();
            display.Add(dates.Length.ToString(), yearsMinMax.Length);

            for (int i = 0; i < yearsMinMax.Length; i++)
            {
                if (yearsMinMax[i] == minY)
                {
                    string y = yearsMinMax[i].ToString();
                    y = dates[i];
                    txtDryYear.Text = y;
                }
            }
           
            
        }
         


        private void btnWetYear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rainfall.GetLength(0); i++)
            {
                yearsMinMax[i] = 0;

                for (int j = 0; j < rainfall.GetLength(1); j++)
                {
                    yearsMinMax[i] += rainfall[j, i];


                }

            }

            int maxY = yearsMinMax.Max();
            for (int i = 0; i < yearsMinMax.Length; i++)
            {
                if (yearsMinMax[i] == maxY)
                {
                    string y = yearsMinMax[i].ToString();
                    y = dates[i];
                    txtWetYear.Text = y;
                }
            }


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dtgRainfall.DefaultCellStyle.BackColor = Color.Gray;
            lstValues.Items.Clear();//clear the list othervise next selected will be added on to list and calculations will be wrong
            lblRainfallCalc.Text = null;
            dtgRainfall.ClearSelection();//clear selected items in datagrid
            dtgRainfall.Enabled = false;
            txtDrySeason.Text = null;
            txtDryYear.Text = null;
            txtWetYear.Text = null;
            txtWetSeason.Text = null;
            txtAll.Text = null;
            btnGet.BackColor = Color.Gray;
        }

      
        private void lstValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sum = 0;
            int[] calcArray = lstValues.Items.OfType<int>().ToArray();
            for (int i = 0; i < calcArray.Length; i++)
            {
                sum += calcArray[i];
            }
            lblRainfallCalc.Text = sum.ToString();
        }


       



        private void btnDrySeason_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rainfall.GetLength(0); i++)
            {
                seasonMinMax[i] = 0;

                for (int j = 0; j < rainfall.GetLength(1); j++)
                {
                    seasonMinMax[i] += rainfall[i, j];
                }
               
            }
            int minS = seasonMinMax.Max();
            for (int i = 0; i < seasonMinMax.Length; i++)
            {
                if (seasonMinMax[i] == minS)
                {
                    string y = seasonMinMax[i].ToString();
                    y = weather[i];
                    txtDrySeason.Text = y;
                }
            }





        }

        private void txtWetYear_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnWetSeason_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < rainfall.GetLength(0); i++)
            {
                seasonMinMax[i] = 0;

                for (int j = 0; j < rainfall.GetLength(1); j++)
                {
                    seasonMinMax[i] += rainfall[i, j];


                }

                
                
            

            }
            int maxS = seasonMinMax.Max();

            for (int i = 0; i < seasonMinMax.Length; i++)
            {
                if (seasonMinMax[i] == maxS)
                {
                    string y = seasonMinMax[i].ToString();
                    y = weather[i];
                    txtWetSeason.Text = y;
                }
            }

        }

        private void btnRowSelect_Click(object sender, EventArgs e)
        {
            dtgRainfall.Enabled = true;
            dtgRainfall.DefaultCellStyle.BackColor = Color.Aqua;
            dtgRainfall.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnGet.BackColor = Color.Aqua;
        }

        private void btnColumnSelect_Click(object sender, EventArgs e)
        {
            dtgRainfall.Enabled = true;
            dtgRainfall.DefaultCellStyle.BackColor = Color.Aqua;
            dtgRainfall.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            btnGet.BackColor = Color.Aqua;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstValues.Text != null)
                {
                    lstValues.Items.Clear();
                }
                for (int i = 0; i < dtgRainfall.SelectedCells.Count; i++) //Add selected cells from datagrid to listbox
                {

                    string[] names = lstValues.Items.OfType<String>().ToArray();
                    lstValues.Items.Add(dtgRainfall.SelectedCells[i].Value);


                }

            }
            catch (Exception)
            { };
            lstValues_SelectedIndexChanged(sender, e);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < rainfall.GetLength(0); i++)
            {

                for (int j = 0; j < rainfall.GetLength(1); j++)
                {
                    sum += rainfall[j, i];
                }

                txtAll.Text = sum.ToString();
            }
        }
    }
}
