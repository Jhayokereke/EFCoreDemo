
namespace EFCoreDemo.UI
{
    partial class BaseForm
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
            this.VF_btn = new System.Windows.Forms.Button();
            this.AF_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VF_btn
            // 
            this.VF_btn.Location = new System.Drawing.Point(51, 119);
            this.VF_btn.Name = "VF_btn";
            this.VF_btn.Size = new System.Drawing.Size(129, 29);
            this.VF_btn.TabIndex = 0;
            this.VF_btn.Text = "View Fellows";
            this.VF_btn.UseVisualStyleBackColor = true;
            this.VF_btn.Click += new System.EventHandler(this.VF_btn_Click);
            // 
            // AF_btn
            // 
            this.AF_btn.Location = new System.Drawing.Point(68, 174);
            this.AF_btn.Name = "AF_btn";
            this.AF_btn.Size = new System.Drawing.Size(94, 29);
            this.AF_btn.TabIndex = 1;
            this.AF_btn.Text = "Add Fellow";
            this.AF_btn.UseVisualStyleBackColor = true;
            this.AF_btn.Click += new System.EventHandler(this.AF_btn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 233);
            this.Controls.Add(this.AF_btn);
            this.Controls.Add(this.VF_btn);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VF_btn;
        private System.Windows.Forms.Button AF_btn;
    }
}