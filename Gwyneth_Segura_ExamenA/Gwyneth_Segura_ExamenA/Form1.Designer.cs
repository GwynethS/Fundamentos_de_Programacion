namespace Gwyneth_Segura_ExamenA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnActividadLimpiar = new Button();
            maskedTextBoxActividadHorario = new MaskedTextBox();
            btnActividadRegistrar = new Button();
            numericUpDownActividadCapacidad = new NumericUpDown();
            txtActividadNombre = new TextBox();
            txtActividadCodigo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnMiembroLimpiar = new Button();
            cbMiembroGenero = new ComboBox();
            label7 = new Label();
            btnMiembroRegistrar = new Button();
            numericUpDownMiembroEdad = new NumericUpDown();
            txtMiembroNombre = new TextBox();
            txtMiembroCodigo = new TextBox();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            listViewActividad = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewMiembro = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            panel3 = new Panel();
            maskedTextBoxFiltrarHorario = new MaskedTextBox();
            btnFiltrarActividadPorHorario = new Button();
            label12 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            cbFiltrarGenero = new ComboBox();
            btnFiltrarMiembrosPorGenero = new Button();
            label13 = new Label();
            label14 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownActividadCapacidad).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMiembroEdad).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnActividadLimpiar);
            panel1.Controls.Add(maskedTextBoxActividadHorario);
            panel1.Controls.Add(btnActividadRegistrar);
            panel1.Controls.Add(numericUpDownActividadCapacidad);
            panel1.Controls.Add(txtActividadNombre);
            panel1.Controls.Add(txtActividadCodigo);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 248);
            panel1.TabIndex = 0;
            // 
            // btnActividadLimpiar
            // 
            btnActividadLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActividadLimpiar.Location = new Point(166, 209);
            btnActividadLimpiar.Name = "btnActividadLimpiar";
            btnActividadLimpiar.Size = new Size(75, 23);
            btnActividadLimpiar.TabIndex = 13;
            btnActividadLimpiar.Text = "Limpiar";
            btnActividadLimpiar.UseVisualStyleBackColor = true;
            btnActividadLimpiar.Click += btnActividadLimpiar_Click;
            // 
            // maskedTextBoxActividadHorario
            // 
            maskedTextBoxActividadHorario.Location = new Point(99, 126);
            maskedTextBoxActividadHorario.Mask = "00:00";
            maskedTextBoxActividadHorario.Name = "maskedTextBoxActividadHorario";
            maskedTextBoxActividadHorario.Size = new Size(100, 23);
            maskedTextBoxActividadHorario.TabIndex = 12;
            maskedTextBoxActividadHorario.ValidatingType = typeof(DateTime);
            // 
            // btnActividadRegistrar
            // 
            btnActividadRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActividadRegistrar.Location = new Point(70, 209);
            btnActividadRegistrar.Name = "btnActividadRegistrar";
            btnActividadRegistrar.Size = new Size(75, 23);
            btnActividadRegistrar.TabIndex = 11;
            btnActividadRegistrar.Text = "Registrar";
            btnActividadRegistrar.UseVisualStyleBackColor = true;
            btnActividadRegistrar.Click += btnActividadRegistrar_Click;
            // 
            // numericUpDownActividadCapacidad
            // 
            numericUpDownActividadCapacidad.Location = new Point(99, 161);
            numericUpDownActividadCapacidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownActividadCapacidad.Name = "numericUpDownActividadCapacidad";
            numericUpDownActividadCapacidad.Size = new Size(67, 23);
            numericUpDownActividadCapacidad.TabIndex = 10;
            numericUpDownActividadCapacidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtActividadNombre
            // 
            txtActividadNombre.Location = new Point(99, 91);
            txtActividadNombre.Name = "txtActividadNombre";
            txtActividadNombre.Size = new Size(124, 23);
            txtActividadNombre.TabIndex = 6;
            // 
            // txtActividadCodigo
            // 
            txtActividadCodigo.Location = new Point(99, 53);
            txtActividadCodigo.Name = "txtActividadCodigo";
            txtActividadCodigo.Size = new Size(124, 23);
            txtActividadCodigo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 163);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 4;
            label5.Text = "Capacidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(43, 130);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 3;
            label4.Text = "Horario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 94);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 56);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(89, 17);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Actividades Deportivas";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMiembroLimpiar);
            panel2.Controls.Add(cbMiembroGenero);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnMiembroRegistrar);
            panel2.Controls.Add(numericUpDownMiembroEdad);
            panel2.Controls.Add(txtMiembroNombre);
            panel2.Controls.Add(txtMiembroCodigo);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(371, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(333, 248);
            panel2.TabIndex = 1;
            // 
            // btnMiembroLimpiar
            // 
            btnMiembroLimpiar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMiembroLimpiar.Location = new Point(187, 209);
            btnMiembroLimpiar.Name = "btnMiembroLimpiar";
            btnMiembroLimpiar.Size = new Size(75, 23);
            btnMiembroLimpiar.TabIndex = 14;
            btnMiembroLimpiar.Text = "Limpiar";
            btnMiembroLimpiar.UseVisualStyleBackColor = true;
            btnMiembroLimpiar.Click += btnMiembroLimpiar_Click;
            // 
            // cbMiembroGenero
            // 
            cbMiembroGenero.FormattingEnabled = true;
            cbMiembroGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cbMiembroGenero.Location = new Point(99, 160);
            cbMiembroGenero.Name = "cbMiembroGenero";
            cbMiembroGenero.Size = new Size(124, 23);
            cbMiembroGenero.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(56, 129);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 12;
            label7.Text = "Edad:";
            // 
            // btnMiembroRegistrar
            // 
            btnMiembroRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMiembroRegistrar.Location = new Point(91, 209);
            btnMiembroRegistrar.Name = "btnMiembroRegistrar";
            btnMiembroRegistrar.Size = new Size(75, 23);
            btnMiembroRegistrar.TabIndex = 11;
            btnMiembroRegistrar.Text = "Registrar";
            btnMiembroRegistrar.UseVisualStyleBackColor = true;
            btnMiembroRegistrar.Click += btnMiembroRegistrar_Click;
            // 
            // numericUpDownMiembroEdad
            // 
            numericUpDownMiembroEdad.Location = new Point(99, 127);
            numericUpDownMiembroEdad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMiembroEdad.Name = "numericUpDownMiembroEdad";
            numericUpDownMiembroEdad.Size = new Size(67, 23);
            numericUpDownMiembroEdad.TabIndex = 10;
            numericUpDownMiembroEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtMiembroNombre
            // 
            txtMiembroNombre.Location = new Point(99, 91);
            txtMiembroNombre.Name = "txtMiembroNombre";
            txtMiembroNombre.Size = new Size(124, 23);
            txtMiembroNombre.TabIndex = 6;
            // 
            // txtMiembroCodigo
            // 
            txtMiembroCodigo.Location = new Point(99, 53);
            txtMiembroCodigo.Name = "txtMiembroCodigo";
            txtMiembroCodigo.Size = new Size(124, 23);
            txtMiembroCodigo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 163);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 4;
            label6.Text = "Género:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(39, 94);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 2;
            label8.Text = "Nombre:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(44, 56);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 1;
            label9.Text = "Código:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(129, 17);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 0;
            label10.Text = "Miembros";
            // 
            // listViewActividad
            // 
            listViewActividad.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewActividad.Location = new Point(12, 278);
            listViewActividad.Name = "listViewActividad";
            listViewActividad.Size = new Size(333, 160);
            listViewActividad.TabIndex = 2;
            listViewActividad.UseCompatibleStateImageBehavior = false;
            listViewActividad.View = View.Details;
            listViewActividad.SelectedIndexChanged += listViewActividad_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Horario";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Capacidad ";
            columnHeader4.Width = 80;
            // 
            // listViewMiembro
            // 
            listViewMiembro.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listViewMiembro.Location = new Point(371, 278);
            listViewMiembro.Name = "listViewMiembro";
            listViewMiembro.Size = new Size(333, 160);
            listViewMiembro.TabIndex = 3;
            listViewMiembro.UseCompatibleStateImageBehavior = false;
            listViewMiembro.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Código";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Nombre";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Edad";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Género";
            columnHeader8.Width = 80;
            // 
            // panel3
            // 
            panel3.Controls.Add(maskedTextBoxFiltrarHorario);
            panel3.Controls.Add(btnFiltrarActividadPorHorario);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(12, 453);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 96);
            panel3.TabIndex = 4;
            // 
            // maskedTextBoxFiltrarHorario
            // 
            maskedTextBoxFiltrarHorario.Location = new Point(15, 56);
            maskedTextBoxFiltrarHorario.Mask = "00:00";
            maskedTextBoxFiltrarHorario.Name = "maskedTextBoxFiltrarHorario";
            maskedTextBoxFiltrarHorario.Size = new Size(100, 23);
            maskedTextBoxFiltrarHorario.TabIndex = 13;
            maskedTextBoxFiltrarHorario.ValidatingType = typeof(DateTime);
            // 
            // btnFiltrarActividadPorHorario
            // 
            btnFiltrarActividadPorHorario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrarActividadPorHorario.Location = new Point(129, 56);
            btnFiltrarActividadPorHorario.Name = "btnFiltrarActividadPorHorario";
            btnFiltrarActividadPorHorario.Size = new Size(75, 23);
            btnFiltrarActividadPorHorario.TabIndex = 12;
            btnFiltrarActividadPorHorario.Text = "Filtrar";
            btnFiltrarActividadPorHorario.UseVisualStyleBackColor = true;
            btnFiltrarActividadPorHorario.Click += btnFiltrarActividadPorHorario_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 38);
            label12.Name = "label12";
            label12.Size = new Size(103, 15);
            label12.TabIndex = 3;
            label12.Text = "Ingrese un horario";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(12, 11);
            label11.Name = "label11";
            label11.Size = new Size(164, 15);
            label11.TabIndex = 2;
            label11.Text = "Filtrar actividades por horario:";
            // 
            // panel4
            // 
            panel4.Controls.Add(cbFiltrarGenero);
            panel4.Controls.Add(btnFiltrarMiembrosPorGenero);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Location = new Point(371, 453);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 96);
            panel4.TabIndex = 5;
            // 
            // cbFiltrarGenero
            // 
            cbFiltrarGenero.FormattingEnabled = true;
            cbFiltrarGenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otro" });
            cbFiltrarGenero.Location = new Point(17, 61);
            cbFiltrarGenero.Name = "cbFiltrarGenero";
            cbFiltrarGenero.Size = new Size(124, 23);
            cbFiltrarGenero.TabIndex = 14;
            // 
            // btnFiltrarMiembrosPorGenero
            // 
            btnFiltrarMiembrosPorGenero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFiltrarMiembrosPorGenero.Location = new Point(148, 61);
            btnFiltrarMiembrosPorGenero.Name = "btnFiltrarMiembrosPorGenero";
            btnFiltrarMiembrosPorGenero.Size = new Size(75, 23);
            btnFiltrarMiembrosPorGenero.TabIndex = 12;
            btnFiltrarMiembrosPorGenero.Text = "Filtrar";
            btnFiltrarMiembrosPorGenero.UseVisualStyleBackColor = true;
            btnFiltrarMiembrosPorGenero.Click += btnFiltrarMiembrosPorGenero_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(12, 38);
            label13.Name = "label13";
            label13.Size = new Size(129, 15);
            label13.TabIndex = 3;
            label13.Text = "Seleccione una opción:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(12, 11);
            label14.Name = "label14";
            label14.Size = new Size(158, 15);
            label14.TabIndex = 2;
            label14.Text = "Filtrar miembros por género:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 561);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(listViewMiembro);
            Controls.Add(listViewActividad);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownActividadCapacidad).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMiembroEdad).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtActividadNombre;
        private TextBox txtActividadCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownActividadCapacidad;
        private Button btnActividadRegistrar;
        private Panel panel2;
        private ComboBox cbMiembroGenero;
        private Label label7;
        private Button btnMiembroRegistrar;
        private NumericUpDown numericUpDownMiembroEdad;
        private TextBox txtMiembroNombre;
        private TextBox txtMiembroCodigo;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListView listViewActividad;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView listViewMiembro;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Panel panel3;
        private Button btnFiltrarActividadPorHorario;
        private Label label12;
        private Label label11;
        private Panel panel4;
        private ComboBox cbFiltrarGenero;
        private Button btnFiltrarMiembrosPorGenero;
        private Label label13;
        private Label label14;
        private MaskedTextBox maskedTextBoxActividadHorario;
        private MaskedTextBox maskedTextBoxFiltrarHorario;
        private Button btnActividadLimpiar;
        private Button btnMiembroLimpiar;
    }
}