namespace LAB10
{
    partial class FormBus
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMatricula = new TextBox();
            cbTipo = new ComboBox();
            txtConductor = new TextBox();
            listViewBuses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnRegistrar = new Button();
            btnVerRutas = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 37);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Matrícula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(100, 95);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 142);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 2;
            label3.Text = "Conductor:";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(149, 30);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(194, 27);
            txtMatricula.TabIndex = 3;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(149, 92);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(194, 28);
            cbTipo.TabIndex = 4;
            // 
            // txtConductor
            // 
            txtConductor.Location = new Point(149, 142);
            txtConductor.Name = "txtConductor";
            txtConductor.Size = new Size(194, 27);
            txtConductor.TabIndex = 5;
            // 
            // listViewBuses
            // 
            listViewBuses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewBuses.Location = new Point(375, 30);
            listViewBuses.Name = "listViewBuses";
            listViewBuses.Size = new Size(398, 390);
            listViewBuses.TabIndex = 6;
            listViewBuses.UseCompatibleStateImageBehavior = false;
            listViewBuses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Matrícula";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Conductor";
            columnHeader3.Width = 100;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(148, 235);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerRutas
            // 
            btnVerRutas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerRutas.Location = new Point(149, 279);
            btnVerRutas.Name = "btnVerRutas";
            btnVerRutas.Size = new Size(94, 29);
            btnVerRutas.TabIndex = 8;
            btnVerRutas.Text = "Ver Rutas";
            btnVerRutas.UseVisualStyleBackColor = true;
            btnVerRutas.Click += btnVerRutas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.Location = new Point(149, 327);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 29);
            btnReportes.TabIndex = 9;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(148, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormBus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnVerRutas);
            Controls.Add(btnRegistrar);
            Controls.Add(listViewBuses);
            Controls.Add(txtConductor);
            Controls.Add(cbTipo);
            Controls.Add(txtMatricula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormBus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormBus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMatricula;
        private ComboBox cbTipo;
        private TextBox txtConductor;
        private ListView listViewBuses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnRegistrar;
        private Button btnVerRutas;
        private Button btnReportes;
        private Button btnSalir;
    }
}