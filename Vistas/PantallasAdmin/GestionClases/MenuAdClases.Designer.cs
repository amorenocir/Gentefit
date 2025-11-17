namespace Gentefit.Vistas.PantallasAdmin
{
    partial class MenuAdClases
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
            BotonAnadir = new Button();
            BotonListar = new Button();
            BotonModificar = new Button();
            BotonEliminar = new Button();
            BotonVolver = new Button();
            Titulo = new Label();
            SuspendLayout();
            // 
            // BotonAnadir
            // 
            BotonAnadir.BackColor = Color.DarkOrange;
            BotonAnadir.Location = new Point(142, 258);
            BotonAnadir.Margin = new Padding(3, 4, 3, 4);
            BotonAnadir.Name = "BotonAnadir";
            BotonAnadir.Size = new Size(125, 55);
            BotonAnadir.TabIndex = 1;
            BotonAnadir.Text = "Añadir clase";
            BotonAnadir.UseVisualStyleBackColor = false;
            BotonAnadir.Click += BotonAnadir_Click;
            // 
            // BotonListar
            // 
            BotonListar.BackColor = Color.DarkOrange;
            BotonListar.Location = new Point(307, 258);
            BotonListar.Margin = new Padding(3, 4, 3, 4);
            BotonListar.Name = "BotonListar";
            BotonListar.Size = new Size(125, 55);
            BotonListar.TabIndex = 2;
            BotonListar.Text = "Listar clases";
            BotonListar.UseVisualStyleBackColor = false;
            BotonListar.Click += BotonListar_Click;
            // 
            // BotonModificar
            // 
            BotonModificar.BackColor = Color.DarkOrange;
            BotonModificar.Location = new Point(473, 258);
            BotonModificar.Margin = new Padding(3, 4, 3, 4);
            BotonModificar.Name = "BotonModificar";
            BotonModificar.Size = new Size(125, 55);
            BotonModificar.TabIndex = 3;
            BotonModificar.Text = "Modificar clases";
            BotonModificar.UseVisualStyleBackColor = false;
            BotonModificar.Click += BotonModificar_Click;
            // 
            // BotonEliminar
            // 
            BotonEliminar.BackColor = Color.DarkOrange;
            BotonEliminar.Location = new Point(633, 258);
            BotonEliminar.Margin = new Padding(3, 4, 3, 4);
            BotonEliminar.Name = "BotonEliminar";
            BotonEliminar.Size = new Size(125, 55);
            BotonEliminar.TabIndex = 4;
            BotonEliminar.Text = "Eliminar clases";
            BotonEliminar.UseVisualStyleBackColor = false;
            BotonEliminar.Click += BotonEliminar_Click;
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(661, 480);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 5;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Titulo.ForeColor = Color.DarkSlateGray;
            Titulo.Location = new Point(40, 48);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(345, 46);
            Titulo.TabIndex = 19;
            Titulo.Text = "GESTIÓN DE CLASES";
            Titulo.Click += Titulo_Click;
            // 
            // MenuAdClases
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(Titulo);
            Controls.Add(BotonVolver);
            Controls.Add(BotonEliminar);
            Controls.Add(BotonModificar);
            Controls.Add(BotonListar);
            Controls.Add(BotonAnadir);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuAdClases";
            Text = "MenuAdClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BotonAnadir;
        private Button BotonListar;
        private Button BotonModificar;
        private Button BotonEliminar;
        private Button BotonVolver;
        private Label Titulo;
    }
}