namespace CapaVistaTraslado
{
    partial class TrasladoE
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
            this.txtIDTrasladoE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBodegaOrigen = new System.Windows.Forms.ComboBox();
            this.txtBodegaO = new System.Windows.Forms.TextBox();
            this.txtBodegaDestino = new System.Windows.Forms.TextBox();
            this.cbxBodegaDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(1, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Traslado Encabezado";
            // 
            // txtIDTrasladoE
            // 
            this.txtIDTrasladoE.Location = new System.Drawing.Point(125, 163);
            this.txtIDTrasladoE.Name = "txtIDTrasladoE";
            this.txtIDTrasladoE.Size = new System.Drawing.Size(100, 20);
            this.txtIDTrasladoE.TabIndex = 2;
            this.txtIDTrasladoE.Tag = "idTrasladoE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bodega Origen";
            // 
            // cbxBodegaOrigen
            // 
            this.cbxBodegaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBodegaOrigen.FormattingEnabled = true;
            this.cbxBodegaOrigen.Location = new System.Drawing.Point(125, 236);
            this.cbxBodegaOrigen.Name = "cbxBodegaOrigen";
            this.cbxBodegaOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbxBodegaOrigen.TabIndex = 4;
            // 
            // txtBodegaO
            // 
            this.txtBodegaO.Location = new System.Drawing.Point(263, 236);
            this.txtBodegaO.Name = "txtBodegaO";
            this.txtBodegaO.Size = new System.Drawing.Size(67, 20);
            this.txtBodegaO.TabIndex = 5;
            this.txtBodegaO.Tag = "bodegaOrigen";
            // 
            // txtBodegaDestino
            // 
            this.txtBodegaDestino.Location = new System.Drawing.Point(264, 308);
            this.txtBodegaDestino.Name = "txtBodegaDestino";
            this.txtBodegaDestino.Size = new System.Drawing.Size(67, 20);
            this.txtBodegaDestino.TabIndex = 8;
            this.txtBodegaDestino.Tag = "bodegaDestino";
            // 
            // cbxBodegaDestino
            // 
            this.cbxBodegaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxBodegaDestino.FormattingEnabled = true;
            this.cbxBodegaDestino.Location = new System.Drawing.Point(126, 308);
            this.cbxBodegaDestino.Name = "cbxBodegaDestino";
            this.cbxBodegaDestino.Size = new System.Drawing.Size(121, 21);
            this.cbxBodegaDestino.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bodega Destino";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Tag = "documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Documento";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(263, 441);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(67, 20);
            this.txtFecha.TabIndex = 12;
            this.txtFecha.Tag = "fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 441);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Location = new System.Drawing.Point(241, 505);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(76, 20);
            this.txtEstatus.TabIndex = 15;
            this.txtEstatus.Tag = "estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtInactivo);
            this.groupBox1.Controls.Add(this.rbtActivo);
            this.groupBox1.Location = new System.Drawing.Point(125, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 77);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(15, 42);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 1;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(15, 19);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 0;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(447, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(685, 293);
            this.dataGridView1.TabIndex = 16;
            // 
            // TrasladoE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 594);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBodegaDestino);
            this.Controls.Add(this.cbxBodegaDestino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBodegaO);
            this.Controls.Add(this.cbxBodegaOrigen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDTrasladoE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Name = "TrasladoE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaccional Traslado Encabezado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDTrasladoE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBodegaOrigen;
        private System.Windows.Forms.TextBox txtBodegaO;
        private System.Windows.Forms.TextBox txtBodegaDestino;
        private System.Windows.Forms.ComboBox cbxBodegaDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}