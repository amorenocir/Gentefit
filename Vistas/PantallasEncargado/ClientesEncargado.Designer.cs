namespace Gentefit.Vistas.PantallasEncargado
{
    partial class ClientesEncargado
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            BotonVolver = new Button();
            Actividades = new Label();
            PanelClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PanelClientes).BeginInit();
            SuspendLayout();
            // 
            // BotonVolver
            // 
            BotonVolver.Location = new Point(766, 519);
            BotonVolver.Margin = new Padding(3, 4, 3, 4);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(86, 31);
            BotonVolver.TabIndex = 19;
            BotonVolver.Text = "Volver";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Actividades.ForeColor = Color.DarkSlateGray;
            Actividades.Location = new Point(269, 43);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(410, 46);
            Actividades.TabIndex = 18;
            Actividades.Text = "CLIENTES REGISTRADOS";
            // 
            // PanelClientes
            // 
            PanelClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClientes.Location = new Point(65, 118);
            PanelClientes.Margin = new Padding(3, 4, 3, 4);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.RowHeadersWidth = 51;
            PanelClientes.Size = new Size(786, 380);
            PanelClientes.TabIndex = 17;
            // 
            // ClientesEncargado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 593);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(PanelClientes);
            Name = "ClientesEncargado";
            Text = "ClientesEncargado";
            ((System.ComponentModel.ISupportInitialize)PanelClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button BotonVolver;
        private Label Actividades;
        private DataGridView PanelClientes;
    }
}