namespace WindowsFormsApp5
{
    partial class Form3
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
            this.btnRandomColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomColor
            // 
            this.btnRandomColor.Location = new System.Drawing.Point(160, 177);
            this.btnRandomColor.Name = "btnRandomColor";
            this.btnRandomColor.Size = new System.Drawing.Size(165, 34);
            this.btnRandomColor.TabIndex = 0;
            this.btnRandomColor.Text = "Случайный цвет";
            this.btnRandomColor.UseVisualStyleBackColor = true;
            this.btnRandomColor.Click += new System.EventHandler(this.btnRandomColor_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 340);
            this.Controls.Add(this.btnRandomColor);
            this.Name = "Form3";
            this.Text = "Задание 2";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandomColor;
    }
}