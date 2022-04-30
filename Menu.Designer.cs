
namespace Service_Auto_Atestat_2022
{
    partial class Menu
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
            this.program_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Credits_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // program_btn
            // 
            this.program_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_btn.Location = new System.Drawing.Point(225, 301);
            this.program_btn.Name = "program_btn";
            this.program_btn.Size = new System.Drawing.Size(389, 80);
            this.program_btn.TabIndex = 2;
            this.program_btn.Text = "Programeaza-te";
            this.program_btn.UseVisualStyleBackColor = true;
            this.program_btn.Click += new System.EventHandler(this.program_btn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(225, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "Iesire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Service_Auto_Atestat_2022.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(210, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Credits_btn
            // 
            this.Credits_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credits_btn.Location = new System.Drawing.Point(225, 403);
            this.Credits_btn.Name = "Credits_btn";
            this.Credits_btn.Size = new System.Drawing.Size(389, 80);
            this.Credits_btn.TabIndex = 2;
            this.Credits_btn.Text = "Credite";
            this.Credits_btn.UseVisualStyleBackColor = true;
            this.Credits_btn.Click += new System.EventHandler(this.Credits_btn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(811, 613);
            this.Controls.Add(this.Credits_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.program_btn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button program_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Credits_btn;
    }
}

