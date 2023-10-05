namespace LAB10
{
    partial class FormPrincipal
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
            btnVerBuses = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnVerBuses
            // 
            btnVerBuses.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerBuses.Location = new Point(160, 130);
            btnVerBuses.Name = "btnVerBuses";
            btnVerBuses.Size = new Size(94, 29);
            btnVerBuses.TabIndex = 0;
            btnVerBuses.Text = "Ver Buses";
            btnVerBuses.UseVisualStyleBackColor = true;
            btnVerBuses.Click += btnVerBuses_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(160, 195);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 381);
            Controls.Add(btnSalir);
            Controls.Add(btnVerBuses);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVerBuses;
        private Button btnSalir;
    }
}