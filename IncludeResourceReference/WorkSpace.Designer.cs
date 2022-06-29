namespace IncludeResourceReference
{
    partial class WorkSpace
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
            this.btn_data_access = new System.Windows.Forms.Button();
            this.textbox_data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_data_access
            // 
            this.btn_data_access.Location = new System.Drawing.Point(294, 34);
            this.btn_data_access.Name = "btn_data_access";
            this.btn_data_access.Size = new System.Drawing.Size(111, 23);
            this.btn_data_access.TabIndex = 0;
            this.btn_data_access.Text = "데이터 불러오기";
            this.btn_data_access.UseVisualStyleBackColor = true;
            this.btn_data_access.Click += new System.EventHandler(this.btn_data_access_Click);
            // 
            // textbox_data
            // 
            this.textbox_data.Location = new System.Drawing.Point(34, 34);
            this.textbox_data.Name = "textbox_data";
            this.textbox_data.Size = new System.Drawing.Size(239, 23);
            this.textbox_data.TabIndex = 1;
            // 
            // WorkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(441, 94);
            this.Controls.Add(this.textbox_data);
            this.Controls.Add(this.btn_data_access);
            this.Name = "WorkSpace";
            this.Text = "WorkSpace";
            this.Load += new System.EventHandler(this.WorkSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_data_access;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textbox_data;
    }
}

