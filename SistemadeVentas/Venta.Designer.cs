namespace SistemadeVentas
{
    partial class Venta
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
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_apel = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_agrehar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_canti = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_nom_prod = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_descu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_terminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(27, 55);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(151, 24);
            this.cb_tipo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha de Venta";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_apel);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(425, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 81);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_apel
            // 
            this.txt_apel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_apel.Location = new System.Drawing.Point(322, 37);
            this.txt_apel.Name = "txt_apel";
            this.txt_apel.Size = new System.Drawing.Size(175, 22);
            this.txt_apel.TabIndex = 15;
            // 
            // txt_nom
            // 
            this.txt_nom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nom.Location = new System.Drawing.Point(90, 37);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(175, 22);
            this.txt_nom.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Apellidos";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_agrehar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_buscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_canti);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_desc);
            this.groupBox2.Controls.Add(this.txt_codigo);
            this.groupBox2.Controls.Add(this.txt_nom_prod);
            this.groupBox2.Controls.Add(this.txt_stock);
            this.groupBox2.Controls.Add(this.txt_precio);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 183);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // btn_agrehar
            // 
            this.btn_agrehar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agrehar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_agrehar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agrehar.ForeColor = System.Drawing.Color.White;
            this.btn_agrehar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agrehar.Location = new System.Drawing.Point(416, 121);
            this.btn_agrehar.Name = "btn_agrehar";
            this.btn_agrehar.Size = new System.Drawing.Size(230, 28);
            this.btn_agrehar.TabIndex = 13;
            this.btn_agrehar.Text = "Agregar";
            this.btn_agrehar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_buscar.Location = new System.Drawing.Point(514, 55);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(132, 28);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock";
            // 
            // txt_canti
            // 
            this.txt_canti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_canti.Location = new System.Drawing.Point(301, 127);
            this.txt_canti.Name = "txt_canti";
            this.txt_canti.Size = new System.Drawing.Size(94, 22);
            this.txt_canti.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Precio Unidad";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Cantidad";
            // 
            // txt_desc
            // 
            this.txt_desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_desc.Location = new System.Drawing.Point(326, 61);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(175, 22);
            this.txt_desc.TabIndex = 10;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(22, 61);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 22);
            this.txt_codigo.TabIndex = 6;
            // 
            // txt_nom_prod
            // 
            this.txt_nom_prod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nom_prod.Location = new System.Drawing.Point(136, 61);
            this.txt_nom_prod.Name = "txt_nom_prod";
            this.txt_nom_prod.Size = new System.Drawing.Size(175, 22);
            this.txt_nom_prod.TabIndex = 7;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(22, 127);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 22);
            this.txt_stock.TabIndex = 9;
            // 
            // txt_precio
            // 
            this.txt_precio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_precio.Location = new System.Drawing.Point(138, 127);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(148, 22);
            this.txt_precio.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 173);
            this.dataGridView1.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Monto Pagar";
            // 
            // txt_monto
            // 
            this.txt_monto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_monto.Location = new System.Drawing.Point(20, 37);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(175, 22);
            this.txt_monto.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Descuento";
            // 
            // txt_descu
            // 
            this.txt_descu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_descu.Location = new System.Drawing.Point(20, 93);
            this.txt_descu.Name = "txt_descu";
            this.txt_descu.Size = new System.Drawing.Size(175, 22);
            this.txt_descu.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cambio";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cambio.Location = new System.Drawing.Point(20, 147);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(175, 22);
            this.txt_cambio.TabIndex = 20;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calcular.BackColor = System.Drawing.Color.Silver;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.ForeColor = System.Drawing.Color.Black;
            this.btn_calcular.Location = new System.Drawing.Point(211, 141);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(120, 28);
            this.btn_calcular.TabIndex = 21;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            // 
            // btn_terminar
            // 
            this.btn_terminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_terminar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_terminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_terminar.ForeColor = System.Drawing.Color.White;
            this.btn_terminar.Location = new System.Drawing.Point(591, 512);
            this.btn_terminar.Name = "btn_terminar";
            this.btn_terminar.Size = new System.Drawing.Size(205, 28);
            this.btn_terminar.TabIndex = 22;
            this.btn_terminar.Text = "Terminar y Imprimir ";
            this.btn_terminar.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            this.btn_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salir.BackColor = System.Drawing.Color.Red;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(826, 512);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(205, 28);
            this.btn_salir.TabIndex = 23;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btn_calcular);
            this.groupBox3.Controls.Add(this.txt_monto);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txt_cambio);
            this.groupBox3.Controls.Add(this.txt_descu);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(684, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 183);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pago";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(207, 57);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 574);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_terminar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tipo);
            this.Name = "Venta";
            this.Text = "Venta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_agrehar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_canti;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_nom_prod;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_apel;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_cambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_descu;
        private System.Windows.Forms.Button btn_terminar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}