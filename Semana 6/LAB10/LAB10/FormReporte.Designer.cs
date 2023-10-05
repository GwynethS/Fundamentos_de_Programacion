namespace LAB10
{
    partial class FormReporte
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
            listViewRutas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewBuses = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            txtConductor = new TextBox();
            label3 = new Label();
            btnSalir = new Button();
            btnBusesRutaMasLarga = new Button();
            btnBusesMenosRutas = new Button();
            btnRutasPorConductor = new Button();
            SuspendLayout();
            // 
            // listViewRutas
            // 
            listViewRutas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewRutas.Location = new Point(349, 217);
            listViewRutas.Name = "listViewRutas";
            listViewRutas.Size = new Size(439, 203);
            listViewRutas.TabIndex = 11;
            listViewRutas.UseCompatibleStateImageBehavior = false;
            listViewRutas.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Origen";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Destino";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kilómetros";
            columnHeader4.Width = 100;
            // 
            // listViewBuses
            // 
            listViewBuses.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7 });
            listViewBuses.Location = new Point(349, 24);
            listViewBuses.Name = "listViewBuses";
            listViewBuses.Size = new Size(439, 178);
            listViewBuses.TabIndex = 12;
            listViewBuses.UseCompatibleStateImageBehavior = false;
            listViewBuses.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Matrícula";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Tipo";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Conductor";
            columnHeader7.Width = 100;
            // 
            // txtConductor
            // 
            txtConductor.Location = new Point(108, 237);
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(194, 27);
            txtConductor.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 237);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 13;
            label3.Text = "Conductor:";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(127, 372);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnBusesRutaMasLarga
            // 
            btnBusesRutaMasLarga.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusesRutaMasLarga.Location = new Point(49, 57);
            btnBusesRutaMasLarga.Name = "btnBusesRutaMasLarga";
            btnBusesRutaMasLarga.Size = new Size(239, 29);
            btnBusesRutaMasLarga.TabIndex = 16;
            btnBusesRutaMasLarga.Text = "Buscar buses con ruta más larga";
            btnBusesRutaMasLarga.UseVisualStyleBackColor = true;
            btnBusesRutaMasLarga.Click += btnBusesRutaMasLarga_Click;
            // 
            // btnBusesMenosRutas
            // 
            btnBusesMenosRutas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBusesMenosRutas.Location = new Point(49, 120);
            btnBusesMenosRutas.Name = "btnBusesMenosRutas";
            btnBusesMenosRutas.Size = new Size(239, 29);
            btnBusesMenosRutas.TabIndex = 17;
            btnBusesMenosRutas.Text = "Buscar buses con menos rutas";
            btnBusesMenosRutas.UseVisualStyleBackColor = true;
            btnBusesMenosRutas.Click += btnBusesMenosRutas_Click;
            // 
            // btnRutasPorConductor
            // 
            btnRutasPorConductor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRutasPorConductor.Location = new Point(49, 282);
            btnRutasPorConductor.Name = "btnRutasPorConductor";
            btnRutasPorConductor.Size = new Size(239, 55);
            btnRutasPorConductor.TabIndex = 18;
            btnRutasPorConductor.Text = "Buscar rutas por conductor de bus";
            btnRutasPorConductor.UseVisualStyleBackColor = true;
            btnRutasPorConductor.Click += btnRutasPorConductor_Click;
            // 
            // FormReporte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRutasPorConductor);
            Controls.Add(btnBusesMenosRutas);
            Controls.Add(btnBusesRutaMasLarga);
            Controls.Add(btnSalir);
            Controls.Add(txtConductor);
            Controls.Add(label3);
            Controls.Add(listViewBuses);
            Controls.Add(listViewRutas);
            Name = "FormReporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewRutas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewBuses;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private TextBox txtConductor;
        private Label label3;
        private Button btnSalir;
        private Button btnBusesRutaMasLarga;
        private Button btnBusesMenosRutas;
        private Button btnRutasPorConductor;
    }
}