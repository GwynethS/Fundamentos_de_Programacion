
namespace Ejercicio_1
{
    partial class frmPago
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.txtTardanza = new System.Windows.Forms.TextBox();
            this.txtLlamadas = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTardanza = new System.Windows.Forms.Label();
            this.lbLlamadas = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(184, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(468, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTardanza
            // 
            this.txtTardanza.Location = new System.Drawing.Point(184, 144);
            this.txtTardanza.Multiline = true;
            this.txtTardanza.Name = "txtTardanza";
            this.txtTardanza.Size = new System.Drawing.Size(115, 44);
            this.txtTardanza.TabIndex = 2;
            this.txtTardanza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLlamadas
            // 
            this.txtLlamadas.Location = new System.Drawing.Point(544, 144);
            this.txtLlamadas.Multiline = true;
            this.txtLlamadas.Name = "txtLlamadas";
            this.txtLlamadas.Size = new System.Drawing.Size(108, 44);
            this.txtLlamadas.TabIndex = 3;
            this.txtLlamadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(37, 39);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(73, 17);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombres: ";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbCategoria.Location = new System.Drawing.Point(184, 86);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(115, 24);
            this.cbCategoria.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Categoría:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTardanza
            // 
            this.lbTardanza.AutoSize = true;
            this.lbTardanza.Location = new System.Drawing.Point(37, 158);
            this.lbTardanza.Name = "lbTardanza";
            this.lbTardanza.Size = new System.Drawing.Size(141, 17);
            this.lbTardanza.TabIndex = 7;
            this.lbTardanza.Text = "Minutos de tardanza:";
            this.lbTardanza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLlamadas
            // 
            this.lbLlamadas.AutoSize = true;
            this.lbLlamadas.Location = new System.Drawing.Point(352, 158);
            this.lbLlamadas.Name = "lbLlamadas";
            this.lbLlamadas.Size = new System.Drawing.Size(186, 17);
            this.lbLlamadas.TabIndex = 8;
            this.lbLlamadas.Text = "N° de llamadas de atención:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(117, 229);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(205, 53);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "REGISTRAR EMPLEADO";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(398, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(205, 53);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(70, 331);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(593, 191);
            this.listView.TabIndex = 11;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Categoría";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Minutos de tardanza";
            this.columnHeader3.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Llamadas de atención";
            this.columnHeader4.Width = 152;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pago";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(608, 560);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 17);
            this.lbTotal.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total de empleados:";
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 629);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbLlamadas);
            this.Controls.Add(this.lbTardanza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtLlamadas);
            this.Controls.Add(this.txtTardanza);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.TextBox txtTardanza;
        private System.Windows.Forms.TextBox txtLlamadas;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTardanza;
        private System.Windows.Forms.Label lbLlamadas;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
    }
}

