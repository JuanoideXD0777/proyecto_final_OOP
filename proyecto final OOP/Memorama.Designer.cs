namespace proyecto_final_OOP
{
    partial class Memorama
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
            this.Juego = new System.Windows.Forms.Panel();
            this.Inicio = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Juego
            // 
            this.Juego.Location = new System.Drawing.Point(12, 12);
            this.Juego.Name = "Juego";
            this.Juego.Size = new System.Drawing.Size(550, 426);
            this.Juego.TabIndex = 0;
            // 
            // Inicio
            // 
            this.Inicio.Location = new System.Drawing.Point(655, 276);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(118, 41);
            this.Inicio.TabIndex = 1;
            this.Inicio.Text = "Iniciar/Reiniciar";
            this.Inicio.UseVisualStyleBackColor = true;
            this.Inicio.Click += new System.EventHandler(this.Inicio_Click);
            // 
            // Record
            // 
            this.Record.AutoSize = true;
            this.Record.Location = new System.Drawing.Point(668, 80);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(44, 16);
            this.Record.TabIndex = 2;
            this.Record.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.virar);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(713, 415);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 3;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Memorama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Inicio);
            this.Controls.Add(this.Juego);
            this.Name = "Memorama";
            this.Text = "Memorama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.close);
            this.Load += new System.EventHandler(this.Memorama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Juego;
        private System.Windows.Forms.Button Inicio;
        private System.Windows.Forms.Label Record;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button salir;
    }
}