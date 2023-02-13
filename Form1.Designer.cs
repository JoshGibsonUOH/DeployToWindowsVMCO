namespace TestApplicationForClickOnce
{
    partial class Form1
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
            this.tbNumberBox = new System.Windows.Forms.TextBox();
            this.btn_AddNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNumberBox
            // 
            this.tbNumberBox.Location = new System.Drawing.Point(231, 227);
            this.tbNumberBox.Name = "tbNumberBox";
            this.tbNumberBox.Size = new System.Drawing.Size(351, 23);
            this.tbNumberBox.TabIndex = 0;
            this.tbNumberBox.Text = "0";
            // 
            // btn_AddNumber
            // 
            this.btn_AddNumber.Location = new System.Drawing.Point(368, 256);
            this.btn_AddNumber.Name = "btn_AddNumber";
            this.btn_AddNumber.Size = new System.Drawing.Size(86, 41);
            this.btn_AddNumber.TabIndex = 1;
            this.btn_AddNumber.Text = "Add Random Number";
            this.btn_AddNumber.UseVisualStyleBackColor = true;
            this.btn_AddNumber.Click += new System.EventHandler(this.btn_AddNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 582);
            this.Controls.Add(this.btn_AddNumber);
            this.Controls.Add(this.tbNumberBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbNumberBox;
        private Button btn_AddNumber;
    }
}