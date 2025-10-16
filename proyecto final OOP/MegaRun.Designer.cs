namespace proyecto_final_OOP
{
    partial class MegaRun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MegaRun));
            this.label1 = new System.Windows.Forms.Label();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Bullet_time = new System.Windows.Forms.Timer(this.components);
            this.Menu = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.instrucciones2 = new System.Windows.Forms.Label();
            this.Instrucciones1 = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Rock = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Interval = 20;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Bullet_time
            // 
            this.Bullet_time.Enabled = true;
            this.Bullet_time.Interval = 20;
            this.Bullet_time.Tick += new System.EventHandler(this.Bullet_time_Tick);
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.Start);
            this.Menu.Controls.Add(this.instrucciones2);
            this.Menu.Controls.Add(this.Instrucciones1);
            this.Menu.Controls.Add(this.titulo);
            this.Menu.Location = new System.Drawing.Point(206, 29);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(386, 385);
            this.Menu.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(146, 181);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(103, 68);
            this.Start.TabIndex = 2;
            this.Start.Text = "Iniciar Juego";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // instrucciones2
            // 
            this.instrucciones2.AutoSize = true;
            this.instrucciones2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrucciones2.Location = new System.Drawing.Point(83, 296);
            this.instrucciones2.Name = "instrucciones2";
            this.instrucciones2.Size = new System.Drawing.Size(210, 26);
            this.instrucciones2.TabIndex = 1;
            this.instrucciones2.Text = "y enter para disparar";
            // 
            // Instrucciones1
            // 
            this.Instrucciones1.AutoSize = true;
            this.Instrucciones1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instrucciones1.Location = new System.Drawing.Point(70, 270);
            this.Instrucciones1.Name = "Instrucciones1";
            this.Instrucciones1.Size = new System.Drawing.Size(265, 26);
            this.Instrucciones1.TabIndex = 1;
            this.Instrucciones1.Text = "Presione space para saltar ";
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(115, 46);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(165, 37);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Mega-Run";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Lime;
            this.pictureBox5.Location = new System.Drawing.Point(656, 368);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 50);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "enemigo";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox4.Location = new System.Drawing.Point(753, 368);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 50);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "boss";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(422, 418);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 34);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "vacio";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::proyecto_final_OOP.Properties.Resources.nmy2RK;
            this.pictureBox2.Location = new System.Drawing.Point(581, 384);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstaculo";
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.Transparent;
            this.Rock.Image = global::proyecto_final_OOP.Properties.Resources.rock_r;
            this.Rock.Location = new System.Drawing.Point(117, 368);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(29, 50);
            this.Rock.TabIndex = 1;
            this.Rock.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-7, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MegaRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(798, 442);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Rock);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MegaRun";
            this.Text = "MegaRun";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MegaRun_FormClosed);
            this.Load += new System.EventHandler(this.MegaRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.k_d);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.k_u);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.Timer Bullet_time;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label instrucciones2;
        private System.Windows.Forms.Label Instrucciones1;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button exit;
    }
}