namespace Baitap
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
            this.txtinput = new System.Windows.Forms.TextBox();
            this.txtoutput = new System.Windows.Forms.RichTextBox();
            this.btThuchien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(56, 52);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(432, 21);
            this.txtinput.TabIndex = 0;
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(56, 79);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(432, 136);
            this.txtoutput.TabIndex = 1;
            this.txtoutput.Text = "";
            // 
            // btThuchien
            // 
            this.btThuchien.Location = new System.Drawing.Point(546, 48);
            this.btThuchien.Name = "btThuchien";
            this.btThuchien.Size = new System.Drawing.Size(87, 23);
            this.btThuchien.TabIndex = 2;
            this.btThuchien.Text = "Thực hiện";
            this.btThuchien.UseVisualStyleBackColor = true;
            this.btThuchien.Click += new System.EventHandler(this.btThuchien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 275);
            this.Controls.Add(this.btThuchien);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.txtinput);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.RichTextBox txtoutput;
        private System.Windows.Forms.Button btThuchien;
    }
}

