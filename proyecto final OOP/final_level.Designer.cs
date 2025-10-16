namespace proyecto_final_OOP
{
    partial class final_level
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(final_level));
            this.pregunta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.escape = new System.Windows.Forms.Button();
            this.tablon_imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablon_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pregunta
            // 
            this.pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregunta.Location = new System.Drawing.Point(12, 388);
            this.pregunta.Name = "pregunta";
            this.pregunta.Size = new System.Drawing.Size(858, 37);
            this.pregunta.TabIndex = 1;
            this.pregunta.Text = "label1";
            this.pregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(44, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 134);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clk);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(461, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 134);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clk);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(44, 602);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(372, 139);
            this.button3.TabIndex = 2;
            this.button3.Tag = "3";
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clk);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(461, 602);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(342, 139);
            this.button4.TabIndex = 2;
            this.button4.Tag = "4";
            this.button4.Text = "button1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.clk);
            // 
            // escape
            // 
            this.escape.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escape.Location = new System.Drawing.Point(839, 713);
            this.escape.Name = "escape";
            this.escape.Size = new System.Drawing.Size(41, 37);
            this.escape.TabIndex = 2;
            this.escape.Tag = "";
            this.escape.Text = "esc";
            this.escape.UseVisualStyleBackColor = true;
            this.escape.Click += new System.EventHandler(this.esc);
            // 
            // tablon_imagen
            // 
            this.tablon_imagen.Image = ((System.Drawing.Image)(resources.GetObject("tablon_imagen.Image")));
            this.tablon_imagen.Location = new System.Drawing.Point(12, 12);
            this.tablon_imagen.Name = "tablon_imagen";
            this.tablon_imagen.Size = new System.Drawing.Size(858, 373);
            this.tablon_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tablon_imagen.TabIndex = 0;
            this.tablon_imagen.TabStop = false;
            // 
            // final_level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 753);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.escape);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pregunta);
            this.Controls.Add(this.tablon_imagen);
            this.Name = "final_level";
            this.Text = "final_level";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.xit);
            this.Load += new System.EventHandler(this.final_level_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablon_imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox tablon_imagen;
        private System.Windows.Forms.Label pregunta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button escape;
    }
}