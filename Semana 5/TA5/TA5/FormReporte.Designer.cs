
namespace TA5
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodigoEstudianteCursosDesaprobados = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarCursosDesaprobados = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiantesPorCodigoCurso = new System.Windows.Forms.Button();
            this.numericUpDownEstudianteCiclo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiantesPorCiclo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEstudiantesAprobadosMejorNota = new System.Windows.Forms.Button();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.listViewCursos = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbTotalCursos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTotalEstudiantes = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstudianteCiclo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtCodigoEstudianteCursosDesaprobados);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnBuscarCursosDesaprobados);
            this.panel4.Location = new System.Drawing.Point(20, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 228);
            this.panel4.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(210, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "CURSO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(61, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ingrese el código del estudiante";
            // 
            // txtCodigoEstudianteCursosDesaprobados
            // 
            this.txtCodigoEstudianteCursosDesaprobados.Location = new System.Drawing.Point(61, 127);
            this.txtCodigoEstudianteCursosDesaprobados.Name = "txtCodigoEstudianteCursosDesaprobados";
            this.txtCodigoEstudianteCursosDesaprobados.Size = new System.Drawing.Size(240, 27);
            this.txtCodigoEstudianteCursosDesaprobados.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(31, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Buscar cursos desaprobados:";
            // 
            // btnBuscarCursosDesaprobados
            // 
            this.btnBuscarCursosDesaprobados.BackColor = System.Drawing.Color.SeaShell;
            this.btnBuscarCursosDesaprobados.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarCursosDesaprobados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarCursosDesaprobados.Location = new System.Drawing.Point(320, 127);
            this.btnBuscarCursosDesaprobados.Name = "btnBuscarCursosDesaprobados";
            this.btnBuscarCursosDesaprobados.Size = new System.Drawing.Size(84, 27);
            this.btnBuscarCursosDesaprobados.TabIndex = 7;
            this.btnBuscarCursosDesaprobados.Text = "Buscar";
            this.btnBuscarCursosDesaprobados.UseVisualStyleBackColor = false;
            this.btnBuscarCursosDesaprobados.Click += new System.EventHandler(this.btnBuscarCursosDesaprobados_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCodigoCurso);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnBuscarEstudiantesPorCodigoCurso);
            this.panel3.Controls.Add(this.numericUpDownEstudianteCiclo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnBuscarEstudiantesPorCiclo);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnEstudiantesAprobadosMejorNota);
            this.panel3.Location = new System.Drawing.Point(20, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 329);
            this.panel3.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ingrese el código del curso";
            // 
            // txtCodigoCurso
            // 
            this.txtCodigoCurso.Location = new System.Drawing.Point(62, 114);
            this.txtCodigoCurso.Name = "txtCodigoCurso";
            this.txtCodigoCurso.Size = new System.Drawing.Size(221, 27);
            this.txtCodigoCurso.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(48, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Buscar estudiantes por código del curso:";
            // 
            // btnBuscarEstudiantesPorCodigoCurso
            // 
            this.btnBuscarEstudiantesPorCodigoCurso.BackColor = System.Drawing.Color.SeaShell;
            this.btnBuscarEstudiantesPorCodigoCurso.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarEstudiantesPorCodigoCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarEstudiantesPorCodigoCurso.Location = new System.Drawing.Point(304, 114);
            this.btnBuscarEstudiantesPorCodigoCurso.Name = "btnBuscarEstudiantesPorCodigoCurso";
            this.btnBuscarEstudiantesPorCodigoCurso.Size = new System.Drawing.Size(84, 27);
            this.btnBuscarEstudiantesPorCodigoCurso.TabIndex = 31;
            this.btnBuscarEstudiantesPorCodigoCurso.Text = "Buscar";
            this.btnBuscarEstudiantesPorCodigoCurso.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiantesPorCodigoCurso.Click += new System.EventHandler(this.btnBuscarEstudiantesPorCodigoCurso_Click);
            // 
            // numericUpDownEstudianteCiclo
            // 
            this.numericUpDownEstudianteCiclo.Location = new System.Drawing.Point(135, 190);
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
            this.numericUpDownEstudianteCiclo.TabIndex = 30;
            this.numericUpDownEstudianteCiclo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownEstudianteCiclo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ciclo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Buscar estudiantes por ciclo académico:";
            // 
            // btnBuscarEstudiantesPorCiclo
            // 
            this.btnBuscarEstudiantesPorCiclo.BackColor = System.Drawing.Color.SeaShell;
            this.btnBuscarEstudiantesPorCiclo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarEstudiantesPorCiclo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscarEstudiantesPorCiclo.Location = new System.Drawing.Point(214, 190);
            this.btnBuscarEstudiantesPorCiclo.Name = "btnBuscarEstudiantesPorCiclo";
            this.btnBuscarEstudiantesPorCiclo.Size = new System.Drawing.Size(105, 27);
            this.btnBuscarEstudiantesPorCiclo.TabIndex = 27;
            this.btnBuscarEstudiantesPorCiclo.Text = "Buscar";
            this.btnBuscarEstudiantesPorCiclo.UseVisualStyleBackColor = false;
            this.btnBuscarEstudiantesPorCiclo.Click += new System.EventHandler(this.btnBuscarEstudiantesPorCiclo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(148, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "ESTUDIANTE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(48, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(356, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Buscar estudiantes aprobados con la nota más alta:";
            // 
            // btnEstudiantesAprobadosMejorNota
            // 
            this.btnEstudiantesAprobadosMejorNota.BackColor = System.Drawing.Color.SeaShell;
            this.btnEstudiantesAprobadosMejorNota.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEstudiantesAprobadosMejorNota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstudiantesAprobadosMejorNota.Location = new System.Drawing.Point(167, 272);
            this.btnEstudiantesAprobadosMejorNota.Name = "btnEstudiantesAprobadosMejorNota";
            this.btnEstudiantesAprobadosMejorNota.Size = new System.Drawing.Size(105, 27);
            this.btnEstudiantesAprobadosMejorNota.TabIndex = 7;
            this.btnEstudiantesAprobadosMejorNota.Text = "Buscar";
            this.btnEstudiantesAprobadosMejorNota.UseVisualStyleBackColor = false;
            this.btnEstudiantesAprobadosMejorNota.Click += new System.EventHandler(this.btnEstudiantesAprobadosMejorNota_Click);
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(482, 21);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(468, 299);
            this.listViewEstudiantes.TabIndex = 22;
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
            // listViewCursos
            // 
            this.listViewCursos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewCursos.HideSelection = false;
            this.listViewCursos.Location = new System.Drawing.Point(482, 370);
            this.listViewCursos.Name = "listViewCursos";
            this.listViewCursos.Size = new System.Drawing.Size(468, 190);
            this.listViewCursos.TabIndex = 23;
            this.listViewCursos.UseCompatibleStateImageBehavior = false;
            this.listViewCursos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Código";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nombre";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Créditos";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Nota";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Estado";
            this.columnHeader9.Width = 120;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaShell;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(428, 620);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 33);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbTotalCursos
            // 
            this.lbTotalCursos.AutoSize = true;
            this.lbTotalCursos.Location = new System.Drawing.Point(909, 578);
            this.lbTotalCursos.Name = "lbTotalCursos";
            this.lbTotalCursos.Size = new System.Drawing.Size(17, 20);
            this.lbTotalCursos.TabIndex = 26;
            this.lbTotalCursos.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(804, 578);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "N° de cursos:";
            // 
            // lbTotalEstudiantes
            // 
            this.lbTotalEstudiantes.AutoSize = true;
            this.lbTotalEstudiantes.Location = new System.Drawing.Point(905, 330);
            this.lbTotalEstudiantes.Name = "lbTotalEstudiantes";
            this.lbTotalEstudiantes.Size = new System.Drawing.Size(17, 20);
            this.lbTotalEstudiantes.TabIndex = 28;
            this.lbTotalEstudiantes.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(770, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "N° de estudiantes:";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 665);
            this.Controls.Add(this.lbTotalEstudiantes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTotalCursos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listViewCursos);
            this.Controls.Add(this.listViewEstudiantes);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "FormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstudianteCiclo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCodigoEstudianteCursosDesaprobados;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarCursosDesaprobados;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEstudiantesAprobadosMejorNota;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewCursos;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarEstudiantesPorCiclo;
        private System.Windows.Forms.NumericUpDown numericUpDownEstudianteCiclo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarEstudiantesPorCodigoCurso;
        private System.Windows.Forms.Label lbTotalCursos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotalEstudiantes;
        private System.Windows.Forms.Label label7;
    }
}