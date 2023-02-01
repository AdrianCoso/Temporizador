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
            this.TextoTiempoFinalizado.Location = new System.Drawing.Point(12, 9);
            this.TextoTiempoFinalizado.Name = "TextoTiempoFinalizado";
            this.TextoTiempoFinalizado.Size = new System.Drawing.Size(112, 13);
            this.TextoTiempoFinalizado.TabIndex = 0;
            this.TextoTiempoFinalizado.Text = "El tiempo ha finalizado";
            // 
            // btnFinalizadoReiniciar
            // 
            this.btnFinalizadoReiniciar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFinalizadoReiniciar.Location = new System.Drawing.Point(39, 40);
            this.btnFinalizadoReiniciar.Name = "btnFinalizadoReiniciar";
            this.btnFinalizadoReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizadoReiniciar.TabIndex = 1;
            this.btnFinalizadoReiniciar.Text = "Reiniciar";
            this.btnFinalizadoReiniciar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizadoCancelar
            // 
            this.btnFinalizadoCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFinalizadoCancelar.Location = new System.Drawing.Point(39, 69);
            this.btnFinalizadoCancelar.Name = "btnFinalizadoCancelar";
            this.btnFinalizadoCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizadoCancelar.TabIndex = 2;
            this.btnFinalizadoCancelar.Text = "Continuar";
            this.btnFinalizadoCancelar.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(152, 104);
            this.Controls.Add(this.btnFinalizadoCancelar);
            this.Controls.Add(this.btnFinalizadoReiniciar);
            this.Controls.Add(this.TextoTiempoFinalizado);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextoTiempoFinalizado;
        private System.Windows.Forms.Button btnFinalizadoReiniciar;
        private System.Windows.Forms.Button btnFinalizadoCancelar;
    }
}