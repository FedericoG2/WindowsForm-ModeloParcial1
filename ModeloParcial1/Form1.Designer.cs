
namespace ModeloParcial1
{
    partial class frmService
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.optCredito = new System.Windows.Forms.RadioButton();
            this.optContado = new System.Windows.Forms.RadioButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExtenderGarantia = new System.Windows.Forms.CheckBox();
            this.chkActualizarSoftware = new System.Windows.Forms.CheckBox();
            this.cmbPlazo = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.cmbTipoDispositivo = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(320, 167);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(90, 40);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "C&errar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(320, 98);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(90, 40);
            this.btnReporte.TabIndex = 28;
            this.btnReporte.Text = "&Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(320, 29);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 40);
            this.btnCalcular.TabIndex = 27;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(316, 248);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(94, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(313, 230);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(69, 13);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Importe Total";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.optCredito);
            this.GroupBox2.Controls.Add(this.optContado);
            this.GroupBox2.Location = new System.Drawing.Point(27, 222);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox2.Size = new System.Drawing.Size(248, 67);
            this.GroupBox2.TabIndex = 24;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Forma de Pago";
            // 
            // optCredito
            // 
            this.optCredito.AutoSize = true;
            this.optCredito.Location = new System.Drawing.Point(147, 27);
            this.optCredito.Margin = new System.Windows.Forms.Padding(2);
            this.optCredito.Name = "optCredito";
            this.optCredito.Size = new System.Drawing.Size(58, 17);
            this.optCredito.TabIndex = 1;
            this.optCredito.Text = "Crédito";
            this.optCredito.UseVisualStyleBackColor = true;
            // 
            // optContado
            // 
            this.optContado.AutoSize = true;
            this.optContado.Checked = true;
            this.optContado.Location = new System.Drawing.Point(47, 27);
            this.optContado.Margin = new System.Windows.Forms.Padding(2);
            this.optContado.Name = "optContado";
            this.optContado.Size = new System.Drawing.Size(65, 17);
            this.optContado.TabIndex = 0;
            this.optContado.TabStop = true;
            this.optContado.Text = "&Contado";
            this.optContado.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chkExtenderGarantia);
            this.GroupBox1.Controls.Add(this.chkActualizarSoftware);
            this.GroupBox1.Location = new System.Drawing.Point(28, 138);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(248, 69);
            this.GroupBox1.TabIndex = 23;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Opciones";
            // 
            // chkExtenderGarantia
            // 
            this.chkExtenderGarantia.AutoSize = true;
            this.chkExtenderGarantia.Location = new System.Drawing.Point(61, 42);
            this.chkExtenderGarantia.Margin = new System.Windows.Forms.Padding(2);
            this.chkExtenderGarantia.Name = "chkExtenderGarantia";
            this.chkExtenderGarantia.Size = new System.Drawing.Size(113, 17);
            this.chkExtenderGarantia.TabIndex = 3;
            this.chkExtenderGarantia.Text = "Extender Garantía";
            this.chkExtenderGarantia.UseVisualStyleBackColor = true;
            // 
            // chkActualizarSoftware
            // 
            this.chkActualizarSoftware.AutoSize = true;
            this.chkActualizarSoftware.Location = new System.Drawing.Point(61, 17);
            this.chkActualizarSoftware.Margin = new System.Windows.Forms.Padding(2);
            this.chkActualizarSoftware.Name = "chkActualizarSoftware";
            this.chkActualizarSoftware.Size = new System.Drawing.Size(117, 17);
            this.chkActualizarSoftware.TabIndex = 0;
            this.chkActualizarSoftware.Text = "Actualizar Software";
            this.chkActualizarSoftware.UseVisualStyleBackColor = true;
            // 
            // cmbPlazo
            // 
            this.cmbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlazo.FormattingEnabled = true;
            this.cmbPlazo.Location = new System.Drawing.Point(127, 103);
            this.cmbPlazo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlazo.Name = "cmbPlazo";
            this.cmbPlazo.Size = new System.Drawing.Size(50, 21);
            this.cmbPlazo.TabIndex = 22;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(25, 105);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 13);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Plazo de Entrega";
            // 
            // cmbTipoDispositivo
            // 
            this.cmbTipoDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDispositivo.FormattingEnabled = true;
            this.cmbTipoDispositivo.Location = new System.Drawing.Point(127, 66);
            this.cmbTipoDispositivo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDispositivo.Name = "cmbTipoDispositivo";
            this.cmbTipoDispositivo.Size = new System.Drawing.Size(148, 21);
            this.cmbTipoDispositivo.TabIndex = 20;
            this.cmbTipoDispositivo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoDispositivo_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(25, 69);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(97, 13);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Tipo de Dispositivo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 29);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 20);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(25, 32);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Cliente";
            // 
            // frmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 310);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.cmbPlazo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.cmbTipoDispositivo);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.Label1);
            this.Name = "frmService";
            this.Text = "Smart Rep";
            this.Load += new System.EventHandler(this.frmService_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCerrar;
        internal System.Windows.Forms.Button btnReporte;
        internal System.Windows.Forms.Button btnCalcular;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.RadioButton optCredito;
        internal System.Windows.Forms.RadioButton optContado;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkActualizarSoftware;
        internal System.Windows.Forms.ComboBox cmbPlazo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox cmbTipoDispositivo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox chkExtenderGarantia;
    }
}

