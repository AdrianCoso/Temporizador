namespace Temporizador
{
    partial class Form2
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
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.cbSegundos = new System.Windows.Forms.ComboBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbHoras
            // 
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Location = new System.Drawing.Point(74, 30);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(121, 21);
            this.cbHoras.TabIndex = 0;
            // 
            // cbMinutos
            // 
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Location = new System.Drawing.Point(279, 30);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(121, 21);
            this.cbMinutos.TabIndex = 1;
            // 
            // cbSegundos
            // 
            this.cbSegundos.FormattingEnabled = true;
            this.cbSegundos.Location = new System.Drawing.Point(487, 30);
            this.cbSegundos.Name = "cbSegundos";
            this.cbSegundos.Size = new System.Drawing.Size(121, 21);
            this.cbSegundos.TabIndex = 2;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(33, 33);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(35, 13);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas";
            this.lblHoras.Click += new System.EventHandler(this.lblHoras_Click);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(229, 33);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(44, 13);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(426, 33);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(55, 13);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "Segundos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(279, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(487, 91);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 164);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.cbSegundos);
            this.Controls.Add(this.cbMinutos);
            this.Controls.Add(this.cbHoras);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbHoras;
        public System.Windows.Forms.ComboBox cbMinutos;
        public System.Windows.Forms.ComboBox cbSegundos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}