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
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblSound = new System.Windows.Forms.Label();
            this.cbSonidos = new System.Windows.Forms.ComboBox();
            this.numericHoras = new System.Windows.Forms.NumericUpDown();
            this.numericMinutos = new System.Windows.Forms.NumericUpDown();
            this.numericSegundos = new System.Windows.Forms.NumericUpDown();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.rbCuenta = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.pnlCuenta = new System.Windows.Forms.Panel();
            this.cbCero = new System.Windows.Forms.ComboBox();
            this.lblCero = new System.Windows.Forms.Label();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnlRadios = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegundos)).BeginInit();
            this.pnlCuenta.SuspendLayout();
            this.pnlFecha.SuspendLayout();
            this.pnlRadios.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHoras.Location = new System.Drawing.Point(11, 18);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(52, 20);
            this.lblHoras.TabIndex = 3;
            this.lblHoras.Text = "Horas";
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMinutos.Location = new System.Drawing.Point(121, 18);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(65, 20);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "Minutos";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSegundos.Location = new System.Drawing.Point(252, 18);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(82, 20);
            this.lblSegundos.TabIndex = 5;
            this.lblSegundos.Text = "Segundos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(12, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.Location = new System.Drawing.Point(338, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 38);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSound.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSound.Location = new System.Drawing.Point(24, 22);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(59, 20);
            this.lblSound.TabIndex = 8;
            this.lblSound.Text = "Sonido";
            // 
            // cbSonidos
            // 
            this.cbSonidos.BackColor = System.Drawing.Color.DimGray;
            this.cbSonidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSonidos.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSonidos.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbSonidos.FormattingEnabled = true;
            this.cbSonidos.Location = new System.Drawing.Point(92, 21);
            this.cbSonidos.Name = "cbSonidos";
            this.cbSonidos.Size = new System.Drawing.Size(160, 21);
            this.cbSonidos.TabIndex = 9;
            // 
            // numericHoras
            // 
            this.numericHoras.BackColor = System.Drawing.Color.DimGray;
            this.numericHoras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHoras.ForeColor = System.Drawing.Color.Gainsboro;
            this.numericHoras.Location = new System.Drawing.Point(61, 21);
            this.numericHoras.Name = "numericHoras";
            this.numericHoras.Size = new System.Drawing.Size(54, 22);
            this.numericHoras.TabIndex = 10;
            this.numericHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericMinutos
            // 
            this.numericMinutos.BackColor = System.Drawing.Color.DimGray;
            this.numericMinutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericMinutos.ForeColor = System.Drawing.Color.Gainsboro;
            this.numericMinutos.Location = new System.Drawing.Point(192, 21);
            this.numericMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericMinutos.Name = "numericMinutos";
            this.numericMinutos.Size = new System.Drawing.Size(54, 22);
            this.numericMinutos.TabIndex = 11;
            this.numericMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericSegundos
            // 
            this.numericSegundos.BackColor = System.Drawing.Color.DimGray;
            this.numericSegundos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSegundos.ForeColor = System.Drawing.Color.Gainsboro;
            this.numericSegundos.Location = new System.Drawing.Point(340, 21);
            this.numericSegundos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericSegundos.Name = "numericSegundos";
            this.numericSegundos.Size = new System.Drawing.Size(54, 22);
            this.numericSegundos.TabIndex = 12;
            this.numericSegundos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMensaje
            // 
            this.tbMensaje.BackColor = System.Drawing.Color.DimGray;
            this.tbMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMensaje.ForeColor = System.Drawing.Color.Gainsboro;
            this.tbMensaje.Location = new System.Drawing.Point(92, 57);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(367, 20);
            this.tbMensaje.TabIndex = 14;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMensaje.Location = new System.Drawing.Point(15, 57);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(69, 20);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Mensaje";
            // 
            // rbCuenta
            // 
            this.rbCuenta.AutoSize = true;
            this.rbCuenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCuenta.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbCuenta.Location = new System.Drawing.Point(12, 51);
            this.rbCuenta.Name = "rbCuenta";
            this.rbCuenta.Size = new System.Drawing.Size(132, 22);
            this.rbCuenta.TabIndex = 15;
            this.rbCuenta.TabStop = true;
            this.rbCuenta.Text = "Cuenta atrás";
            this.rbCuenta.UseVisualStyleBackColor = true;
            this.rbCuenta.CheckedChanged += new System.EventHandler(this.rbCuenta_CheckedChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFecha.ForeColor = System.Drawing.Color.Gainsboro;
            this.rbFecha.Location = new System.Drawing.Point(150, 51);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(329, 22);
            this.rbFecha.TabIndex = 16;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Contar hasta (desde) fecha y tiempo";
            this.rbFecha.UseVisualStyleBackColor = true;
            // 
            // pnlCuenta
            // 
            this.pnlCuenta.Controls.Add(this.cbCero);
            this.pnlCuenta.Controls.Add(this.lblCero);
            this.pnlCuenta.Controls.Add(this.lblHoras);
            this.pnlCuenta.Controls.Add(this.lblMinutos);
            this.pnlCuenta.Controls.Add(this.lblSegundos);
            this.pnlCuenta.Controls.Add(this.numericHoras);
            this.pnlCuenta.Controls.Add(this.numericMinutos);
            this.pnlCuenta.Controls.Add(this.numericSegundos);
            this.pnlCuenta.Location = new System.Drawing.Point(0, 77);
            this.pnlCuenta.Name = "pnlCuenta";
            this.pnlCuenta.Size = new System.Drawing.Size(491, 102);
            this.pnlCuenta.TabIndex = 17;
            // 
            // cbCero
            // 
            this.cbCero.BackColor = System.Drawing.Color.DimGray;
            this.cbCero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCero.ForeColor = System.Drawing.Color.Gainsboro;
            this.cbCero.FormattingEnabled = true;
            this.cbCero.Items.AddRange(new object[] {
            "Parar temporizador",
            "Reiniciar temporizador",
            "Iniciar como cronómetro (incremento)"});
            this.cbCero.Location = new System.Drawing.Point(92, 63);
            this.cbCero.Name = "cbCero";
            this.cbCero.Size = new System.Drawing.Size(242, 21);
            this.cbCero.TabIndex = 13;
            // 
            // lblCero
            // 
            this.lblCero.AutoSize = true;
            this.lblCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCero.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCero.Location = new System.Drawing.Point(22, 61);
            this.lblCero.Name = "lblCero";
            this.lblCero.Size = new System.Drawing.Size(64, 20);
            this.lblCero.TabIndex = 3;
            this.lblCero.Text = "En cero";
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.dateTimePicker2);
            this.pnlFecha.Controls.Add(this.dateTimePicker1);
            this.pnlFecha.Location = new System.Drawing.Point(0, 76);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(491, 46);
            this.pnlFecha.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(258, 13);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Firebrick;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.Location = new System.Drawing.Point(303, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(168, 27);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Repetir sonido";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pnlRadios
            // 
            this.pnlRadios.Controls.Add(this.panel1);
            this.pnlRadios.Controls.Add(this.rbCuenta);
            this.pnlRadios.Controls.Add(this.rbFecha);
            this.pnlRadios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRadios.Location = new System.Drawing.Point(0, 0);
            this.pnlRadios.Name = "pnlRadios";
            this.pnlRadios.Size = new System.Drawing.Size(491, 76);
            this.pnlRadios.TabIndex = 20;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnAceptar);
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Controls.Add(this.checkBox1);
            this.pnlBotones.Controls.Add(this.lblSound);
            this.pnlBotones.Controls.Add(this.lblMensaje);
            this.pnlBotones.Controls.Add(this.cbSonidos);
            this.pnlBotones.Controls.Add(this.tbMensaje);
            this.pnlBotones.Controls.Add(this.pictureBox1);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 179);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(491, 157);
            this.pnlBotones.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 44);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Temporizador.Properties.Resources.play;
            this.pictureBox1.Location = new System.Drawing.Point(258, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Temporizador.Properties.Resources.close;
            this.pictureBox2.Location = new System.Drawing.Point(450, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(491, 336);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.pnlCuenta);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlRadios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSegundos)).EndInit();
            this.pnlCuenta.ResumeLayout(false);
            this.pnlCuenta.PerformLayout();
            this.pnlFecha.ResumeLayout(false);
            this.pnlRadios.ResumeLayout(false);
            this.pnlRadios.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.pnlBotones.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblSound;
        public System.Windows.Forms.ComboBox cbSonidos;
        public System.Windows.Forms.NumericUpDown numericHoras;
        public System.Windows.Forms.NumericUpDown numericMinutos;
        public System.Windows.Forms.NumericUpDown numericSegundos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMensaje;
        public System.Windows.Forms.RadioButton rbCuenta;
        public System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.Panel pnlCuenta;
        private System.Windows.Forms.Panel pnlFecha;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.ComboBox cbCero;
        private System.Windows.Forms.Label lblCero;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel pnlRadios;
        private System.Windows.Forms.Panel pnlBotones;
        public System.Windows.Forms.TextBox tbMensaje;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}