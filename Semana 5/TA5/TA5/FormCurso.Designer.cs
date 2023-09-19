
namespace TA5
{
    partial class FormCurso
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
            this.listViewCursos = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownCursoCreditos = new System.Windows.Forms.NumericUpDown();
            this.txtCursoNota = new System.Windows.Forms.TextBox();
            this.btnCursoRegistrar = new System.Windows.Forms.Button();
            this.txtCursoNombre = new System.Windows.Forms.TextBox();
            this.txtCursoCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbTotalCursos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCursoCreditos)).BeginInit();
            this.SuspendLayout();
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
            this.listViewCursos.Location = new System.Drawing.Point(536, 37);
            this.listViewCursos.Name = "listViewCursos";
            this.listViewCursos.Size = new System.Drawing.Size(468, 321);
            this.listViewCursos.TabIndex = 19;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.numericUpDownCursoCreditos);
            this.panel2.Controls.Add(this.txtCursoNota);
            this.panel2.Controls.Add(this.btnCursoRegistrar);
            this.panel2.Controls.Add(this.txtCursoNombre);
            this.panel2.Controls.Add(this.txtCursoCodigo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(27, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 321);
            this.panel2.TabIndex = 18;
            // 
            // numericUpDownCursoCreditos
            // 
            this.numericUpDownCursoCreditos.Location = new System.Drawing.Point(117, 146);
            this.numericUpDownCursoCreditos.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownCursoCreditos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCursoCreditos.Name = "numericUpDownCursoCreditos";
            this.numericUpDownCursoCreditos.Size = new System.Drawing.Size(63, 27);
            this.numericUpDownCursoCreditos.TabIndex = 10;
            this.numericUpDownCursoCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCursoCreditos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCursoNota
            // 
            this.txtCursoNota.Location = new System.Drawing.Point(279, 145);
            this.txtCursoNota.Name = "txtCursoNota";
            this.txtCursoNota.Size = new System.Drawing.Size(123, 27);
            this.txtCursoNota.TabIndex = 9;
            // 
            // btnCursoRegistrar
            // 
            this.btnCursoRegistrar.BackColor = System.Drawing.Color.SeaShell;
            this.btnCursoRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCursoRegistrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCursoRegistrar.Location = new System.Drawing.Point(191, 228);
            this.btnCursoRegistrar.Name = "btnCursoRegistrar";
            this.btnCursoRegistrar.Size = new System.Drawing.Size(103, 33);
            this.btnCursoRegistrar.TabIndex = 7;
            this.btnCursoRegistrar.Text = "Registrar";
            this.btnCursoRegistrar.UseVisualStyleBackColor = false;
            this.btnCursoRegistrar.Click += new System.EventHandler(this.btnCursoRegistrar_Click);
            // 
            // txtCursoNombre
            // 
            this.txtCursoNombre.Location = new System.Drawing.Point(117, 101);
            this.txtCursoNombre.Name = "txtCursoNombre";
            this.txtCursoNombre.Size = new System.Drawing.Size(285, 27);
            this.txtCursoNombre.TabIndex = 5;
            // 
            // txtCursoCodigo
            // 
            this.txtCursoCodigo.Location = new System.Drawing.Point(117, 59);
            this.txtCursoCodigo.Name = "txtCursoCodigo";
            this.txtCursoCodigo.Size = new System.Drawing.Size(285, 27);
            this.txtCursoCodigo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(222, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nota:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(42, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Créditos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(41, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(49, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Código:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(206, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "CURSO";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaShell;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(462, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 33);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbTotalCursos
            // 
            this.lbTotalCursos.AutoSize = true;
            this.lbTotalCursos.Location = new System.Drawing.Point(965, 376);
            this.lbTotalCursos.Name = "lbTotalCursos";
            this.lbTotalCursos.Size = new System.Drawing.Size(17, 20);
            this.lbTotalCursos.TabIndex = 21;
            this.lbTotalCursos.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(860, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "N° de cursos:";
            // 
            // FormCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.lbTotalCursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewCursos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Name = "FormCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCurso";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCursoCreditos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCursos;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownCursoCreditos;
        private System.Windows.Forms.TextBox txtCursoNota;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCursoRegistrar;
        private System.Windows.Forms.TextBox txtCursoNombre;
        private System.Windows.Forms.TextBox txtCursoCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTotalCursos;
        private System.Windows.Forms.Label label1;
    }
}