namespace StaticSınıflarDevam
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
            this.lblForm1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForm1
            // 
            this.lblForm1.AutoSize = true;
            this.lblForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForm1.Location = new System.Drawing.Point(141, 135);
            this.lblForm1.Name = "lblForm1";
            this.lblForm1.Size = new System.Drawing.Size(35, 37);
            this.lblForm1.TabIndex = 1;
            this.lblForm1.Text = "8";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Form2 Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblForm1;
        private System.Windows.Forms.Button button1;
    }
}

