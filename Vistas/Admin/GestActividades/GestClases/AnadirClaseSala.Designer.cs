namespace Gentefit.Vistas.Admin.GestActividades.GestClases
{
    partial class AnadirClaseSala
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
            EliminarClientes = new Label();
            BotonCancelar = new Button();
            BotonSeleccionar = new Button();
            PanelSalas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelSalas).BeginInit();
            SuspendLayout();
            // 
            // EliminarClientes
            // 
            EliminarClientes.AutoSize = true;
            EliminarClientes.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            EliminarClientes.ForeColor = Color.DarkSlateGray;
            EliminarClientes.Location = new Point(69, 45);
            EliminarClientes.Name = "EliminarClientes";
            EliminarClientes.Size = new Size(372, 37);
            EliminarClientes.TabIndex = 65;
            EliminarClientes.Text = "ESCOGER SALA DISPONIBLE";
            // 
            // BotonCancelar
            // 
            BotonCancelar.Location = new Point(661, 372);
            BotonCancelar.Name = "BotonCancelar";
            BotonCancelar.Size = new Size(71, 34);
            BotonCancelar.TabIndex = 63;
            BotonCancelar.Text = "Cancelar";
            BotonCancelar.UseVisualStyleBackColor = true;
            BotonCancelar.Click += BotonCancelar_Click;
            // 
            // BotonSeleccionar
            // 
            BotonSeleccionar.BackColor = Color.DarkOrange;
            BotonSeleccionar.Location = new Point(563, 372);
            BotonSeleccionar.Name = "BotonSeleccionar";
            BotonSeleccionar.Size = new Size(85, 34);
            BotonSeleccionar.TabIndex = 62;
            BotonSeleccionar.Text = "Seleccionar";
            BotonSeleccionar.UseVisualStyleBackColor = false;
            BotonSeleccionar.Click += BotonSeleccionar_Click;
            // 
            // PanelSalas
            // 
            PanelSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelSalas.Location = new Point(69, 122);
            PanelSalas.Name = "PanelSalas";
            PanelSalas.Size = new Size(662, 244);
            PanelSalas.TabIndex = 59;
            PanelSalas.SelectionChanged += PanelSalas_SelectionChanged;
            // 
            // AnadirClaseSala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EliminarClientes);
            Controls.Add(BotonCancelar);
            Controls.Add(BotonSeleccionar);
            Controls.Add(PanelSalas);
            Name = "AnadirClaseSala";
            Text = "AnadirClaseSala";
            Load += AnadirClaseSala_Load;
            ((System.ComponentModel.ISupportInitialize)PanelSalas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EliminarClientes;
        private Button BotonCancelar;
        private Button BotonSeleccionar;
        private DataGridView PanelSalas;
    }
}