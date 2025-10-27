namespace Gentefit.Test
{
    partial class TestConexion
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contrasenaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gimnasioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gimnasioNavigationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidosDataGridViewTextBoxColumn, dniDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, contrasenaDataGridViewTextBoxColumn, gimnasioDataGridViewTextBoxColumn, gimnasioNavigationDataGridViewTextBoxColumn, reservasDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clienteBindingSource;
            dataGridView1.Location = new Point(51, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1057, 417);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            contrasenaDataGridViewTextBoxColumn.DataPropertyName = "Contrasena";
            contrasenaDataGridViewTextBoxColumn.HeaderText = "Contrasena";
            contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            // 
            // gimnasioDataGridViewTextBoxColumn
            // 
            gimnasioDataGridViewTextBoxColumn.DataPropertyName = "Gimnasio";
            gimnasioDataGridViewTextBoxColumn.HeaderText = "Gimnasio";
            gimnasioDataGridViewTextBoxColumn.Name = "gimnasioDataGridViewTextBoxColumn";
            // 
            // gimnasioNavigationDataGridViewTextBoxColumn
            // 
            gimnasioNavigationDataGridViewTextBoxColumn.DataPropertyName = "GimnasioNavigation";
            gimnasioNavigationDataGridViewTextBoxColumn.HeaderText = "GimnasioNavigation";
            gimnasioNavigationDataGridViewTextBoxColumn.Name = "gimnasioNavigationDataGridViewTextBoxColumn";
            // 
            // reservasDataGridViewTextBoxColumn
            // 
            reservasDataGridViewTextBoxColumn.DataPropertyName = "Reservas";
            reservasDataGridViewTextBoxColumn.HeaderText = "Reservas";
            reservasDataGridViewTextBoxColumn.Name = "reservasDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Modelo.Cliente);
            // 
            // TestConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 533);
            Controls.Add(dataGridView1);
            Name = "TestConexion";
            Text = "TestConexion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gimnasioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gimnasioNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservasDataGridViewTextBoxColumn;
        private BindingSource clienteBindingSource;
    }
}