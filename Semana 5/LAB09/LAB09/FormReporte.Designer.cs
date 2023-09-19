
namespace LAB09
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
            this.listViewEntrenadores = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnBuscarMenosPokemon = new System.Windows.Forms.Button();
            this.btnBuscarRegion = new System.Windows.Forms.Button();
            this.btnBuscarNombrePokemon = new System.Windows.Forms.Button();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbTotalEntrenadores = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewEntrenadores
            // 
            this.listViewEntrenadores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewEntrenadores.HideSelection = false;
            this.listViewEntrenadores.Location = new System.Drawing.Point(413, 31);
            this.listViewEntrenadores.Name = "listViewEntrenadores";
            this.listViewEntrenadores.Size = new System.Drawing.Size(369, 338);
            this.listViewEntrenadores.TabIndex = 29;
            this.listViewEntrenadores.UseCompatibleStateImageBehavior = false;
            this.listViewEntrenadores.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Edad";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Región";
            this.columnHeader4.Width = 80;
            // 
            // btnBuscarMenosPokemon
            // 
            this.btnBuscarMenosPokemon.Location = new System.Drawing.Point(30, 294);
            this.btnBuscarMenosPokemon.Name = "btnBuscarMenosPokemon";
            this.btnBuscarMenosPokemon.Size = new System.Drawing.Size(221, 56);
            this.btnBuscarMenosPokemon.TabIndex = 27;
            this.btnBuscarMenosPokemon.Text = "Buscar los que tienen menos pokemons";
            this.btnBuscarMenosPokemon.UseVisualStyleBackColor = true;
            this.btnBuscarMenosPokemon.Click += new System.EventHandler(this.btnBuscarMenosPokemon_Click);
            // 
            // btnBuscarRegion
            // 
            this.btnBuscarRegion.Location = new System.Drawing.Point(30, 195);
            this.btnBuscarRegion.Name = "btnBuscarRegion";
            this.btnBuscarRegion.Size = new System.Drawing.Size(221, 29);
            this.btnBuscarRegion.TabIndex = 26;
            this.btnBuscarRegion.Text = "Buscar por Región";
            this.btnBuscarRegion.UseVisualStyleBackColor = true;
            this.btnBuscarRegion.Click += new System.EventHandler(this.btnBuscarRegion_Click);
            // 
            // btnBuscarNombrePokemon
            // 
            this.btnBuscarNombrePokemon.Location = new System.Drawing.Point(26, 79);
            this.btnBuscarNombrePokemon.Name = "btnBuscarNombrePokemon";
            this.btnBuscarNombrePokemon.Size = new System.Drawing.Size(232, 29);
            this.btnBuscarNombrePokemon.TabIndex = 25;
            this.btnBuscarNombrePokemon.Text = "Buscar por nombre Pókemon";
            this.btnBuscarNombrePokemon.UseVisualStyleBackColor = true;
            this.btnBuscarNombrePokemon.Click += new System.EventHandler(this.btnBuscarNombrePokemon_Click);
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "Brasil",
            "Estados Unidos",
            "Francia",
            "Japon"});
            this.cbRegion.Location = new System.Drawing.Point(100, 145);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(151, 28);
            this.cbRegion.TabIndex = 24;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 27);
            this.txtNombre.TabIndex = 22;
            // 
            // lbTotalEntrenadores
            // 
            this.lbTotalEntrenadores.AutoSize = true;
            this.lbTotalEntrenadores.Location = new System.Drawing.Point(742, 394);
            this.lbTotalEntrenadores.Name = "lbTotalEntrenadores";
            this.lbTotalEntrenadores.Size = new System.Drawing.Size(17, 20);
            this.lbTotalEntrenadores.TabIndex = 20;
            this.lbTotalEntrenadores.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Total entrenadores:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Región:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(100, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 29);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.listViewEntrenadores);
            this.Controls.Add(this.btnBuscarMenosPokemon);
            this.Controls.Add(this.btnBuscarRegion);
            this.Controls.Add(this.btnBuscarNombrePokemon);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbTotalEntrenadores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewEntrenadores;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBuscarMenosPokemon;
        private System.Windows.Forms.Button btnBuscarRegion;
        private System.Windows.Forms.Button btnBuscarNombrePokemon;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbTotalEntrenadores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}