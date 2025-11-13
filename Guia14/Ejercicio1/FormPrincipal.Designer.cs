namespace Ejercicio1
{
    partial class FormPrincipal
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
            lbDestino = new Label();
            lbPrecio = new Label();
            lbTransporte = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            tbTelefono = new TextBox();
            tbCuit = new TextBox();
            tbNombre = new TextBox();
            lbTelefono = new Label();
            lbNroTarjeta = new Label();
            lbCuit = new Label();
            lbNombre = new Label();
            gbDatosPasajero = new GroupBox();
            btnGenerar = new Button();
            btnResumen = new Button();
            btnSalir = new Button();
            btnEjemplo = new Button();
            tbNroTarjeta = new TextBox();
            gbDatosPasajero.SuspendLayout();
            SuspendLayout();
            // 
            // lbDestino
            // 
            lbDestino.AutoSize = true;
            lbDestino.Location = new Point(38, 34);
            lbDestino.Name = "lbDestino";
            lbDestino.Size = new Size(50, 15);
            lbDestino.TabIndex = 1;
            lbDestino.Text = "Destino:";
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(38, 71);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(43, 15);
            lbPrecio.TabIndex = 2;
            lbPrecio.Text = "Precio:";
            // 
            // lbTransporte
            // 
            lbTransporte.AutoSize = true;
            lbTransporte.Location = new Point(38, 107);
            lbTransporte.Name = "lbTransporte";
            lbTransporte.Size = new Size(65, 15);
            lbTransporte.TabIndex = 3;
            lbTransporte.Text = "Transporte:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(109, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(109, 104);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(76, 91);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(100, 23);
            tbTelefono.TabIndex = 7;
            // 
            // tbCuit
            // 
            tbCuit.Location = new Point(76, 26);
            tbCuit.Name = "tbCuit";
            tbCuit.Size = new Size(100, 23);
            tbCuit.TabIndex = 8;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(76, 61);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(100, 23);
            tbNombre.TabIndex = 9;
            // 
            // lbTelefono
            // 
            lbTelefono.AutoSize = true;
            lbTelefono.Location = new Point(15, 94);
            lbTelefono.Name = "lbTelefono";
            lbTelefono.Size = new Size(55, 15);
            lbTelefono.TabIndex = 11;
            lbTelefono.Text = "Telefono:";
            // 
            // lbNroTarjeta
            // 
            lbNroTarjeta.AutoSize = true;
            lbNroTarjeta.Location = new Point(12, 126);
            lbNroTarjeta.Name = "lbNroTarjeta";
            lbNroTarjeta.Size = new Size(61, 15);
            lbNroTarjeta.TabIndex = 13;
            lbNroTarjeta.Text = "N° Tarjeta:";
            lbNroTarjeta.Click += label3_Click;
            // 
            // lbCuit
            // 
            lbCuit.AutoSize = true;
            lbCuit.Location = new Point(15, 29);
            lbCuit.Name = "lbCuit";
            lbCuit.Size = new Size(58, 15);
            lbCuit.TabIndex = 14;
            lbCuit.Text = "Cuit/Cuil:";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(16, 64);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(54, 15);
            lbNombre.TabIndex = 15;
            lbNombre.Text = "Nombre:";
            // 
            // gbDatosPasajero
            // 
            gbDatosPasajero.Controls.Add(tbNroTarjeta);
            gbDatosPasajero.Controls.Add(lbCuit);
            gbDatosPasajero.Controls.Add(tbTelefono);
            gbDatosPasajero.Controls.Add(tbNombre);
            gbDatosPasajero.Controls.Add(lbNroTarjeta);
            gbDatosPasajero.Controls.Add(tbCuit);
            gbDatosPasajero.Controls.Add(lbTelefono);
            gbDatosPasajero.Controls.Add(lbNombre);
            gbDatosPasajero.Location = new Point(38, 147);
            gbDatosPasajero.Name = "gbDatosPasajero";
            gbDatosPasajero.Size = new Size(273, 179);
            gbDatosPasajero.TabIndex = 16;
            gbDatosPasajero.TabStop = false;
            gbDatosPasajero.Text = "Datos Pasajero";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(236, 31);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 47);
            btnGenerar.TabIndex = 17;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(236, 84);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(75, 48);
            btnResumen.TabIndex = 18;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(236, 332);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEjemplo
            // 
            btnEjemplo.Location = new Point(38, 332);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(75, 23);
            btnEjemplo.TabIndex = 20;
            btnEjemplo.Text = "Ejemplo";
            btnEjemplo.UseVisualStyleBackColor = true;
            // 
            // tbNroTarjeta
            // 
            tbNroTarjeta.Location = new Point(76, 123);
            tbNroTarjeta.Name = "tbNroTarjeta";
            tbNroTarjeta.Size = new Size(100, 23);
            tbNroTarjeta.TabIndex = 16;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 372);
            Controls.Add(btnEjemplo);
            Controls.Add(btnSalir);
            Controls.Add(btnResumen);
            Controls.Add(btnGenerar);
            Controls.Add(gbDatosPasajero);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lbTransporte);
            Controls.Add(lbPrecio);
            Controls.Add(lbDestino);
            Name = "FormPrincipal";
            Text = "Form1";
            gbDatosPasajero.ResumeLayout(false);
            gbDatosPasajero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDestino;
        private Label lbPrecio;
        private Label lbTransporte;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox tbTelefono;
        private TextBox tbCuit;
        private TextBox tbNombre;
        private TextBox textBox5;
        private Label lbTelefono;
        private Label label2;
        private Label lbNroTarjeta;
        private Label lbCuit;
        private Label lbNombre;
        private GroupBox gbDatosPasajero;
        private TextBox textBox6;
        private Button btnGenerar;
        private Button btnResumen;
        private Button btnSalir;
        private Button btnEjemplo;
        private TextBox tbNroTarjeta;
    }
}
