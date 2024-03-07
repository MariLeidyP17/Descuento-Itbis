namespace Ejercicio9
{
    partial class Form1
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
            System.Windows.Forms.Label lbl1;
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.txt_aplica = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txt_montoneto = new System.Windows.Forms.TextBox();
            this.txt_itbis = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl1.Location = new System.Drawing.Point(34, 77);
            lbl1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(144, 19);
            lbl1.TabIndex = 0;
            lbl1.Text = "Ingrese el monto";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(555, 139);
            this.lbl2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(73, 19);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Descuento";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalcular.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(61, 347);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(138, 42);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(185, 77);
            this.txt_monto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(171, 26);
            this.txt_monto.TabIndex = 3;
            // 
            // txt_aplica
            // 
            this.txt_aplica.Location = new System.Drawing.Point(535, 161);
            this.txt_aplica.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_aplica.Name = "txt_aplica";
            this.txt_aplica.Size = new System.Drawing.Size(171, 26);
            this.txt_aplica.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(427, 347);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 42);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCerrar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(239, 347);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(138, 42);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txt_montoneto
            // 
            this.txt_montoneto.Location = new System.Drawing.Point(535, 307);
            this.txt_montoneto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_montoneto.Name = "txt_montoneto";
            this.txt_montoneto.Size = new System.Drawing.Size(171, 26);
            this.txt_montoneto.TabIndex = 7;
            // 
            // txt_itbis
            // 
            this.txt_itbis.Location = new System.Drawing.Point(535, 235);
            this.txt_itbis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_itbis.Name = "txt_itbis";
            this.txt_itbis.Size = new System.Drawing.Size(171, 26);
            this.txt_itbis.TabIndex = 8;
            this.txt_itbis.TextChanged += new System.EventHandler(this.txt_itbis_TextChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(579, 213);
            this.lbl3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 19);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "ITBIS";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(555, 285);
            this.lbl4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(80, 19);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "Monto neto";
            this.lbl4.Click += new System.EventHandler(this.lbl4_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(535, 80);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(171, 26);
            this.txt_precio.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Monto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txt_itbis);
            this.Controls.Add(this.txt_montoneto);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txt_aplica);
            this.Controls.Add(this.txt_monto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(lbl1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Tu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.TextBox txt_aplica;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txt_montoneto;
        private System.Windows.Forms.TextBox txt_itbis;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label1;
    }
}

