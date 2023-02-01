namespace Temporizador
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnIniciarParar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(48, 211);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 60);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(229, 211);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(92, 60);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnIniciarParar
            // 
            this.btnIniciarParar.Location = new System.Drawing.Point(401, 211);
            this.btnIniciarParar.Name = "btnIniciarParar";
            this.btnIniciarParar.Size = new System.Drawing.Size(98, 60);
            this.btnIniciarParar.TabIndex = 2;
            this.btnIniciarParar.Text = "Iniciar";
            this.btnIniciarParar.UseVisualStyleBackColor = true;
            this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(12, 33);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(366, 138);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "tiempo";
            this.lblTiempo.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 283);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnIniciarParar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnEditar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnIniciarParar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTiempo;
    }
}

