namespace CapaVistaTraslado
{
    partial class TrasladoD
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
            this.navegador1 = new DLL.nav.navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraslado = new System.Windows.Forms.TextBox();
            this.cbxTraslado = new System.Windows.Forms.ComboBox();
            this.cbxInventario = new System.Windows.Forms.ComboBox();
            this.txtInventario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cantidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Traslado Encabezado";
            // 
            // txtTraslado
            // 
            this.txtTraslado.Location = new System.Drawing.Point(285, 176);
            this.txtTraslado.Name = "txtTraslado";
            this.txtTraslado.Size = new System.Drawing.Size(65, 20);
            this.txtTraslado.TabIndex = 2;
            this.txtTraslado.Tag = "idTrasladoE";
            this.txtTraslado.TextChanged += new System.EventHandler(this.txtTraslado_TextChanged);
            // 
            // cbxTraslado
            // 
            this.cbxTraslado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTraslado.FormattingEnabled = true;
            this.cbxTraslado.Location = new System.Drawing.Point(134, 174);
            this.cbxTraslado.Name = "cbxTraslado";
            this.cbxTraslado.Size = new System.Drawing.Size(121, 21);
            this.cbxTraslado.TabIndex = 3;
            this.cbxTraslado.SelectedIndexChanged += new System.EventHandler(this.cbxTraslado_SelectedIndexChanged);
            // 
            // cbxInventario
            // 
            this.cbxInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInventario.FormattingEnabled = true;
            this.cbxInventario.Location = new System.Drawing.Point(134, 246);
            this.cbxInventario.Name = "cbxInventario";
            this.cbxInventario.Size = new System.Drawing.Size(121, 21);
            this.cbxInventario.TabIndex = 6;
            this.cbxInventario.SelectedIndexChanged += new System.EventHandler(this.cbxInventario_SelectedIndexChanged);
            // 
            // txtInventario
            // 
            this.txtInventario.Location = new System.Drawing.Point(285, 248);
            this.txtInventario.Name = "txtInventario";
            this.txtInventario.Size = new System.Drawing.Size(65, 20);
            this.txtInventario.TabIndex = 5;
            this.txtInventario.Tag = "idInventario";
            this.txtInventario.TextChanged += new System.EventHandler(this.txtInventario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código Inventario";
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(134, 320);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(121, 21);
            this.cbxProducto.TabIndex = 9;
            this.cbxProducto.SelectedIndexChanged += new System.EventHandler(this.cbxProducto_SelectedIndexChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(285, 322);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(65, 20);
            this.txtProducto.TabIndex = 8;
            this.txtProducto.Tag = "idProducto";
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Código Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(627, 257);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(134, 395);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(100, 20);
            this.cantidad.TabIndex = 13;
            this.cantidad.Tag = "cantidad";
            // 
            // TrasladoD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1187, 494);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxInventario);
            this.Controls.Add(this.txtInventario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTraslado);
            this.Controls.Add(this.txtTraslado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "TrasladoD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccional Traslado Detalle";
            this.Load += new System.EventHandler(this.TrasladoD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraslado;
        private System.Windows.Forms.ComboBox cbxTraslado;
        private System.Windows.Forms.ComboBox cbxInventario;
        private System.Windows.Forms.TextBox txtInventario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cantidad;
    }
}