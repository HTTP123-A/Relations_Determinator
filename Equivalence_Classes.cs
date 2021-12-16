using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discrete_Math_Project
{
    public partial class Equivalence_Classes : Form
    {
        #region Initial Variables and Data Types for passing data
        DataTable matrix;
        int min, max;
        #endregion


        #region Constructor
        public Equivalence_Classes(DataTable temp, int min, int max)
        {
            InitializeComponent();
            this.matrix = temp;
            this.min = min;
            this.max = max;
            Equivalence_Classes_Display();
        }
        #endregion


        #region Find and Display equivalence class
        private void Equivalence_Classes_Display()
        {
            try
            {
                string[] equivalence_class = new string[max-min+1];
                for (int i = 0; i <= max - min; i++)
                {                    
                    equivalence_class[i] = "[" + (i + min) + "] = {";

                    for (int j = 0; j <= max - min; j++)
                    {
                        string cell = matrix.Rows[j][i].ToString();
                        if (cell == "1") equivalence_class[i] += (j + min) + ", ";
                    }
                    equivalence_class[i] = equivalence_class[i].Substring(0, equivalence_class[i].Length - 2);
                    equivalence_class[i] += "}";
                    Console.WriteLine(equivalence_class[i]);

                }
                
                for (int i = 0; i <= max-min; i++)
                {
                    this.Equivalence_Classes_TB.Text += equivalence_class[i] + Environment.NewLine;                       
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot Display Equivalence classes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                      
        }
        #endregion


        #region Close Button
        private void Close_Btn_Click(object sender, EventArgs e) => this.Close();
        #endregion
    }
}
