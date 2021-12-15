
namespace Discrete_Math_Project
{
    partial class Equivalence_Classes
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
            this.Close_Btn_Panel = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Texbox_Holder_Panel = new System.Windows.Forms.Panel();
            this.Equivalence_Classes_TB = new System.Windows.Forms.TextBox();
            this.Close_Btn_Panel.SuspendLayout();
            this.Texbox_Holder_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Close_Btn_Panel
            // 
            this.Close_Btn_Panel.Controls.Add(this.Close_Btn);
            this.Close_Btn_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Close_Btn_Panel.Location = new System.Drawing.Point(0, 289);
            this.Close_Btn_Panel.Name = "Close_Btn_Panel";
            this.Close_Btn_Panel.Size = new System.Drawing.Size(396, 57);
            this.Close_Btn_Panel.TabIndex = 2;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Close_Btn.Location = new System.Drawing.Point(136, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(125, 57);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.Text = "Close";
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Texbox_Holder_Panel
            // 
            this.Texbox_Holder_Panel.Controls.Add(this.Equivalence_Classes_TB);
            this.Texbox_Holder_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texbox_Holder_Panel.Location = new System.Drawing.Point(0, 0);
            this.Texbox_Holder_Panel.Name = "Texbox_Holder_Panel";
            this.Texbox_Holder_Panel.Size = new System.Drawing.Size(396, 289);
            this.Texbox_Holder_Panel.TabIndex = 3;
            // 
            // Equivalence_Classes_TB
            // 
            this.Equivalence_Classes_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equivalence_Classes_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Equivalence_Classes_TB.Location = new System.Drawing.Point(0, 0);
            this.Equivalence_Classes_TB.Multiline = true;
            this.Equivalence_Classes_TB.Name = "Equivalence_Classes_TB";
            this.Equivalence_Classes_TB.ReadOnly = true;
            this.Equivalence_Classes_TB.Size = new System.Drawing.Size(396, 289);
            this.Equivalence_Classes_TB.TabIndex = 0;
            // 
            // Equivalence_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 346);
            this.Controls.Add(this.Texbox_Holder_Panel);
            this.Controls.Add(this.Close_Btn_Panel);
            this.Name = "Equivalence_Classes";
            this.Text = "Equivalence Classes";
            this.Close_Btn_Panel.ResumeLayout(false);
            this.Texbox_Holder_Panel.ResumeLayout(false);
            this.Texbox_Holder_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Close_Btn_Panel;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Panel Texbox_Holder_Panel;
        private System.Windows.Forms.TextBox Equivalence_Classes_TB;
    }
}