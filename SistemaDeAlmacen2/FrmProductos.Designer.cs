
namespace SistemaDeAlmacen2
{
    partial class FrmProductos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTituloProductos = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPCompra = new System.Windows.Forms.Label();
            this.lbPVenta = new System.Windows.Forms.Label();
            this.txtProductos = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.rbtnComestibles = new System.Windows.Forms.RadioButton();
            this.rbtnMateriales = new System.Windows.Forms.RadioButton();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 49);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(394, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // lbTituloProductos
            // 
            this.lbTituloProductos.AutoSize = true;
            this.lbTituloProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTituloProductos.ForeColor = System.Drawing.Color.Navy;
            this.lbTituloProductos.Location = new System.Drawing.Point(44, 68);
            this.lbTituloProductos.Name = "lbTituloProductos";
            this.lbTituloProductos.Size = new System.Drawing.Size(58, 19);
            this.lbTituloProductos.TabIndex = 0;
            this.lbTituloProductos.Text = "Datos ";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProducto.Location = new System.Drawing.Point(1, 87);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(49, 16);
            this.lbProducto.TabIndex = 1;
            this.lbProducto.Text = "Producto";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCantidad.Location = new System.Drawing.Point(2, 132);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(49, 16);
            this.lbCantidad.TabIndex = 2;
            this.lbCantidad.Text = "Cantidad";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCategoria.Location = new System.Drawing.Point(2, 177);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(53, 16);
            this.lbCategoria.TabIndex = 3;
            this.lbCategoria.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha en que se adquirio el producto";
            // 
            // lbPCompra
            // 
            this.lbPCompra.AutoSize = true;
            this.lbPCompra.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPCompra.Location = new System.Drawing.Point(1, 288);
            this.lbPCompra.Name = "lbPCompra";
            this.lbPCompra.Size = new System.Drawing.Size(90, 16);
            this.lbPCompra.TabIndex = 5;
            this.lbPCompra.Text = "Precio de compra";
            // 
            // lbPVenta
            // 
            this.lbPVenta.AutoSize = true;
            this.lbPVenta.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPVenta.Location = new System.Drawing.Point(1, 333);
            this.lbPVenta.Name = "lbPVenta";
            this.lbPVenta.Size = new System.Drawing.Size(81, 16);
            this.lbPVenta.TabIndex = 6;
            this.lbPVenta.Text = "Precio de venta";
            // 
            // txtProductos
            // 
            this.txtProductos.Location = new System.Drawing.Point(2, 106);
            this.txtProductos.Name = "txtProductos";
            this.txtProductos.Size = new System.Drawing.Size(183, 23);
            this.txtProductos.TabIndex = 7;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(1, 352);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(183, 23);
            this.txtPrecioVenta.TabIndex = 8;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(1, 307);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(183, 23);
            this.txtPrecioCompra.TabIndex = 9;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(1, 151);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(184, 23);
            this.txtCantidad.TabIndex = 10;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(2, 262);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(184, 23);
            this.dtpFechaIngreso.TabIndex = 11;
            // 
            // rbtnComestibles
            // 
            this.rbtnComestibles.AutoSize = true;
            this.rbtnComestibles.Location = new System.Drawing.Point(1, 196);
            this.rbtnComestibles.Name = "rbtnComestibles";
            this.rbtnComestibles.Size = new System.Drawing.Size(90, 19);
            this.rbtnComestibles.TabIndex = 12;
            this.rbtnComestibles.TabStop = true;
            this.rbtnComestibles.Text = "Comestibles";
            this.rbtnComestibles.UseVisualStyleBackColor = true;
            // 
            // rbtnMateriales
            // 
            this.rbtnMateriales.AutoSize = true;
            this.rbtnMateriales.Location = new System.Drawing.Point(1, 221);
            this.rbtnMateriales.Name = "rbtnMateriales";
            this.rbtnMateriales.Size = new System.Drawing.Size(79, 19);
            this.rbtnMateriales.TabIndex = 13;
            this.rbtnMateriales.TabStop = true;
            this.rbtnMateriales.Text = "Materiales";
            this.rbtnMateriales.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Navy;
            this.BtnAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.Location = new System.Drawing.Point(2, 428);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(183, 32);
            this.BtnAgregar.TabIndex = 16;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Navy;
            this.BtnModificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.Location = new System.Drawing.Point(1, 466);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(183, 32);
            this.BtnModificar.TabIndex = 17;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Navy;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(1, 499);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(183, 32);
            this.BtnEliminar.TabIndex = 18;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(204, 87);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(669, 435);
            this.dgvProductos.TabIndex = 19;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbBuscar.ForeColor = System.Drawing.Color.Navy;
            this.lbBuscar.Location = new System.Drawing.Point(279, 65);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(64, 19);
            this.lbBuscar.TabIndex = 20;
            this.lbBuscar.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(360, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(437, 23);
            this.txtBuscar.TabIndex = 21;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(885, 543);
            this.Controls.Add(this.rbtnMateriales);
            this.Controls.Add(this.rbtnComestibles);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtProductos);
            this.Controls.Add(this.lbPVenta);
            this.Controls.Add(this.lbPCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTituloProductos);
            this.Name = "FrmProductos";
            this.Text = "FrmProductos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTituloProductos;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPCompra;
        private System.Windows.Forms.Label lbPVenta;
        private System.Windows.Forms.TextBox txtProductos;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.RadioButton rbtnComestibles;
        private System.Windows.Forms.RadioButton rbtnMateriales;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lbBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}