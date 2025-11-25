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
            BotonVolver.Location = new Point(670, 389);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(75, 23);
            BotonVolver.TabIndex = 19;
            BotonVolver.Text = "Salir";
            BotonVolver.UseVisualStyleBackColor = true;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // Actividades
            // 
            Actividades.AutoSize = true;
            Actividades.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Actividades.ForeColor = Color.DarkSlateGray;
            Actividades.Location = new Point(235, 32);
            Actividades.Name = "Actividades";
            Actividades.Size = new Size(327, 37);
            Actividades.TabIndex = 18;
            Actividades.Text = "CLIENTES REGISTRADOS";
            // 
            // PanelClientes
            // 
            PanelClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PanelClientes.Location = new Point(57, 88);
            PanelClientes.Name = "PanelClientes";
            PanelClientes.RowHeadersWidth = 51;
            PanelClientes.Size = new Size(688, 285);
            PanelClientes.TabIndex = 17;
            // 
            // ClientesEncargado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 445);
            Controls.Add(BotonVolver);
            Controls.Add(Actividades);
            Controls.Add(PanelClientes);
            Margin = new Padding(3, 2, 3, 2);
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