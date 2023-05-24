namespace Sincronico_1
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
            button1 = new Button();
            button2 = new Button();
            tenorgif = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tenorgif).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(102, 283);
            button1.Name = "button1";
            button1.Size = new Size(68, 23);
            button1.TabIndex = 0;
            button1.Text = "Maxwell";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(204, 283);
            button2.Name = "button2";
            button2.Size = new Size(68, 23);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tenorgif
            // 
            tenorgif.Image = Properties.Resources.maxwell_the_cat_maxwell;
            tenorgif.Location = new Point(57, 78);
            tenorgif.Name = "tenorgif";
            tenorgif.Size = new Size(261, 183);
            tenorgif.SizeMode = PictureBoxSizeMode.Zoom;
            tenorgif.TabIndex = 2;
            tenorgif.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 375);
            Controls.Add(tenorgif);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maxwell";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tenorgif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox tenorgif;
    }
}