
namespace Arrays
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colVehiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colServicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nLavado = new System.Windows.Forms.Label();
            this.nEncerado = new System.Windows.Forms.Label();
            this.nSilicona = new System.Windows.Forms.Label();
            this.menorDemanda = new System.Windows.Forms.Label();
            this.montoPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto";
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Items.AddRange(new object[] {
            "Auto",
            "Camioneta"});
            this.cbVehiculo.Location = new System.Drawing.Point(107, 36);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(123, 21);
            this.cbVehiculo.TabIndex = 3;
            // 
            // cbServicio
            // 
            this.cbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Items.AddRange(new object[] {
            "Lavado",
            "Encerado",
            "Silicona"});
            this.cbServicio.Location = new System.Drawing.Point(107, 93);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(123, 21);
            this.cbServicio.TabIndex = 4;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(107, 143);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(123, 20);
            this.txtMonto.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(304, 76);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(128, 47);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colVehiculo,
            this.colServicio,
            this.colMonto});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(54, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 216);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colVehiculo
            // 
            this.colVehiculo.Text = "Vehiculo";
            this.colVehiculo.Width = 89;
            // 
            // colServicio
            // 
            this.colServicio.Text = "Servicio";
            this.colServicio.Width = 107;
            // 
            // colMonto
            // 
            this.colMonto.Text = "Monto ";
            this.colMonto.Width = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resumen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad de veces que se ofreció cada servicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(482, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lavado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Encerado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(482, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Silicona:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Servicios con menor demanda:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(465, 294);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Monto promedio por el servicio de lavado:";
            // 
            // nLavado
            // 
            this.nLavado.AutoSize = true;
            this.nLavado.Location = new System.Drawing.Point(534, 110);
            this.nLavado.Name = "nLavado";
            this.nLavado.Size = new System.Drawing.Size(0, 13);
            this.nLavado.TabIndex = 16;
            // 
            // nEncerado
            // 
            this.nEncerado.AutoSize = true;
            this.nEncerado.Location = new System.Drawing.Point(544, 143);
            this.nEncerado.Name = "nEncerado";
            this.nEncerado.Size = new System.Drawing.Size(0, 13);
            this.nEncerado.TabIndex = 17;
            // 
            // nSilicona
            // 
            this.nSilicona.AutoSize = true;
            this.nSilicona.Location = new System.Drawing.Point(535, 178);
            this.nSilicona.Name = "nSilicona";
            this.nSilicona.Size = new System.Drawing.Size(0, 13);
            this.nSilicona.TabIndex = 18;
            // 
            // menorDemanda
            // 
            this.menorDemanda.AutoSize = true;
            this.menorDemanda.Location = new System.Drawing.Point(482, 253);
            this.menorDemanda.Name = "menorDemanda";
            this.menorDemanda.Size = new System.Drawing.Size(0, 13);
            this.menorDemanda.TabIndex = 19;
            // 
            // montoPromedio
            // 
            this.montoPromedio.AutoSize = true;
            this.montoPromedio.Location = new System.Drawing.Point(482, 325);
            this.montoPromedio.Name = "montoPromedio";
            this.montoPromedio.Size = new System.Drawing.Size(0, 13);
            this.montoPromedio.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.montoPromedio);
            this.Controls.Add(this.menorDemanda);
            this.Controls.Add(this.nSilicona);
            this.Controls.Add(this.nEncerado);
            this.Controls.Add(this.nLavado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colVehiculo;
        private System.Windows.Forms.ColumnHeader colServicio;
        private System.Windows.Forms.ColumnHeader colMonto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label nLavado;
        private System.Windows.Forms.Label nEncerado;
        private System.Windows.Forms.Label nSilicona;
        private System.Windows.Forms.Label menorDemanda;
        private System.Windows.Forms.Label montoPromedio;
    }
}

