namespace LAB11
{
    partial class FormEstacionamiento
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
            panel1 = new Panel();
            btnIngresar = new Button();
            txtIngresoDuenio = new TextBox();
            txtIngresoMatricula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnSalir = new Button();
            txtSalidaMatricula = new TextBox();
            label5 = new Label();
            label6 = new Label();
            listViewEstacionamiento = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtIngresoDuenio);
            panel1.Controls.Add(txtIngresoMatricula);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(30, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 213);
            panel1.TabIndex = 0;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(126, 167);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(94, 29);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtIngresoDuenio
            // 
            txtIngresoDuenio.Location = new Point(103, 115);
            txtIngresoDuenio.Name = "txtIngresoDuenio";
            txtIngresoDuenio.Size = new Size(173, 27);
            txtIngresoDuenio.TabIndex = 4;
            // 
            // txtIngresoMatricula
            // 
            txtIngresoMatricula.Location = new Point(103, 67);
            txtIngresoMatricula.Name = "txtIngresoMatricula";
            txtIngresoMatricula.Size = new Size(173, 27);
            txtIngresoMatricula.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 115);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Dueño:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Matrícula:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(135, 16);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingreso";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(txtSalidaMatricula);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(411, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 178);
            panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(126, 124);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtSalidaMatricula
            // 
            txtSalidaMatricula.Location = new Point(103, 67);
            txtSalidaMatricula.Name = "txtSalidaMatricula";
            txtSalidaMatricula.Size = new Size(173, 27);
            txtSalidaMatricula.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 67);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 1;
            label5.Text = "Matrícula:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(135, 16);
            label6.Name = "label6";
            label6.Size = new Size(63, 25);
            label6.TabIndex = 0;
            label6.Text = "Salida";
            // 
            // listViewEstacionamiento
            // 
            listViewEstacionamiento.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewEstacionamiento.Location = new Point(30, 263);
            listViewEstacionamiento.Name = "listViewEstacionamiento";
            listViewEstacionamiento.Size = new Size(712, 257);
            listViewEstacionamiento.TabIndex = 2;
            listViewEstacionamiento.UseCompatibleStateImageBehavior = false;
            listViewEstacionamiento.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Matrícula";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Dueño";
            columnHeader2.Width = 80;
            // 
            // FormEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 532);
            Controls.Add(listViewEstacionamiento);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormEstacionamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEstacionamiento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIngresoMatricula;
        private TextBox txtIngresoDuenio;
        private Panel panel2;
        private TextBox txtSalidaMatricula;
        private Label label5;
        private Label label6;
        private Button btnIngresar;
        private Button btnSalir;
        private ListView listViewEstacionamiento;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}