namespace SistemaSuperSecreto
{
    partial class Ventana2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkBasic = new System.Windows.Forms.CheckBox();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos en Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formas de Pago";
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(16, 133);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(71, 17);
            this.chkC.TabIndex = 2;
            this.chkC.Text = "Visual C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkBasic
            // 
            this.chkBasic.AutoSize = true;
            this.chkBasic.Location = new System.Drawing.Point(16, 178);
            this.chkBasic.Name = "chkBasic";
            this.chkBasic.Size = new System.Drawing.Size(83, 17);
            this.chkBasic.TabIndex = 3;
            this.chkBasic.Text = "Visual Basic";
            this.chkBasic.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Location = new System.Drawing.Point(320, 133);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(109, 17);
            this.rbTarjeta.TabIndex = 4;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta de Crédito";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Location = new System.Drawing.Point(320, 178);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(57, 17);
            this.rbPay.TabIndex = 5;
            this.rbPay.TabStop = true;
            this.rbPay.Text = "Paypal";
            this.rbPay.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Comprar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 75);
            this.button2.TabIndex = 7;
            this.button2.Text = "C&errar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbPay);
            this.Controls.Add(this.rbTarjeta);
            this.Controls.Add(this.chkBasic);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ventana2";
            this.Text = "Cursos de Programación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkBasic;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}