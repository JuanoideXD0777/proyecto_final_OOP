namespace proyecto_final_OOP
{
    partial class Acerca_De
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acerca_De));
            this.Usr = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.Score_GRID = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Score_GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // Usr
            // 
            this.Usr.AutoSize = true;
            this.Usr.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Usr.Location = new System.Drawing.Point(12, 33);
            this.Usr.Name = "Usr";
            this.Usr.Size = new System.Drawing.Size(86, 16);
            this.Usr.TabIndex = 0;
            this.Usr.Text = "desconocido";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Impact", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(138, 67);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(198, 37);
            this.Score.TabIndex = 0;
            this.Score.Text = "Puntaje total: ";
            // 
            // Score_GRID
            // 
            this.Score_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Score_GRID.Location = new System.Drawing.Point(57, 179);
            this.Score_GRID.Name = "Score_GRID";
            this.Score_GRID.RowHeadersWidth = 51;
            this.Score_GRID.RowTemplate.Height = 24;
            this.Score_GRID.Size = new System.Drawing.Size(516, 259);
            this.Score_GRID.TabIndex = 1;
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(706, 405);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 25);
            this.back.TabIndex = 2;
            this.back.Text = "regresar a inicio";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Acerca_De
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Score_GRID);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Usr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Acerca_De";
            this.Text = "Acerca_De";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.close);
            this.Load += new System.EventHandler(this.Acerca_De_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Score_GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usr;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.DataGridView Score_GRID;
        private System.Windows.Forms.Button back;
    }
}