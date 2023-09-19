
namespace LAB06
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
            this.btnAlbumLimpiar = new System.Windows.Forms.Button();
            this.btnAlbumRegistrar = new System.Windows.Forms.Button();
            this.txtAlbumNombre = new System.Windows.Forms.TextBox();
            this.txtAlbumCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtHeroePoder = new System.Windows.Forms.TextBox();
            this.txtHeroeNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHeroeLimpiar = new System.Windows.Forms.Button();
            this.btnHeroeRegistrar = new System.Windows.Forms.Button();
            this.txtHeroeCaracteristica = new System.Windows.Forms.TextBox();
            this.txtHeroeCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewAlbum = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.listViewHeroe = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAlbumMaxHeroes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbHeroeMin = new System.Windows.Forms.Label();
            this.lbHeroeMax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlbumLimpiar);
            this.panel1.Controls.Add(this.btnAlbumRegistrar);
            this.panel1.Controls.Add(this.txtAlbumNombre);
            this.panel1.Controls.Add(this.txtAlbumCodigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 239);
            this.panel1.TabIndex = 0;
            // 
            // btnAlbumLimpiar
            // 
            this.btnAlbumLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlbumLimpiar.Location = new System.Drawing.Point(175, 187);
            this.btnAlbumLimpiar.Name = "btnAlbumLimpiar";
            this.btnAlbumLimpiar.Size = new System.Drawing.Size(104, 33);
            this.btnAlbumLimpiar.TabIndex = 6;
            this.btnAlbumLimpiar.Text = "Limpiar";
            this.btnAlbumLimpiar.UseVisualStyleBackColor = true;
            this.btnAlbumLimpiar.Click += new System.EventHandler(this.btnAlbumLimpiar_Click);
            // 
            // btnAlbumRegistrar
            // 
            this.btnAlbumRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlbumRegistrar.Location = new System.Drawing.Point(56, 187);
            this.btnAlbumRegistrar.Name = "btnAlbumRegistrar";
            this.btnAlbumRegistrar.Size = new System.Drawing.Size(104, 33);
            this.btnAlbumRegistrar.TabIndex = 5;
            this.btnAlbumRegistrar.Text = "Registrar";
            this.btnAlbumRegistrar.UseVisualStyleBackColor = true;
            this.btnAlbumRegistrar.Click += new System.EventHandler(this.btnAlbumRegistrar_Click);
            // 
            // txtAlbumNombre
            // 
            this.txtAlbumNombre.Location = new System.Drawing.Point(105, 118);
            this.txtAlbumNombre.Name = "txtAlbumNombre";
            this.txtAlbumNombre.Size = new System.Drawing.Size(184, 27);
            this.txtAlbumNombre.TabIndex = 4;
            // 
            // txtAlbumCodigo
            // 
            this.txtAlbumCodigo.Location = new System.Drawing.Point(105, 64);
            this.txtAlbumCodigo.Name = "txtAlbumCodigo";
            this.txtAlbumCodigo.Size = new System.Drawing.Size(184, 27);
            this.txtAlbumCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(124, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÁLBUM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtHeroePoder);
            this.panel2.Controls.Add(this.txtHeroeNombre);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnHeroeLimpiar);
            this.panel2.Controls.Add(this.btnHeroeRegistrar);
            this.panel2.Controls.Add(this.txtHeroeCaracteristica);
            this.panel2.Controls.Add(this.txtHeroeCodigo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(364, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 239);
            this.panel2.TabIndex = 1;
            // 
            // txtHeroePoder
            // 
            this.txtHeroePoder.Location = new System.Drawing.Point(434, 118);
            this.txtHeroePoder.Name = "txtHeroePoder";
            this.txtHeroePoder.Size = new System.Drawing.Size(184, 27);
            this.txtHeroePoder.TabIndex = 10;
            // 
            // txtHeroeNombre
            // 
            this.txtHeroeNombre.Location = new System.Drawing.Point(434, 64);
            this.txtHeroeNombre.Name = "txtHeroeNombre";
            this.txtHeroeNombre.Size = new System.Drawing.Size(184, 27);
            this.txtHeroeNombre.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Poder:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre:";
            // 
            // btnHeroeLimpiar
            // 
            this.btnHeroeLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeroeLimpiar.Location = new System.Drawing.Point(356, 187);
            this.btnHeroeLimpiar.Name = "btnHeroeLimpiar";
            this.btnHeroeLimpiar.Size = new System.Drawing.Size(104, 33);
            this.btnHeroeLimpiar.TabIndex = 6;
            this.btnHeroeLimpiar.Text = "Limpiar";
            this.btnHeroeLimpiar.UseVisualStyleBackColor = true;
            this.btnHeroeLimpiar.Click += new System.EventHandler(this.btnHeroeLimpiar_Click);
            // 
            // btnHeroeRegistrar
            // 
            this.btnHeroeRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeroeRegistrar.Location = new System.Drawing.Point(237, 187);
            this.btnHeroeRegistrar.Name = "btnHeroeRegistrar";
            this.btnHeroeRegistrar.Size = new System.Drawing.Size(104, 33);
            this.btnHeroeRegistrar.TabIndex = 5;
            this.btnHeroeRegistrar.Text = "Registrar";
            this.btnHeroeRegistrar.UseVisualStyleBackColor = true;
            this.btnHeroeRegistrar.Click += new System.EventHandler(this.btnHeroeRegistrar_Click);
            // 
            // txtHeroeCaracteristica
            // 
            this.txtHeroeCaracteristica.Location = new System.Drawing.Point(132, 118);
            this.txtHeroeCaracteristica.Name = "txtHeroeCaracteristica";
            this.txtHeroeCaracteristica.Size = new System.Drawing.Size(184, 27);
            this.txtHeroeCaracteristica.TabIndex = 4;
            // 
            // txtHeroeCodigo
            // 
            this.txtHeroeCodigo.Location = new System.Drawing.Point(132, 64);
            this.txtHeroeCodigo.Name = "txtHeroeCodigo";
            this.txtHeroeCodigo.Size = new System.Drawing.Size(184, 27);
            this.txtHeroeCodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Característica:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(309, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "HÉROE";
            // 
            // listViewAlbum
            // 
            this.listViewAlbum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewAlbum.HideSelection = false;
            this.listViewAlbum.Location = new System.Drawing.Point(12, 270);
            this.listViewAlbum.Name = "listViewAlbum";
            this.listViewAlbum.Size = new System.Drawing.Size(327, 216);
            this.listViewAlbum.TabIndex = 2;
            this.listViewAlbum.UseCompatibleStateImageBehavior = false;
            this.listViewAlbum.View = System.Windows.Forms.View.Details;
            this.listViewAlbum.SelectedIndexChanged += new System.EventHandler(this.listViewAlbum_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 140;
            // 
            // listViewHeroe
            // 
            this.listViewHeroe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewHeroe.HideSelection = false;
            this.listViewHeroe.Location = new System.Drawing.Point(364, 270);
            this.listViewHeroe.Name = "listViewHeroe";
            this.listViewHeroe.Size = new System.Drawing.Size(647, 216);
            this.listViewHeroe.TabIndex = 3;
            this.listViewHeroe.UseCompatibleStateImageBehavior = false;
            this.listViewHeroe.View = System.Windows.Forms.View.Details;
            this.listViewHeroe.SelectedIndexChanged += new System.EventHandler(this.listViewHeroe_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Característica";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Poder";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbAlbumMaxHeroes);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(12, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(327, 117);
            this.panel3.TabIndex = 4;
            // 
            // lbAlbumMaxHeroes
            // 
            this.lbAlbumMaxHeroes.AutoSize = true;
            this.lbAlbumMaxHeroes.Location = new System.Drawing.Point(15, 69);
            this.lbAlbumMaxHeroes.Name = "lbAlbumMaxHeroes";
            this.lbAlbumMaxHeroes.Size = new System.Drawing.Size(0, 20);
            this.lbAlbumMaxHeroes.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Álbum con más héroes:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbHeroeMin);
            this.panel4.Controls.Add(this.lbHeroeMax);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(364, 501);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 117);
            this.panel4.TabIndex = 5;
            // 
            // lbHeroeMin
            // 
            this.lbHeroeMin.AutoSize = true;
            this.lbHeroeMin.Location = new System.Drawing.Point(193, 69);
            this.lbHeroeMin.Name = "lbHeroeMin";
            this.lbHeroeMin.Size = new System.Drawing.Size(0, 20);
            this.lbHeroeMin.TabIndex = 3;
            // 
            // lbHeroeMax
            // 
            this.lbHeroeMax.AutoSize = true;
            this.lbHeroeMax.Location = new System.Drawing.Point(192, 17);
            this.lbHeroeMax.Name = "lbHeroeMax";
            this.lbHeroeMax.Size = new System.Drawing.Size(0, 20);
            this.lbHeroeMax.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Héroe con menor poder:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Héroe con mayor poder:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 630);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.listViewHeroe);
            this.Controls.Add(this.listViewAlbum);
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
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlbumLimpiar;
        private System.Windows.Forms.Button btnAlbumRegistrar;
        private System.Windows.Forms.TextBox txtAlbumNombre;
        private System.Windows.Forms.TextBox txtAlbumCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtHeroePoder;
        private System.Windows.Forms.TextBox txtHeroeNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHeroeLimpiar;
        private System.Windows.Forms.Button btnHeroeRegistrar;
        private System.Windows.Forms.TextBox txtHeroeCaracteristica;
        private System.Windows.Forms.TextBox txtHeroeCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewAlbum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewHeroe;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbAlbumMaxHeroes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbHeroeMin;
        private System.Windows.Forms.Label lbHeroeMax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

