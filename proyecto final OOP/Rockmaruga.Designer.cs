namespace proyecto_final_OOP
{
    partial class Rockmaruga
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
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Arriba = new System.Windows.Forms.Timer(this.components);
            this.Abajo = new System.Windows.Forms.Timer(this.components);
            this.Izquierda = new System.Windows.Forms.Timer(this.components);
            this.Derecha = new System.Windows.Forms.Timer(this.components);
            this.Bullet_time = new System.Windows.Forms.Timer(this.components);
            this.netnavi_time = new System.Windows.Forms.Timer(this.components);
            this.Rock = new System.Windows.Forms.PictureBox();
            this.netnavi_BulletTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Reintentar = new System.Windows.Forms.Button();
            this.lvl = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).BeginInit();
            this.SuspendLayout();
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Interval = 10;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Arriba
            // 
            this.Arriba.Interval = 5;
            this.Arriba.Tick += new System.EventHandler(this.Arriba_Tick);
            // 
            // Abajo
            // 
            this.Abajo.Interval = 5;
            this.Abajo.Tick += new System.EventHandler(this.Abajo_Tick);
            // 
            // Izquierda
            // 
            this.Izquierda.Interval = 5;
            this.Izquierda.Tick += new System.EventHandler(this.Izquierda_Tick);
            // 
            // Derecha
            // 
            this.Derecha.Interval = 5;
            this.Derecha.Tick += new System.EventHandler(this.Derecha_Tick);
            // 
            // Bullet_time
            // 
            this.Bullet_time.Enabled = true;
            this.Bullet_time.Interval = 20;
            this.Bullet_time.Tick += new System.EventHandler(this.Bullet_time_Tick);
            // 
            // netnavi_time
            // 
            this.netnavi_time.Enabled = true;
            this.netnavi_time.Tick += new System.EventHandler(this.netnavi_time_Tick);
            // 
            // Rock
            // 
            this.Rock.BackColor = System.Drawing.Color.Transparent;
            this.Rock.Image = global::proyecto_final_OOP.Properties.Resources.RockRK;
            this.Rock.Location = new System.Drawing.Point(205, 668);
            this.Rock.Name = "Rock";
            this.Rock.Size = new System.Drawing.Size(40, 75);
            this.Rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Rock.TabIndex = 1;
            this.Rock.TabStop = false;
            // 
            // netnavi_BulletTime
            // 
            this.netnavi_BulletTime.Enabled = true;
            this.netnavi_BulletTime.Interval = 20;
            this.netnavi_BulletTime.Tick += new System.EventHandler(this.netnavi_BulletTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Reintentar
            // 
            this.Reintentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reintentar.Location = new System.Drawing.Point(145, 303);
            this.Reintentar.Name = "Reintentar";
            this.Reintentar.Size = new System.Drawing.Size(182, 73);
            this.Reintentar.TabIndex = 3;
            this.Reintentar.Text = "Reintentar";
            this.Reintentar.UseVisualStyleBackColor = true;
            this.Reintentar.Visible = false;
            this.Reintentar.Click += new System.EventHandler(this.Reintentar_Click);
            // 
            // lvl
            // 
            this.lvl.AutoSize = true;
            this.lvl.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvl.Location = new System.Drawing.Point(379, 47);
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(92, 34);
            this.lvl.TabIndex = 4;
            this.lvl.Text = "Course 1";
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(12, 12);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 5;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Visible = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Rockmaruga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.Reintentar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rock);
            this.Name = "Rockmaruga";
            this.Text = "Rockmaruga";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Cerrar);
            this.Load += new System.EventHandler(this.Rockmaruga_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Rockmaruga_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Rockmaruga_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Rock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Tiempo;
        private System.Windows.Forms.PictureBox Rock;
        private System.Windows.Forms.Timer Arriba;
        private System.Windows.Forms.Timer Abajo;
        private System.Windows.Forms.Timer Izquierda;
        private System.Windows.Forms.Timer Derecha;
        private System.Windows.Forms.Timer Bullet_time;
        private System.Windows.Forms.Timer netnavi_time;
        private System.Windows.Forms.Timer netnavi_BulletTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reintentar;
        private System.Windows.Forms.Label lvl;
        private System.Windows.Forms.Button salir;
    }
}