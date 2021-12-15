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
    public partial class Result : Form
    {
        DataTable result; //Passed from the main form
        DataTable matrix; //Matrix that hold the 1 and 0
        DataTable matrix_square; //matrix*matrix = matrix_square => For checking Transitive
        int number_of_row;
        int[,] multid_array_for_table;
        int max_number_to_create_matrix;
        int min_number_to_create_matrix;       

        bool reflexive = false;
        bool symmetric = false;
        bool antisymmetric = false;
        bool transitive = false;

        public Result(DataTable temp, int elements)
        {
            InitializeComponent();
            this.result = temp;
            this.number_of_row = elements;
            
            Max_Elements();
            create_Matrix();

            #region Checking Relation
            try
            {
                reflexive = isReflexive();
                symmetric = isSymmetric();
                antisymmetric = isAntiSymmetric();

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot Check Properties!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            Display_Props();
        }


        #region Relation determination
        private bool isReflexive()
        {
            string bool_string = "0";
            for (int i = 0; i <= max_number_to_create_matrix - min_number_to_create_matrix; i++)
            {
                bool_string = matrix.Rows[i][i].ToString();
                Console.WriteLine(bool_string);
                if (bool_string == "0") return false;
            }                    
            return true;
        }
        private bool isSymmetric()
        {
            string string_xy = "0";
            string string_yx = "0";

            for (int i = 0; i <= max_number_to_create_matrix - min_number_to_create_matrix; i++)
            {
                for (int j = 0; j <= max_number_to_create_matrix - min_number_to_create_matrix; j++)
                {
                    //string_xy = matrix.Rows[i - min_number_to_create_matrix][j - min_number_to_create_matrix].ToString();
                    //string_yx = matrix.Rows[j - min_number_to_create_matrix][i - min_number_to_create_matrix].ToString();
                    string_xy = matrix.Rows[i][j].ToString();
                    if (((string_xy == "1") && (string_yx == "0")) || ((string_xy == "0") && (string_yx == "1")))
                        return false;
                }
            }
            return true;
        }
        private bool isAntiSymmetric()
        {
            string string_xy = "0";
            string string_yx = "0";
            for (int i = 0; i <= max_number_to_create_matrix - min_number_to_create_matrix; i++)
            {
                for (int j = 0; j <= max_number_to_create_matrix - min_number_to_create_matrix; j++)
                {
                    //string_xy = matrix.Rows[i - min_number_to_create_matrix][j - min_number_to_create_matrix].ToString();
                    //string_yx = matrix.Rows[j - min_number_to_create_matrix][i - min_number_to_create_matrix].ToString();
                    string_xy = matrix.Rows[i][j].ToString();
                    string_yx = matrix.Rows[j][i].ToString();
                    if ((string_xy == "1") && (string_yx == "1") && (i != j))
                        return false;
                }    
            }    
            return true;
        }
        private bool isTransitive()
        {


            return true;
        }
        #endregion


        #region Display Properties
        private void Display_Props()
        {
            CB_isReflexive.Checked = reflexive;
            CB_isSymmetric.Checked = symmetric;
            CB_isAntiSymmetric.Checked = antisymmetric;
            CB_Transitive.Checked = transitive;
        }
        #endregion


        #region Find max value
        private void Max_Elements()
        {
            multid_array_for_table = new int[number_of_row, 2];
            int max_value = 0;
            int min_value = 0;
            
            //Transfer Datatable to 2D Array
            for (int i=0; i<number_of_row; i++)
            {
                multid_array_for_table[i, 0] = int.Parse(result.Rows[i]["X"].ToString());
                multid_array_for_table[i, 1] = int.Parse(result.Rows[i]["Y"].ToString());
                Console.WriteLine(multid_array_for_table[i, 0] + "  " + multid_array_for_table[i, 1]);
                
            }
            Console.WriteLine("=============================");

            //Find Max number in the 2D Array
            max_value = multid_array_for_table[0, 0];
            min_value = multid_array_for_table[0 ,0];
            for (int i=0; i<number_of_row; i++)
            {
                
                for (int j=0; j<2; j++)
                {
                    if (multid_array_for_table[i, j] > max_value)
                        max_value = multid_array_for_table[i, j];
                }
                for (int k = 0; k < 2; k++)
                    if (multid_array_for_table[i, k] < min_value)
                        min_value = multid_array_for_table[i, k];
            }
            Console.WriteLine(max_value);
            Console.WriteLine(min_value);
            Console.WriteLine("=============================");
            this.max_number_to_create_matrix = max_value;
            this.min_number_to_create_matrix = min_value;
        }
        #endregion


        #region Create Matrix
        private void create_Matrix()
        {
            try
            {
                this.matrix = new DataTable();
                matrix.Clear();

                for (int i = min_number_to_create_matrix; i <= max_number_to_create_matrix; i++)
                {
                    matrix.Columns.Add(i.ToString());
                }
                for (int i = min_number_to_create_matrix; i <= max_number_to_create_matrix; i++)
                {
                    DataRow row_data = matrix.NewRow();
                    for (int j = min_number_to_create_matrix; j <= max_number_to_create_matrix; j++)
                        row_data[j.ToString()] = "0";
                    matrix.Rows.Add(row_data);
                }
                
                for (int i = 0; i < number_of_row; i++)
                {
                    int x_pos = multid_array_for_table[i, 0];
                    int y_pos = multid_array_for_table[i, 1];
                    Console.WriteLine(x_pos + " " + y_pos);
                    
                    matrix.Rows[x_pos-min_number_to_create_matrix][y_pos-min_number_to_create_matrix] = "1";
                }
                Console.WriteLine("=============================");
                this.Result_Matrix.DataSource = matrix;
            }
            catch(Exception)
            {
                MessageBox.Show("Cannot create matrix!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void square_a_matrix()
        {
            try
            {
                int square_cell = 0;
                int c1 = 0;
                int c2 = 0;

                this.matrix_square = new DataTable();
                matrix_square.Clear();
                for (int i = min_number_to_create_matrix; i <= max_number_to_create_matrix; i++)
                {
                    matrix_square.Columns.Add(i.ToString());
                }
                for (int i = min_number_to_create_matrix; i <= max_number_to_create_matrix; i++)
                {
                    DataRow row_data = matrix_square.NewRow();
                    for (int j = min_number_to_create_matrix; j <= max_number_to_create_matrix; j++)
                        row_data[j.ToString()] = "0";
                    matrix_square.Rows.Add(row_data);
                }

                for (int i = 0; i <= max_number_to_create_matrix - min_number_to_create_matrix; i++)
                {  
                    for (int j = 0; j <= max_number_to_create_matrix - min_number_to_create_matrix; j++)
                    {                        
                        for (int k = 0; k <= max_number_to_create_matrix - min_number_to_create_matrix; k++)
                        {


                            square_cell = square_cell + 1;
                        }
                    }    
                }    
            }   
            catch(Exception)
            {
                MessageBox.Show("Cannot create square matrix!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
