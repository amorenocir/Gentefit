namespace Gentefit.Vistas.Admin
{
    partial class MenuAdActividades
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
            Logo = new PictureBox();
            BotonBodyPump = new Button();
            Actividades = new Label();
            BotonBodyCombat = new Button();
            BotonYoga = new Button();
            BotonCore = new Button();
            BotonZumba = new Button();
            BotonSpinning = new Button();
            ImagenAnadir = new PictureBox();
            BotonVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImagenAnadir).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.LogoAdmin;
            Logo.Location = new Point(327, 24);
            Logo.Name = "Logo";
            Logo.Size = new Size(155, 85);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // BotonBodyPump
            // 
            BotonBodyPump.BackColor = Color.DarkOrange;
            BotonBodyPump.ForeColor = Color.White;
            BotonBodyPump.Location = new Point(212, 199);
            BotonBodyPump.Name = "BotonBodyPump";
            BotonBodyPump.Size = new Size(115, 49);
            BotonBodyPump.TabIndex = 4;
            BotonBodyPump.Text = "Body Pump";
            BotonBodyPump.UseVisualStyleBackColor = false;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Actividades.ForeColor = Color.DarkSlateGray;
            Actividades.Location = new Point(311, 141);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(193, 37);
            Actividades.TabIndex = 5;
            Actividades.Text = "ACTIVIDADES";
            Actividades.Click += Actividades_Click;
            // 
            // BotonBodyCombat
            // 
            BotonBodyCombat.BackColor = Color.DarkOrange;
            BotonBodyCombat.ForeColor = Color.White;
            BotonBodyCombat.Location = new Point(212, 271);
            BotonBodyCombat.Name = "BotonBodyCombat";
            BotonBodyCombat.Size = new Size(115, 49);
            BotonBodyCombat.TabIndex = 6;
            BotonBodyCombat.Text = "Body Combat";
            BotonBodyCombat.UseVisualStyleBackColor = false;
            BotonBodyCombat.Click += BotonBodyCombat_Click;
            // 
            // BotonYoga
            // 
            BotonYoga.BackColor = Color.DarkOrange;
            BotonYoga.ForeColor = Color.White;
            BotonYoga.Location = new Point(349, 271);
            BotonYoga.Name = "BotonYoga";
            BotonYoga.Size = new Size(115, 49);
            BotonYoga.TabIndex = 8;
            BotonYoga.Text = "Yoga";
            BotonYoga.UseVisualStyleBackColor = false;
            BotonYoga.Click += BotonYoga_Click;
            // 
            // BotonCore
            // 
            BotonCore.BackColor = Color.DarkOrange;
            BotonCore.ForeColor = Color.White;
            BotonCore.Location = new Point(349, 199);
            BotonCore.Name = "BotonCore";
            BotonCore.Size = new Size(115, 49);
            BotonCore.TabIndex = 7;
            BotonCore.Text = "Core";
            BotonCore.UseVisualStyleBackColor = false;
            BotonCore.Click += BotonCore_Click;
            // 
            // BotonZumba
            // 
            BotonZumba.BackColor = Color.DarkOrange;
            BotonZumba.ForeColor = Color.White;
            BotonZumba.Location = new Point(487, 271);
            BotonZumba.Name = "BotonZumba";
            BotonZumba.Size = new Size(115, 49);
            BotonZumba.TabIndex = 10;
            BotonZumba.Text = "Zumba";
            BotonZumba.UseVisualStyleBackColor = false;
            BotonZumba.Click += BotonZumba_Click;
            // 
            // BotonSpinning
            // 
            BotonSpinning.BackColor = Color.DarkOrange;
            BotonSpinning.ForeColor = Color.White;
            BotonSpinning.Location = new Point(487, 199);
            BotonSpinning.Name = "BotonSpinning";
            BotonSpinning.Size = new Size(115, 49);
            BotonSpinning.TabIndex = 9;
            BotonSpinning.Text = "Spinning";
            BotonSpinning.UseVisualStyleBackColor = false;
            BotonSpinning.Click += BotonSpinning_Click;
            // 
            // ImagenAnadir
            // 
            ImagenAnadir.Image = Properties.Resources.Añadir1;
            ImagenAnadir.Location = new Point(505, 146);
            ImagenAnadir.Name = "ImagenAnadir";
            ImagenAnadir.Size = new Size(28, 28);
            ImagenAnadir.SizeMode = PictureBoxSizeMode.Zoom;
            ImagenAnadir.TabIndex = 11;
            ImagenAnadir.TabStop = false;
            ImagenAnadir.Click += ImagenAnadir_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(612, 379);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 12;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // MenuAdActividades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BotonVolver);
            Controls.Add(ImagenAnadir);
            Controls.Add(BotonZumba);
            Controls.Add(BotonSpinning);
            Controls.Add(BotonYoga);
            Controls.Add(BotonCore);
            Controls.Add(BotonBodyCombat);
            Controls.Add(Actividades);
            Controls.Add(BotonBodyPump);
            Controls.Add(Logo);
            Name = "MenuAdActividades";
            Text = "MenuAdActividades";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImagenAnadir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Button BotonBodyPump;
        private Label Actividades;
        private Button BotonBodyCombat;
        private Button BotonYoga;
        private Button BotonCore;
        private Button BotonZumba;
        private Button BotonSpinning;
        private PictureBox ImagenAnadir;
        private Button BotonVolver;
    }
}