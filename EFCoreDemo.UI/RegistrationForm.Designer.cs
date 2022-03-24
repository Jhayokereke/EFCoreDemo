
namespace EFCoreDemo.UI
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fname_txt = new System.Windows.Forms.TextBox();
            this.MName_txt = new System.Windows.Forms.TextBox();
            this.LName_txt = new System.Windows.Forms.TextBox();
            this.State_txt = new System.Windows.Forms.TextBox();
            this.Gender_txt = new System.Windows.Forms.TextBox();
            this.Create_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fname_txt
            // 
            this.Fname_txt.Location = new System.Drawing.Point(46, 47);
            this.Fname_txt.Name = "Fname_txt";
            this.Fname_txt.PlaceholderText = "FirstName";
            this.Fname_txt.Size = new System.Drawing.Size(318, 27);
            this.Fname_txt.TabIndex = 0;
            this.Fname_txt.TextChanged += new System.EventHandler(this.Fname_txt_TextChanged);
            // 
            // MName_txt
            // 
            this.MName_txt.Location = new System.Drawing.Point(46, 126);
            this.MName_txt.Name = "MName_txt";
            this.MName_txt.PlaceholderText = "MiddleName";
            this.MName_txt.Size = new System.Drawing.Size(318, 27);
            this.MName_txt.TabIndex = 1;
            // 
            // LName_txt
            // 
            this.LName_txt.Location = new System.Drawing.Point(46, 197);
            this.LName_txt.Name = "LName_txt";
            this.LName_txt.PlaceholderText = "LastName";
            this.LName_txt.Size = new System.Drawing.Size(318, 27);
            this.LName_txt.TabIndex = 2;
            // 
            // State_txt
            // 
            this.State_txt.Location = new System.Drawing.Point(46, 276);
            this.State_txt.Name = "State_txt";
            this.State_txt.PlaceholderText = "StateId";
            this.State_txt.Size = new System.Drawing.Size(318, 27);
            this.State_txt.TabIndex = 3;
            // 
            // Gender_txt
            // 
            this.Gender_txt.Location = new System.Drawing.Point(46, 343);
            this.Gender_txt.Name = "Gender_txt";
            this.Gender_txt.PlaceholderText = "GenderId";
            this.Gender_txt.Size = new System.Drawing.Size(318, 27);
            this.Gender_txt.TabIndex = 4;
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(269, 399);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(94, 29);
            this.Create_btn.TabIndex = 5;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.Gender_txt);
            this.Controls.Add(this.State_txt);
            this.Controls.Add(this.LName_txt);
            this.Controls.Add(this.MName_txt);
            this.Controls.Add(this.Fname_txt);
            this.Name = "RegistrationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fname_txt;
        private System.Windows.Forms.TextBox MName_txt;
        private System.Windows.Forms.TextBox LName_txt;
        private System.Windows.Forms.TextBox State_txt;
        private System.Windows.Forms.TextBox Gender_txt;
        private System.Windows.Forms.Button Create_btn;
    }
}

