
namespace Caso__A
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListarProyectosLibres = new System.Windows.Forms.Button();
            this.nUpDownHabitaciones = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMetraje = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDistrito = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProyectosVendidos = new System.Windows.Forms.Button();
            this.lbSumaPrecios = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.listViewProyectos = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHabitaciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListarProyectosLibres);
            this.panel1.Controls.Add(this.nUpDownHabitaciones);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMetraje);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbDistrito);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 274);
            this.panel1.TabIndex = 52;
            // 
            // btnListarProyectosLibres
            // 
            this.btnListarProyectosLibres.Location = new System.Drawing.Point(182, 28);
            this.btnListarProyectosLibres.Name = "btnListarProyectosLibres";
            this.btnListarProyectosLibres.Size = new System.Drawing.Size(75, 31);
            this.btnListarProyectosLibres.TabIndex = 58;
            this.btnListarProyectosLibres.Text = "Buscar";
            this.btnListarProyectosLibres.UseVisualStyleBackColor = true;
            this.btnListarProyectosLibres.Click += new System.EventHandler(this.btnListarProyectosLibres_Click);
            // 
            // nUpDownHabitaciones
            // 
            this.nUpDownHabitaciones.Location = new System.Drawing.Point(23, 230);
            this.nUpDownHabitaciones.Name = "nUpDownHabitaciones";
            this.nUpDownHabitaciones.Size = new System.Drawing.Size(169, 22);
            this.nUpDownHabitaciones.TabIndex = 57;
            this.nUpDownHabitaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Cantidad de habitaciones:";
            // 
            // txtMetraje
            // 
            this.txtMetraje.Location = new System.Drawing.Point(23, 167);
            this.txtMetraje.Name = "txtMetraje";
            this.txtMetraje.Size = new System.Drawing.Size(168, 22);
            this.txtMetraje.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Metraje (m2):";
            // 
            // cbDistrito
            // 
            this.cbDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistrito.FormattingEnabled = true;
            this.cbDistrito.Items.AddRange(new object[] {
            "Lince",
            "San Isidro",
            "Jesus Maria",
            "San Borja",
            "San Miguel",
            "Magdalena"});
            this.cbDistrito.Location = new System.Drawing.Point(23, 105);
            this.cbDistrito.Name = "cbDistrito";
            this.cbDistrito.Size = new System.Drawing.Size(168, 24);
            this.cbDistrito.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Distrito:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 55);
            this.label1.TabIndex = 51;
            this.label1.Text = "Proyectos que se encuentran libres para ser vendidos:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProyectosVendidos);
            this.panel2.Controls.Add(this.lbSumaPrecios);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(277, 140);
            this.panel2.TabIndex = 53;
            // 
            // btnProyectosVendidos
            // 
            this.btnProyectosVendidos.Location = new System.Drawing.Point(182, 17);
            this.btnProyectosVendidos.Name = "btnProyectosVendidos";
            this.btnProyectosVendidos.Size = new System.Drawing.Size(75, 32);
            this.btnProyectosVendidos.TabIndex = 55;
            this.btnProyectosVendidos.Text = "Buscar";
            this.btnProyectosVendidos.UseVisualStyleBackColor = true;
            this.btnProyectosVendidos.Click += new System.EventHandler(this.btnProyectosVendidos_Click);
            // 
            // lbSumaPrecios
            // 
            this.lbSumaPrecios.AutoSize = true;
            this.lbSumaPrecios.Location = new System.Drawing.Point(71, 107);
            this.lbSumaPrecios.Name = "lbSumaPrecios";
            this.lbSumaPrecios.Size = new System.Drawing.Size(16, 17);
            this.lbSumaPrecios.TabIndex = 54;
            this.lbSumaPrecios.Text = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(46, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Suma de precios:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Proyectos vendidos:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(752, 410);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // listViewProyectos
            // 
            this.listViewProyectos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.listViewProyectos.HideSelection = false;
            this.listViewProyectos.Location = new System.Drawing.Point(307, 12);
            this.listViewProyectos.Name = "listViewProyectos";
            this.listViewProyectos.Size = new System.Drawing.Size(520, 374);
            this.listViewProyectos.TabIndex = 57;
            this.listViewProyectos.UseCompatibleStateImageBehavior = false;
            this.listViewProyectos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Código";
            this.columnHeader12.Width = 80;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Nombre propietario";
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Celular Propietario";
            this.columnHeader14.Width = 100;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Estado";
            this.columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "N° Habitaciones";
            this.columnHeader16.Width = 100;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "N° Estacionamientos";
            this.columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Cuenta";
            this.columnHeader18.Width = 80;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Metraje";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Precio";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Distrito";
            this.columnHeader21.Width = 80;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Descripción";
            this.columnHeader22.Width = 80;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Comentarios";
            this.columnHeader23.Width = 120;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 456);
            this.Controls.Add(this.listViewProyectos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHabitaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListarProyectosLibres;
        private System.Windows.Forms.NumericUpDown nUpDownHabitaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMetraje;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDistrito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProyectosVendidos;
        private System.Windows.Forms.Label lbSumaPrecios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView listViewProyectos;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
    }
}