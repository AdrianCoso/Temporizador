namespace Temporizador
{
    partial class Form3
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
            this.TextoTiempoFinalizado = new System.Windows.Forms.Label();
            this.btnFinalizadoReiniciar = new System.Windows.Forms.Button();
            this.btnFinalizadoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoTiempoFinalizado
            // 
            this.TextoTiempoFinalizado.AutoSize = true;
            this.TextoTiempoFinalizado.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoTiempoFinalizado.Location = new System.Drawing.Point(21, 43);
            this.TextoTiempoFinalizado.Name = "TextoTiempoFinalizado";
            this.TextoTiempoFinalizado.Size = new System.Drawing.Size(252, 25);
            this.TextoTiempoFinalizado.TabIndex = 0;
            this.TextoTiempoFinalizado.Text = "El tiempo ha finalizado";
            this.TextoTiempoFinalizado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizadoReiniciar
            // 
            this.btnFinalizadoReiniciar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFinalizadoReiniciar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinalizadoReiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizadoReiniciar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizadoReiniciar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinalizadoReiniciar.Location = new System.Drawing.Point(176, 99);
            this.btnFinalizadoReiniciar.Name = "btnFinalizadoReiniciar";
            this.btnFinalizadoReiniciar.Size = new System.Drawing.Size(106, 44);
            this.btnFinalizadoReiniciar.TabIndex = 1;
            this.btnFinalizadoReiniciar.Text = "Reiniciar";
            this.btnFinalizadoReiniciar.UseVisualStyleBackColor = false;
            this.btnFinalizadoReiniciar.Click += new System.EventHandler(this.btnFinalizadoReiniciar_Click);
            // 
            // btnFinalizadoCancelar
            // 
            this.btnFinalizadoCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnFinalizadoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinalizadoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizadoCancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizadoCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinalizadoCancelar.Location = new System.Drawing.Point(12, 99);
            this.btnFinalizadoCancelar.Name = "btnFinalizadoCancelar";
            this.btnFinalizadoCancelar.Size = new System.Drawing.Size(106, 44);
            this.btnFinalizadoCancelar.TabIndex = 2;
            this.btnFinalizadoCancelar.Text = "Continuar";
            this.btnFinalizadoCancelar.UseVisualStyleBackColor = false;
            this.btnFinalizadoCancelar.Click += new System.EventHandler(this.btnFinalizadoCancelar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(294, 155);
            this.Controls.Add(this.btnFinalizadoCancelar);
            this.Controls.Add(this.btnFinalizadoReiniciar);
            this.Controls.Add(this.TextoTiempoFinalizado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.reproducirSonido);
            this.VisibleChanged += new System.EventHandler(this.Form3_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizadoReiniciar;
        private System.Windows.Forms.Button btnFinalizadoCancelar;
        public System.Windows.Forms.Label TextoTiempoFinalizado;
    }
}