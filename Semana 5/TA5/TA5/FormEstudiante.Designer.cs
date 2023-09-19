
namespace TA5
{
    partial class FormEstudiante
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.numericUpDownEstudianteCiclo = new System.Windows.Forms.NumericUpDown();
            this.btnEstudianteRegistrar = new System.Windows.Forms.Button();
            this.txtEstudianteApellidos = new System.Windows.Forms.TextBox();
            this.txtEstudianteNombre = new System.Windows.Forms.TextBox();
            this.txtEstudianteCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalEstudiantes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstudianteCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnVerCursos);
            this.panel1.Controls.Add(this.numericUpDownEstudianteCiclo);
            this.panel1.Controls.Add(this.btnEstudianteRegistrar);
            this.panel1.Controls.Add(this.txtEstudianteApellidos);
            this.panel1.Controls.Add(this.txtEstudianteNombre);
            this.panel1.Controls.Add(this.txtEstudianteCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 321);
            this.panel1.TabIndex = 15;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.SeaShell;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReportes.Location = new System.Drawing.Point(308, 264);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(103, 33);
            this.btnReportes.TabIndex = 11;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.BackColor = System.Drawing.Color.SeaShell;
            this.btnVerCursos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerCursos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerCursos.Location = new System.Drawing.Point(181, 264);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(103, 33);
            this.btnVerCursos.TabIndex = 10;
            this.btnVerCursos.Text = "Ver cursos";
            this.btnVerCursos.UseVisualStyleBackColor = false;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // numericUpDownEstudianteCiclo
            // 
            this.numericUpDownEstudianteCiclo.Location = new System.Drawing.Point(110, 188);
            this.numericUpDownEstudianteCiclo.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownEstudianteCiclo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEstudianteCiclo.Name = "numericUpDownEstudianteCiclo";
            this.numericUpDownEstudianteCiclo.Size = new System.Drawing.Size(54, 27);
            this.numericUpDownEstudianteCiclo.TabIndex = 9;
            this.numericUpDownEstudianteCiclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownEstudianteCiclo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEstudianteRegistrar
            // 
            this.btnEstudianteRegistrar.BackColor = System.Drawing.Color.SeaShell;
            this.btnEstudianteRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstudianteRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstudianteRegistrar.Location = new System.Drawing.Point(58, 264);
            this.btnEstudianteRegistrar.Name = "btnEstudianteRegistrar";
            this.btnEstudianteRegistrar.Size = new System.Drawing.Size(103, 33);
            this.btnEstudianteRegistrar.TabIndex = 7;
            this.btnEstudianteRegistrar.Text = "Registrar";
            this.btnEstudianteRegistrar.UseVisualStyleBackColor = false;
            this.btnEstudianteRegistrar.Click += new System.EventHandler(this.btnEstudianteRegistrar_Click);
            // 
            // txtEstudianteApellidos
            // 
            this.txtEstudianteApellidos.Location = new System.Drawing.Point(110, 142);
            this.txtEstudianteApellidos.Name = "txtEstudianteApellidos";
            this.txtEstudianteApellidos.Size = new System.Drawing.Size(270, 27);
            this.txtEstudianteApellidos.TabIndex = 6;
            // 
            // txtEstudianteNombre
            // 
            this.txtEstudianteNombre.Location = new System.Drawing.Point(110, 98);
            this.txtEstudianteNombre.Name = "txtEstudianteNombre";
            this.txtEstudianteNombre.Size = new System.Drawing.Size(270, 27);
            this.txtEstudianteNombre.TabIndex = 5;
            // 
            // txtEstudianteCodigo
            // 
            this.txtEstudianteCodigo.Location = new System.Drawing.Point(110, 56);
            this.txtEstudianteCodigo.Name = "txtEstudianteCodigo";
            this.txtEstudianteCodigo.Size = new System.Drawing.Size(270, 27);
            this.txtEstudianteCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(58, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ciclo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(28, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(170, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESTUDIANTE";
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(504, 42);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(437, 321);
            this.listViewEstudiantes.TabIndex = 17;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ciclo";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaShell;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(434, 391);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 33);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(752, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "N° de estudiantes:";
            // 
            // lbTotalEstudiantes
            // 
            this.lbTotalEstudiantes.AutoSize = true;
            this.lbTotalEstudiantes.Location = new System.Drawing.Point(887, 376);
            this.lbTotalEstudiantes.Name = "lbTotalEstudiantes";
            this.lbTotalEstudiantes.Size = new System.Drawing.Size(17, 20);
            this.lbTotalEstudiantes.TabIndex = 19;
            this.lbTotalEstudiantes.Text = "0";
            // 
            // FormEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.lbTotalEstudiantes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.panel1);
            this.Name = "FormEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEstudiante";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstudianteCiclo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownEstudianteCiclo;
        private System.Windows.Forms.Button btnEstudianteRegistrar;
        private System.Windows.Forms.TextBox txtEstudianteApellidos;
        private System.Windows.Forms.TextBox txtEstudianteNombre;
        private System.Windows.Forms.TextBox txtEstudianteCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalEstudiantes;
    }
}