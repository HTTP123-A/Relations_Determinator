
namespace Discrete_Math_Project
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Result_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CB_Transitive = new System.Windows.Forms.CheckBox();
            this.CB_isAntiSymmetric = new System.Windows.Forms.CheckBox();
            this.CB_isSymmetric = new System.Windows.Forms.CheckBox();
            this.CB_isReflexive = new System.Windows.Forms.CheckBox();
            this.Result_Matrix = new System.Windows.Forms.DataGridView();
            this.CB_Equivalent = new System.Windows.Forms.CheckBox();
            this.CB_Total = new System.Windows.Forms.CheckBox();
            this.CB_Partial = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_Matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Result_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 54);
            this.panel1.TabIndex = 0;
            // 
            // Result_Label
            // 
            this.Result_Label.AutoSize = true;
            this.Result_Label.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Result_Label.Location = new System.Drawing.Point(341, 13);
            this.Result_Label.Name = "Result_Label";
            this.Result_Label.Size = new System.Drawing.Size(93, 29);
            this.Result_Label.TabIndex = 0;
            this.Result_Label.Text = "Result:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Result_Matrix);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 361);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CB_Equivalent);
            this.panel3.Controls.Add(this.CB_Total);
            this.panel3.Controls.Add(this.CB_Partial);
            this.panel3.Controls.Add(this.CB_Transitive);
            this.panel3.Controls.Add(this.CB_isAntiSymmetric);
            this.panel3.Controls.Add(this.CB_isSymmetric);
            this.panel3.Controls.Add(this.CB_isReflexive);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(610, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 361);
            this.panel3.TabIndex = 1;
            // 
            // CB_Transitive
            // 
            this.CB_Transitive.AutoCheck = false;
            this.CB_Transitive.AutoSize = true;
            this.CB_Transitive.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_Transitive.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Transitive.Location = new System.Drawing.Point(0, 81);
            this.CB_Transitive.Name = "CB_Transitive";
            this.CB_Transitive.Size = new System.Drawing.Size(164, 27);
            this.CB_Transitive.TabIndex = 3;
            this.CB_Transitive.Text = "Transitive";
            this.CB_Transitive.UseVisualStyleBackColor = true;
            // 
            // CB_isAntiSymmetric
            // 
            this.CB_isAntiSymmetric.AutoCheck = false;
            this.CB_isAntiSymmetric.AutoSize = true;
            this.CB_isAntiSymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_isAntiSymmetric.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_isAntiSymmetric.Location = new System.Drawing.Point(0, 54);
            this.CB_isAntiSymmetric.Name = "CB_isAntiSymmetric";
            this.CB_isAntiSymmetric.Size = new System.Drawing.Size(164, 27);
            this.CB_isAntiSymmetric.TabIndex = 2;
            this.CB_isAntiSymmetric.Text = "Anti Symmetric";
            this.CB_isAntiSymmetric.UseVisualStyleBackColor = true;
            // 
            // CB_isSymmetric
            // 
            this.CB_isSymmetric.AutoCheck = false;
            this.CB_isSymmetric.AutoSize = true;
            this.CB_isSymmetric.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_isSymmetric.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_isSymmetric.Location = new System.Drawing.Point(0, 27);
            this.CB_isSymmetric.Name = "CB_isSymmetric";
            this.CB_isSymmetric.Size = new System.Drawing.Size(164, 27);
            this.CB_isSymmetric.TabIndex = 1;
            this.CB_isSymmetric.Text = "Symmetric";
            this.CB_isSymmetric.UseVisualStyleBackColor = true;
            // 
            // CB_isReflexive
            // 
            this.CB_isReflexive.AutoCheck = false;
            this.CB_isReflexive.AutoSize = true;
            this.CB_isReflexive.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_isReflexive.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_isReflexive.Location = new System.Drawing.Point(0, 0);
            this.CB_isReflexive.Name = "CB_isReflexive";
            this.CB_isReflexive.Size = new System.Drawing.Size(164, 27);
            this.CB_isReflexive.TabIndex = 0;
            this.CB_isReflexive.Text = " Reflexive";
            this.CB_isReflexive.UseVisualStyleBackColor = true;
            // 
            // Result_Matrix
            // 
            this.Result_Matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_Matrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result_Matrix.Location = new System.Drawing.Point(0, 0);
            this.Result_Matrix.Name = "Result_Matrix";
            this.Result_Matrix.Size = new System.Drawing.Size(774, 361);
            this.Result_Matrix.TabIndex = 0;
            // 
            // CB_Equivalent
            // 
            this.CB_Equivalent.AutoCheck = false;
            this.CB_Equivalent.AutoSize = true;
            this.CB_Equivalent.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_Equivalent.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Equivalent.Location = new System.Drawing.Point(0, 162);
            this.CB_Equivalent.Name = "CB_Equivalent";
            this.CB_Equivalent.Size = new System.Drawing.Size(164, 27);
            this.CB_Equivalent.TabIndex = 6;
            this.CB_Equivalent.Text = "Equivalent";
            this.CB_Equivalent.UseVisualStyleBackColor = true;
            // 
            // CB_Total
            // 
            this.CB_Total.AutoCheck = false;
            this.CB_Total.AutoSize = true;
            this.CB_Total.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_Total.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Total.Location = new System.Drawing.Point(0, 135);
            this.CB_Total.Name = "CB_Total";
            this.CB_Total.Size = new System.Drawing.Size(164, 27);
            this.CB_Total.TabIndex = 5;
            this.CB_Total.Text = "Total Order";
            this.CB_Total.UseVisualStyleBackColor = true;
            // 
            // CB_Partial
            // 
            this.CB_Partial.AutoCheck = false;
            this.CB_Partial.AutoSize = true;
            this.CB_Partial.Dock = System.Windows.Forms.DockStyle.Top;
            this.CB_Partial.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Partial.Location = new System.Drawing.Point(0, 108);
            this.CB_Partial.Name = "CB_Partial";
            this.CB_Partial.Size = new System.Drawing.Size(164, 27);
            this.CB_Partial.TabIndex = 4;
            this.CB_Partial.Text = "Partial Order";
            this.CB_Partial.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Result";
            this.Text = "Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Result_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Result_Matrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Result_Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Result_Matrix;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox CB_Transitive;
        private System.Windows.Forms.CheckBox CB_isAntiSymmetric;
        private System.Windows.Forms.CheckBox CB_isSymmetric;
        private System.Windows.Forms.CheckBox CB_isReflexive;
        private System.Windows.Forms.CheckBox CB_Equivalent;
        private System.Windows.Forms.CheckBox CB_Total;
        private System.Windows.Forms.CheckBox CB_Partial;
    }
}