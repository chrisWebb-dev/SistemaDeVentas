
namespace SistemadeVentas
{
    partial class Rol
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rol));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb_filtrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modi = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(669, 314);
            this.dataGridView1.TabIndex = 4;
            // 
            // cb_filtrar
            // 
            this.cb_filtrar.FormattingEnabled = true;
            this.cb_filtrar.Location = new System.Drawing.Point(126, 39);
            this.cb_filtrar.Name = "cb_filtrar";
            this.cb_filtrar.Size = new System.Drawing.Size(156, 28);
            this.cb_filtrar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar por:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Location = new System.Drawing.Point(537, 40);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(149, 27);
            this.txt_buscar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // txt_nom
            // 
            this.txt_nom.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_nom.Location = new System.Drawing.Point(106, 136);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(187, 27);
            this.txt_nom.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 50);
            this.panel1.TabIndex = 3;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.BackgroundImage")));
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Location = new System.Drawing.Point(962, 5);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(42, 42);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.btn_modi);
            this.groupBox1.Controls.Add(this.btn_nuevo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(726, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 425);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar Datos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txt_buscar);
            this.groupBox2.Controls.Add(this.cb_filtrar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(708, 425);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de roles:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_eliminar.BackColor = System.Drawing.Color.White;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Image = global::SistemadeVentas.Properties.Resources.basura;
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eliminar.Location = new System.Drawing.Point(62, 305);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(194, 43);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_modi
            // 
            this.btn_modi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_modi.BackColor = System.Drawing.Color.White;
            this.btn_modi.FlatAppearance.BorderSize = 0;
            this.btn_modi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modi.Image = global::SistemadeVentas.Properties.Resources.lapiz;
            this.btn_modi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modi.Location = new System.Drawing.Point(62, 256);
            this.btn_modi.Name = "btn_modi";
            this.btn_modi.Size = new System.Drawing.Size(194, 43);
            this.btn_modi.TabIndex = 20;
            this.btn_modi.Text = "Modificar";
            this.btn_modi.UseVisualStyleBackColor = false;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_nuevo.BackColor = System.Drawing.Color.White;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Image = global::SistemadeVentas.Properties.Resources.boton_agregar__1_;
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevo.Location = new System.Drawing.Point(62, 207);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(194, 43);
            this.btn_nuevo.TabIndex = 19;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = false;
            // 
            // Rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1055, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Rol";
            this.Text = "Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_filtrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_modi;
        private System.Windows.Forms.Button btn_nuevo;
    }
}