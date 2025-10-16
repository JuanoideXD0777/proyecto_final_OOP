namespace proyecto_final_OOP
{
    partial class Nivel0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel0));
            this.Game_Time = new System.Windows.Forms.Timer(this.components);
            this.MU = new System.Windows.Forms.PictureBox();
            this.Nivel_2 = new System.Windows.Forms.PictureBox();
            this.Nivel_5 = new System.Windows.Forms.PictureBox();
            this.Nivel_1 = new System.Windows.Forms.PictureBox();
            this.Nivel_4 = new System.Windows.Forms.PictureBox();
            this.Nivel_3 = new System.Windows.Forms.PictureBox();
            this.Nivel_6 = new System.Windows.Forms.PictureBox();
            this.ecsit = new System.Windows.Forms.PictureBox();
            this.Final_boss = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecsit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Final_boss)).BeginInit();
            this.SuspendLayout();
            // 
            // Game_Time
            // 
            this.Game_Time.Enabled = true;
            this.Game_Time.Interval = 20;
            this.Game_Time.Tick += new System.EventHandler(this.Ev_Juego);
            // 
            // MU
            // 
            this.MU.BackColor = System.Drawing.Color.Transparent;
            this.MU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MU.Image = global::proyecto_final_OOP.Properties.Resources.rock_stand;
            this.MU.Location = new System.Drawing.Point(365, 359);
            this.MU.Name = "MU";
            this.MU.Size = new System.Drawing.Size(34, 50);
            this.MU.TabIndex = 0;
            this.MU.TabStop = false;
            // 
            // Nivel_2
            // 
            this.Nivel_2.BackColor = System.Drawing.Color.Transparent;
            this.Nivel_2.Image = global::proyecto_final_OOP.Properties.Resources.lvl2;
            this.Nivel_2.Location = new System.Drawing.Point(489, 352);
            this.Nivel_2.Name = "Nivel_2";
            this.Nivel_2.Size = new System.Drawing.Size(100, 57);
            this.Nivel_2.TabIndex = 0;
            this.Nivel_2.TabStop = false;
            // 
            // Nivel_5
            // 
            this.Nivel_5.BackColor = System.Drawing.Color.Transparent;
            this.Nivel_5.Image = global::proyecto_final_OOP.Properties.Resources.lvl5;
            this.Nivel_5.Location = new System.Drawing.Point(489, 53);
            this.Nivel_5.Name = "Nivel_5";
            this.Nivel_5.Size = new System.Drawing.Size(124, 62);
            this.Nivel_5.TabIndex = 0;
            this.Nivel_5.TabStop = false;
            // 
            // Nivel_1
            // 
            this.Nivel_1.BackColor = System.Drawing.Color.Transparent;
            this.Nivel_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nivel_1.Image = global::proyecto_final_OOP.Properties.Resources.lvl1;
            this.Nivel_1.Location = new System.Drawing.Point(169, 339);
            this.Nivel_1.Name = "Nivel_1";
            this.Nivel_1.Size = new System.Drawing.Size(108, 70);
            this.Nivel_1.TabIndex = 0;
            this.Nivel_1.TabStop = false;
            // 
            // Nivel_4
            // 
            this.Nivel_4.BackColor = System.Drawing.Color.Transparent;
            this.Nivel_4.Image = global::proyecto_final_OOP.Properties.Resources.lvl4;
            this.Nivel_4.Location = new System.Drawing.Point(610, 190);
            this.Nivel_4.Name = "Nivel_4";
            this.Nivel_4.Size = new System.Drawing.Size(110, 67);
            this.Nivel_4.TabIndex = 0;
            this.Nivel_4.TabStop = false;
            // 
            // Nivel_3
            // 
            this.Nivel_3.BackColor = System.Drawing.Color.Transparent;
            this.Nivel_3.Image = global::proyecto_final_OOP.Properties.Resources.lvl3;
            this.Nivel_3.Location = new System.Drawing.Point(42, 190);
            this.Nivel_3.Name = "Nivel_3";
            this.Nivel_3.Size = new System.Drawing.Size(111, 62);
            this.Nivel_3.TabIndex = 0;
            this.Nivel_3.TabStop = false;
            // 
            // Nivel_6
            // 
            this.Nivel_6.BackColor = System.Drawing.Color.Transparent;
            this.Nivel_6.Image = global::proyecto_final_OOP.Properties.Resources.lvl6;
            this.Nivel_6.Location = new System.Drawing.Point(169, 53);
            this.Nivel_6.Name = "Nivel_6";
            this.Nivel_6.Size = new System.Drawing.Size(119, 62);
            this.Nivel_6.TabIndex = 0;
            this.Nivel_6.TabStop = false;
            // 
            // ecsit
            // 
            this.ecsit.BackColor = System.Drawing.Color.Transparent;
            this.ecsit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ecsit.BackgroundImage")));
            this.ecsit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ecsit.Location = new System.Drawing.Point(739, 316);
            this.ecsit.Name = "ecsit";
            this.ecsit.Size = new System.Drawing.Size(49, 122);
            this.ecsit.TabIndex = 0;
            this.ecsit.TabStop = false;
            // 
            // Final_boss
            // 
            this.Final_boss.BackColor = System.Drawing.Color.Transparent;
            this.Final_boss.Image = global::proyecto_final_OOP.Properties.Resources.lvl7;
            this.Final_boss.Location = new System.Drawing.Point(331, 190);
            this.Final_boss.Name = "Final_boss";
            this.Final_boss.Size = new System.Drawing.Size(100, 67);
            this.Final_boss.TabIndex = 0;
            this.Final_boss.TabStop = false;
            // 
            // Nivel0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MU);
            this.Controls.Add(this.Nivel_2);
            this.Controls.Add(this.Nivel_5);
            this.Controls.Add(this.Nivel_1);
            this.Controls.Add(this.Nivel_4);
            this.Controls.Add(this.Nivel_3);
            this.Controls.Add(this.Nivel_6);
            this.Controls.Add(this.ecsit);
            this.Controls.Add(this.Final_boss);
            this.Name = "Nivel0";
            this.Text = "Hubworld";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closed);
            this.Load += new System.EventHandler(this.Nivel0_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Abajo);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Arriba);
            ((System.ComponentModel.ISupportInitialize)(this.MU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nivel_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecsit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Final_boss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Final_boss;
        private System.Windows.Forms.PictureBox Nivel_6;
        private System.Windows.Forms.PictureBox Nivel_3;
        private System.Windows.Forms.PictureBox Nivel_5;
        private System.Windows.Forms.PictureBox Nivel_1;
        private System.Windows.Forms.PictureBox Nivel_2;
        private System.Windows.Forms.PictureBox Nivel_4;
        private System.Windows.Forms.PictureBox MU;
        private System.Windows.Forms.Timer Game_Time;
        private System.Windows.Forms.PictureBox ecsit;
    }
}