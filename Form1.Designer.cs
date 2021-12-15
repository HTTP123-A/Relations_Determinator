
namespace Discrete_Math_Project
{
    partial class Form1
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
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Content_Panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Relation_Btn = new System.Windows.Forms.Button();
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.DGV_Elements = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Num_Element_Btn = new System.Windows.Forms.Button();
            this.Element_Count_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Title_Panel.SuspendLayout();
            this.Content_Panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Elements)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Panel
            // 
            this.Title_Panel.Controls.Add(this.label1);
            this.Title_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_Panel.Location = new System.Drawing.Point(0, 0);
            this.Title_Panel.Name = "Title_Panel";
            this.Title_Panel.Size = new System.Drawing.Size(701, 63);
            this.Title_Panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(258, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relation Detector";
            // 
            // Content_Panel
            // 
            this.Content_Panel.Controls.Add(this.panel2);
            this.Content_Panel.Controls.Add(this.DGV_Elements);
            this.Content_Panel.Controls.Add(this.panel1);
            this.Content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_Panel.Location = new System.Drawing.Point(0, 63);
            this.Content_Panel.Name = "Content_Panel";
            this.Content_Panel.Size = new System.Drawing.Size(701, 423);
            this.Content_Panel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Relation_Btn);
            this.panel2.Controls.Add(this.Enter_Btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(523, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 349);
            this.panel2.TabIndex = 2;
            // 
            // Relation_Btn
            // 
            this.Relation_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Relation_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Relation_Btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Relation_Btn.Location = new System.Drawing.Point(0, 100);
            this.Relation_Btn.Name = "Relation_Btn";
            this.Relation_Btn.Size = new System.Drawing.Size(178, 100);
            this.Relation_Btn.TabIndex = 5;
            this.Relation_Btn.Text = "RELATION";
            this.Relation_Btn.UseVisualStyleBackColor = true;
            this.Relation_Btn.Click += new System.EventHandler(this.Relation_Btn_Click);
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Enter_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_Btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Enter_Btn.Location = new System.Drawing.Point(0, 0);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(178, 100);
            this.Enter_Btn.TabIndex = 4;
            this.Enter_Btn.Text = "ENTER";
            this.Enter_Btn.UseVisualStyleBackColor = true;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // DGV_Elements
            // 
            this.DGV_Elements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Elements.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGV_Elements.Location = new System.Drawing.Point(0, 74);
            this.DGV_Elements.Name = "DGV_Elements";
            this.DGV_Elements.Size = new System.Drawing.Size(523, 349);
            this.DGV_Elements.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Num_Element_Btn);
            this.panel1.Controls.Add(this.Element_Count_TextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 74);
            this.panel1.TabIndex = 0;
            // 
            // Num_Element_Btn
            // 
            this.Num_Element_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Num_Element_Btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Num_Element_Btn.Location = new System.Drawing.Point(489, 20);
            this.Num_Element_Btn.Name = "Num_Element_Btn";
            this.Num_Element_Btn.Size = new System.Drawing.Size(100, 35);
            this.Num_Element_Btn.TabIndex = 1;
            this.Num_Element_Btn.Text = "INPUT";
            this.Num_Element_Btn.UseVisualStyleBackColor = true;
            this.Num_Element_Btn.Click += new System.EventHandler(this.Num_Element_Btn_Click);
            // 
            // Element_Count_TextBox
            // 
            this.Element_Count_TextBox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Element_Count_TextBox.Location = new System.Drawing.Point(383, 20);
            this.Element_Count_TextBox.Name = "Element_Count_TextBox";
            this.Element_Count_TextBox.Size = new System.Drawing.Size(100, 35);
            this.Element_Count_TextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(137, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Element:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 486);
            this.Controls.Add(this.Content_Panel);
            this.Controls.Add(this.Title_Panel);
            this.Name = "Form1";
            this.Text = "Relations";
            this.Title_Panel.ResumeLayout(false);
            this.Title_Panel.PerformLayout();
            this.Content_Panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Elements)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Content_Panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Relation_Btn;
        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.DataGridView DGV_Elements;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Element_Count_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Num_Element_Btn;
    }
}

