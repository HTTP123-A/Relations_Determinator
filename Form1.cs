﻿using System;
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
    public partial class Form1 : Form
    {
        int Num_Of_Element = 0;
        DataTable Elements;

        public Form1()
        {
            InitializeComponent();
            this.Relation_Btn.Enabled = false;
        }

        #region Enter button to enter data
        private void Num_Element_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Num_Of_Element = int.Parse(this.Element_Count_TextBox.Text.ToString());
                this.Elements = new DataTable();
                Elements.Clear();
                Elements.Columns.Add("X");
                Elements.Columns.Add("Y");

                for (int i = 0; i < Num_Of_Element; i++)
                {
                    DataRow row_data = Elements.NewRow();
                    row_data["X"] = "0";
                    row_data["Y"] = "0";
                    Elements.Rows.Add(row_data);
                }

                this.DGV_Elements.DataSource = Elements;
                this.Elements.Dispose();
                //MessageBox.Show("Add successfully number of elements!", "Number of Element:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot retrieve number of elements!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            Elements = new DataTable();
            Elements.Clear();
            Elements.Columns.Add("X");
            Elements.Columns.Add("Y");

            for (int i=0; i<Num_Of_Element; i++)
            {
                DataRow row_data = Elements.NewRow();
                row_data["X"] = DGV_Elements.Rows[i].Cells[0].Value.ToString();
                row_data["Y"] = DGV_Elements.Rows[i].Cells[1].Value.ToString();
                Elements.Rows.Add(row_data);
            }
            this.Relation_Btn.Enabled = true;
        }
        private void Relation_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Num_Element_Btn.Enabled = false;
                this.Relation_Btn.Enabled = false;
                Form Result_Form = new Result(Elements, Num_Of_Element);
                Result_Form.ShowDialog();
                
                if (Result_Form.DialogResult == DialogResult.OK)                                     
                    this.Num_Element_Btn.Enabled = true;                
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot open the Result Window!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        #endregion
    }
}
