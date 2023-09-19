
namespace LAB08
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgenciaLimpiar = new System.Windows.Forms.Button();
            this.btnAgenciaAgregar = new System.Windows.Forms.Button();
            this.txtAgenciaTelefono = new System.Windows.Forms.TextBox();
            this.txtAgenciaCiudad = new System.Windows.Forms.TextBox();
            this.txtAgenciaDireccion = new System.Windows.Forms.TextBox();
            this.txtAgenciaCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbInmuebleCondicion = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInmuebleLimpiar = new System.Windows.Forms.Button();
            this.btnInmuebleAgregar = new System.Windows.Forms.Button();
            this.txtInmueblePrecio = new System.Windows.Forms.TextBox();
            this.txtInmuebleSuperficie = new System.Windows.Forms.TextBox();
            this.txtInmuebleDireccion = new System.Windows.Forms.TextBox();
            this.txtInmuebleCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewAgencia = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.listViewInmueble = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgenciaMayorInmueblesVenta = new System.Windows.Forms.Button();
            this.btnAgenciaAlquilerInmuebleMaxSuperficie = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTotalAlquiler = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInmuebleBuscarAgencia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnInmuebleBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.btnAgenciaLimpiar);
            this.panel1.Controls.Add(this.btnAgenciaAgregar);
            this.panel1.Controls.Add(this.txtAgenciaTelefono);
            this.panel1.Controls.Add(this.txtAgenciaCiudad);
            this.panel1.Controls.Add(this.txtAgenciaDireccion);
            this.panel1.Controls.Add(this.txtAgenciaCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 321);
            this.panel1.TabIndex = 0;
            // 
            // btnAgenciaLimpiar
            // 
            this.btnAgenciaLimpiar.BackColor = System.Drawing.Color.SeaShell;
            this.btnAgenciaLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgenciaLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgenciaLimpiar.Location = new System.Drawing.Point(214, 270);
            this.btnAgenciaLimpiar.Name = "btnAgenciaLimpiar";
            this.btnAgenciaLimpiar.Size = new System.Drawing.Size(103, 33);
            this.btnAgenciaLimpiar.TabIndex = 8;
            this.btnAgenciaLimpiar.Text = "Limpiar";
            this.btnAgenciaLimpiar.UseVisualStyleBackColor = false;
            this.btnAgenciaLimpiar.Click += new System.EventHandler(this.btnAgenciaLimpiar_Click);
            // 
            // btnAgenciaAgregar
            // 
            this.btnAgenciaAgregar.BackColor = System.Drawing.Color.SeaShell;
            this.btnAgenciaAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgenciaAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgenciaAgregar.Location = new System.Drawing.Point(213, 231);
            this.btnAgenciaAgregar.Name = "btnAgenciaAgregar";
            this.btnAgenciaAgregar.Size = new System.Drawing.Size(103, 33);
            this.btnAgenciaAgregar.TabIndex = 7;
            this.btnAgenciaAgregar.Text = "Agregar";
            this.btnAgenciaAgregar.UseVisualStyleBackColor = false;
            this.btnAgenciaAgregar.Click += new System.EventHandler(this.btnAgenciaAgregar_Click);
            // 
            // txtAgenciaTelefono
            // 
            this.txtAgenciaTelefono.Location = new System.Drawing.Point(110, 185);
            this.txtAgenciaTelefono.Name = "txtAgenciaTelefono";
            this.txtAgenciaTelefono.Size = new System.Drawing.Size(341, 27);
            this.txtAgenciaTelefono.TabIndex = 5;
            // 
            // txtAgenciaCiudad
            // 
            this.txtAgenciaCiudad.Location = new System.Drawing.Point(110, 142);
            this.txtAgenciaCiudad.Name = "txtAgenciaCiudad";
            this.txtAgenciaCiudad.Size = new System.Drawing.Size(341, 27);
            this.txtAgenciaCiudad.TabIndex = 6;
            // 
            // txtAgenciaDireccion
            // 
            this.txtAgenciaDireccion.Location = new System.Drawing.Point(110, 98);
            this.txtAgenciaDireccion.Name = "txtAgenciaDireccion";
            this.txtAgenciaDireccion.Size = new System.Drawing.Size(341, 27);
            this.txtAgenciaDireccion.TabIndex = 5;
            // 
            // txtAgenciaCodigo
            // 
            this.txtAgenciaCodigo.Location = new System.Drawing.Point(110, 56);
            this.txtAgenciaCodigo.Name = "txtAgenciaCodigo";
            this.txtAgenciaCodigo.Size = new System.Drawing.Size(341, 27);
            this.txtAgenciaCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(44, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dirección:";
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
            this.label1.Location = new System.Drawing.Point(213, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENCIA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.cbInmuebleCondicion);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnInmuebleLimpiar);
            this.panel2.Controls.Add(this.btnInmuebleAgregar);
            this.panel2.Controls.Add(this.txtInmueblePrecio);
            this.panel2.Controls.Add(this.txtInmuebleSuperficie);
            this.panel2.Controls.Add(this.txtInmuebleDireccion);
            this.panel2.Controls.Add(this.txtInmuebleCodigo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(549, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 321);
            this.panel2.TabIndex = 9;
            // 
            // cbInmuebleCondicion
            // 
            this.cbInmuebleCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInmuebleCondicion.FormattingEnabled = true;
            this.cbInmuebleCondicion.Items.AddRange(new object[] {
            "Venta",
            "Alquiler"});
            this.cbInmuebleCondicion.Location = new System.Drawing.Point(117, 231);
            this.cbInmuebleCondicion.Name = "cbInmuebleCondicion";
            this.cbInmuebleCondicion.Size = new System.Drawing.Size(333, 28);
            this.cbInmuebleCondicion.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(29, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Condición:";
            // 
            // btnInmuebleLimpiar
            // 
            this.btnInmuebleLimpiar.BackColor = System.Drawing.Color.SeaShell;
            this.btnInmuebleLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInmuebleLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInmuebleLimpiar.Location = new System.Drawing.Point(283, 276);
            this.btnInmuebleLimpiar.Name = "btnInmuebleLimpiar";
            this.btnInmuebleLimpiar.Size = new System.Drawing.Size(103, 33);
            this.btnInmuebleLimpiar.TabIndex = 8;
            this.btnInmuebleLimpiar.Text = "Limpiar";
            this.btnInmuebleLimpiar.UseVisualStyleBackColor = false;
            this.btnInmuebleLimpiar.Click += new System.EventHandler(this.btnInmuebleLimpiar_Click);
            // 
            // btnInmuebleAgregar
            // 
            this.btnInmuebleAgregar.BackColor = System.Drawing.Color.SeaShell;
            this.btnInmuebleAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInmuebleAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInmuebleAgregar.Location = new System.Drawing.Point(165, 276);
            this.btnInmuebleAgregar.Name = "btnInmuebleAgregar";
            this.btnInmuebleAgregar.Size = new System.Drawing.Size(103, 33);
            this.btnInmuebleAgregar.TabIndex = 7;
            this.btnInmuebleAgregar.Text = "Agregar";
            this.btnInmuebleAgregar.UseVisualStyleBackColor = false;
            this.btnInmuebleAgregar.Click += new System.EventHandler(this.btnInmuebleAgregar_Click);
            // 
            // txtInmueblePrecio
            // 
            this.txtInmueblePrecio.Location = new System.Drawing.Point(117, 188);
            this.txtInmueblePrecio.Name = "txtInmueblePrecio";
            this.txtInmueblePrecio.Size = new System.Drawing.Size(333, 27);
            this.txtInmueblePrecio.TabIndex = 5;
            // 
            // txtInmuebleSuperficie
            // 
            this.txtInmuebleSuperficie.Location = new System.Drawing.Point(117, 145);
            this.txtInmuebleSuperficie.Name = "txtInmuebleSuperficie";
            this.txtInmuebleSuperficie.Size = new System.Drawing.Size(333, 27);
            this.txtInmuebleSuperficie.TabIndex = 6;
            // 
            // txtInmuebleDireccion
            // 
            this.txtInmuebleDireccion.Location = new System.Drawing.Point(117, 101);
            this.txtInmuebleDireccion.Name = "txtInmuebleDireccion";
            this.txtInmuebleDireccion.Size = new System.Drawing.Size(333, 27);
            this.txtInmuebleDireccion.TabIndex = 5;
            // 
            // txtInmuebleCodigo
            // 
            this.txtInmuebleCodigo.Location = new System.Drawing.Point(117, 59);
            this.txtInmuebleCodigo.Name = "txtInmuebleCodigo";
            this.txtInmuebleCodigo.Size = new System.Drawing.Size(333, 27);
            this.txtInmuebleCodigo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(55, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(30, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Superficie:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dirección:";
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
            this.label10.Location = new System.Drawing.Point(211, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "INMUEBLE";
            // 
            // listViewAgencia
            // 
            this.listViewAgencia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewAgencia.HideSelection = false;
            this.listViewAgencia.Location = new System.Drawing.Point(23, 369);
            this.listViewAgencia.Name = "listViewAgencia";
            this.listViewAgencia.Size = new System.Drawing.Size(493, 278);
            this.listViewAgencia.TabIndex = 10;
            this.listViewAgencia.UseCompatibleStateImageBehavior = false;
            this.listViewAgencia.View = System.Windows.Forms.View.Details;
            this.listViewAgencia.SelectedIndexChanged += new System.EventHandler(this.listViewAgencia_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dirección";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ciudad";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Teléfono";
            this.columnHeader4.Width = 100;
            // 
            // listViewInmueble
            // 
            this.listViewInmueble.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listViewInmueble.HideSelection = false;
            this.listViewInmueble.Location = new System.Drawing.Point(549, 369);
            this.listViewInmueble.Name = "listViewInmueble";
            this.listViewInmueble.Size = new System.Drawing.Size(493, 278);
            this.listViewInmueble.TabIndex = 11;
            this.listViewInmueble.UseCompatibleStateImageBehavior = false;
            this.listViewInmueble.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Código";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Dirección";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Superficie";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Precio";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Condición";
            this.columnHeader9.Width = 80;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.btnAgenciaMayorInmueblesVenta);
            this.panel3.Controls.Add(this.btnAgenciaAlquilerInmuebleMaxSuperficie);
            this.panel3.Location = new System.Drawing.Point(23, 672);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 123);
            this.panel3.TabIndex = 12;
            // 
            // btnAgenciaMayorInmueblesVenta
            // 
            this.btnAgenciaMayorInmueblesVenta.BackColor = System.Drawing.Color.SeaShell;
            this.btnAgenciaMayorInmueblesVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgenciaMayorInmueblesVenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgenciaMayorInmueblesVenta.Location = new System.Drawing.Point(42, 71);
            this.btnAgenciaMayorInmueblesVenta.Name = "btnAgenciaMayorInmueblesVenta";
            this.btnAgenciaMayorInmueblesVenta.Size = new System.Drawing.Size(412, 33);
            this.btnAgenciaMayorInmueblesVenta.TabIndex = 8;
            this.btnAgenciaMayorInmueblesVenta.Text = "Buscar las que tienen más inmuebles en venta";
            this.btnAgenciaMayorInmueblesVenta.UseVisualStyleBackColor = false;
            this.btnAgenciaMayorInmueblesVenta.Click += new System.EventHandler(this.btnAgenciaMayorInmueblesVenta_Click);
            // 
            // btnAgenciaAlquilerInmuebleMaxSuperficie
            // 
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.BackColor = System.Drawing.Color.SeaShell;
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.Location = new System.Drawing.Point(39, 19);
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.Name = "btnAgenciaAlquilerInmuebleMaxSuperficie";
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.Size = new System.Drawing.Size(412, 33);
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.TabIndex = 7;
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.Text = "Buscar las que alquilan inmuebles con mayor superficie";
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.UseVisualStyleBackColor = false;
            this.btnAgenciaAlquilerInmuebleMaxSuperficie.Click += new System.EventHandler(this.btnAgenciaAlquilerInmuebleMaxSuperficie_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.lbTotalAlquiler);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtInmuebleBuscarAgencia);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.btnInmuebleBuscar);
            this.panel4.Location = new System.Drawing.Point(549, 672);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(493, 123);
            this.panel4.TabIndex = 13;
            // 
            // lbTotalAlquiler
            // 
            this.lbTotalAlquiler.AutoSize = true;
            this.lbTotalAlquiler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalAlquiler.Location = new System.Drawing.Point(178, 77);
            this.lbTotalAlquiler.Name = "lbTotalAlquiler";
            this.lbTotalAlquiler.Size = new System.Drawing.Size(17, 20);
            this.lbTotalAlquiler.TabIndex = 13;
            this.lbTotalAlquiler.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(21, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Monto total alquiler:";
            // 
            // txtInmuebleBuscarAgencia
            // 
            this.txtInmuebleBuscarAgencia.Location = new System.Drawing.Point(178, 25);
            this.txtInmuebleBuscarAgencia.Name = "txtInmuebleBuscarAgencia";
            this.txtInmuebleBuscarAgencia.Size = new System.Drawing.Size(180, 27);
            this.txtInmuebleBuscarAgencia.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(29, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Buscar por agencia:";
            // 
            // btnInmuebleBuscar
            // 
            this.btnInmuebleBuscar.BackColor = System.Drawing.Color.SeaShell;
            this.btnInmuebleBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInmuebleBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInmuebleBuscar.Location = new System.Drawing.Point(384, 9);
            this.btnInmuebleBuscar.Name = "btnInmuebleBuscar";
            this.btnInmuebleBuscar.Size = new System.Drawing.Size(84, 58);
            this.btnInmuebleBuscar.TabIndex = 7;
            this.btnInmuebleBuscar.Text = "Buscar Venta";
            this.btnInmuebleBuscar.UseVisualStyleBackColor = false;
            this.btnInmuebleBuscar.Click += new System.EventHandler(this.btnInmuebleBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 807);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listViewInmueble);
            this.Controls.Add(this.listViewAgencia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgenciaLimpiar;
        private System.Windows.Forms.Button btnAgenciaAgregar;
        private System.Windows.Forms.TextBox txtAgenciaTelefono;
        private System.Windows.Forms.TextBox txtAgenciaCiudad;
        private System.Windows.Forms.TextBox txtAgenciaDireccion;
        private System.Windows.Forms.TextBox txtAgenciaCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbInmuebleCondicion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInmuebleLimpiar;
        private System.Windows.Forms.Button btnInmuebleAgregar;
        private System.Windows.Forms.TextBox txtInmueblePrecio;
        private System.Windows.Forms.TextBox txtInmuebleSuperficie;
        private System.Windows.Forms.TextBox txtInmuebleDireccion;
        private System.Windows.Forms.TextBox txtInmuebleCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listViewAgencia;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listViewInmueble;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgenciaMayorInmueblesVenta;
        private System.Windows.Forms.Button btnAgenciaAlquilerInmuebleMaxSuperficie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbTotalAlquiler;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtInmuebleBuscarAgencia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInmuebleBuscar;
    }
}

