namespace LAB10
{
    partial class FormRuta
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
            label4 = new Label();
            txtCodigo = new TextBox();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            txtKilometros = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            listViewRutas = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(59, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Origen:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 142);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "Destino:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 195);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 3;
            label4.Text = "Kilómetros:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(125, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(157, 27);
            txtCodigo.TabIndex = 4;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(125, 85);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(157, 27);
            txtOrigen.TabIndex = 5;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(125, 139);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(157, 27);
            txtDestino.TabIndex = 6;
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(125, 195);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(157, 27);
            txtKilometros.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(138, 268);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(138, 328);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // listViewRutas
            // 
            listViewRutas.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewRutas.Location = new Point(333, 34);
            listViewRutas.Name = "listViewRutas";
            listViewRutas.Size = new Size(439, 385);
            listViewRutas.TabIndex = 10;
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
            // FormRuta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewRutas);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtKilometros);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(txtCodigo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRuta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRuta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCodigo;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private TextBox txtKilometros;
        private Button btnRegistrar;
        private Button btnSalir;
        private ListView listViewRutas;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}