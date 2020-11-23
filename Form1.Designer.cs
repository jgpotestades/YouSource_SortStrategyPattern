namespace YouSource_SortStrategyPattern
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
            this.txtBox_input = new System.Windows.Forms.TextBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.cmbBox_Type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBox_input
            // 
            this.txtBox_input.Location = new System.Drawing.Point(35, 79);
            this.txtBox_input.Name = "txtBox_input";
            this.txtBox_input.Size = new System.Drawing.Size(121, 20);
            this.txtBox_input.TabIndex = 0;
            // 
            // lbl_Output
            // 
            this.lbl_Output.AutoSize = true;
            this.lbl_Output.Location = new System.Drawing.Point(32, 170);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(0, 13);
            this.lbl_Output.TabIndex = 1;
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(35, 128);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.btn_Sort.TabIndex = 2;
            this.btn_Sort.Text = "SORT";
            this.btn_Sort.UseVisualStyleBackColor = true;
            this.btn_Sort.Click += new System.EventHandler(this.btn_Sort_Click);
            // 
            // cmbBox_Type
            // 
            this.cmbBox_Type.FormattingEnabled = true;
            this.cmbBox_Type.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort"});
            this.cmbBox_Type.Location = new System.Drawing.Point(35, 26);
            this.cmbBox_Type.Name = "cmbBox_Type";
            this.cmbBox_Type.Size = new System.Drawing.Size(121, 21);
            this.cmbBox_Type.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 223);
            this.Controls.Add(this.cmbBox_Type);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.txtBox_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_input;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.ComboBox cmbBox_Type;
    }
}

