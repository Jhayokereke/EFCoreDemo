
namespace EFCoreDemo.UI
{
    partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            this.dotnet_tbl = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.GetAll_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dotnet_tbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dotnet_tbl
            // 
            this.dotnet_tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dotnet_tbl.Location = new System.Drawing.Point(12, 77);
            this.dotnet_tbl.Name = "dotnet_tbl";
            this.dotnet_tbl.RowHeadersWidth = 51;
            this.dotnet_tbl.RowTemplate.Height = 29;
            this.dotnet_tbl.Size = new System.Drawing.Size(683, 188);
            this.dotnet_tbl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DotNet Fellows";
            // 
            // GetAll_btn
            // 
            this.GetAll_btn.Location = new System.Drawing.Point(25, 297);
            this.GetAll_btn.Name = "GetAll_btn";
            this.GetAll_btn.Size = new System.Drawing.Size(94, 29);
            this.GetAll_btn.TabIndex = 2;
            this.GetAll_btn.Text = "GetAll";
            this.GetAll_btn.UseVisualStyleBackColor = true;
            this.GetAll_btn.Click += new System.EventHandler(this.GetAll_btn_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GetAll_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dotnet_tbl);
            this.Name = "ViewForm";
            this.Text = "ViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.dotnet_tbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dotnet_tbl;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetAll_btn;
    }
}