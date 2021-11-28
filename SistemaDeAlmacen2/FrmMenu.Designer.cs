
namespace SistemaDeAlmacen2
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.lbProductos = new System.Windows.Forms.Label();
            this.lbClientes = new System.Windows.Forms.Label();
            this.lbProveedores = new System.Windows.Forms.Label();
            this.lbInventario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Location = new System.Drawing.Point(118, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(576, 58);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Sistema de Almacen";
            // 
            // BtnProductos
            // 
            this.BtnProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProductos.BackgroundImage")));
            this.BtnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProductos.Location = new System.Drawing.Point(36, 157);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(170, 155);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClientes.BackgroundImage")));
            this.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClientes.Location = new System.Drawing.Point(228, 157);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(170, 155);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.UseVisualStyleBackColor = true;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnProveedores.BackgroundImage")));
            this.BtnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProveedores.Location = new System.Drawing.Point(425, 157);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(170, 155);
            this.BtnProveedores.TabIndex = 3;
            this.BtnProveedores.UseVisualStyleBackColor = true;
            // 
            // BtnInventario
            // 
            this.BtnInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInventario.BackgroundImage")));
            this.BtnInventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInventario.Location = new System.Drawing.Point(618, 157);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(170, 155);
            this.BtnInventario.TabIndex = 4;
            this.BtnInventario.UseVisualStyleBackColor = true;
            // 
            // lbProductos
            // 
            this.lbProductos.AutoSize = true;
            this.lbProductos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProductos.Location = new System.Drawing.Point(71, 100);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(101, 24);
            this.lbProductos.TabIndex = 5;
            this.lbProductos.Text = "Productos";
            this.lbProductos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbClientes
            // 
            this.lbClientes.AutoSize = true;
            this.lbClientes.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbClientes.Location = new System.Drawing.Point(276, 100);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(81, 24);
            this.lbClientes.TabIndex = 6;
            this.lbClientes.Text = "Clientes";
            // 
            // lbProveedores
            // 
            this.lbProveedores.AutoSize = true;
            this.lbProveedores.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbProveedores.Location = new System.Drawing.Point(447, 100);
            this.lbProveedores.Name = "lbProveedores";
            this.lbProveedores.Size = new System.Drawing.Size(122, 24);
            this.lbProveedores.TabIndex = 7;
            this.lbProveedores.Text = "Proveedores";
            this.lbProveedores.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbInventario
            // 
            this.lbInventario.AutoSize = true;
            this.lbInventario.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbInventario.Location = new System.Drawing.Point(652, 100);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.Size = new System.Drawing.Size(102, 24);
            this.lbInventario.TabIndex = 8;
            this.lbInventario.Text = "Inventario";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(826, 347);
            this.Controls.Add(this.lbInventario);
            this.Controls.Add(this.lbProveedores);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.lbProductos);
            this.Controls.Add(this.BtnInventario);
            this.Controls.Add(this.BtnProveedores);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.lbTitulo);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Label lbProductos;
        private System.Windows.Forms.Label lbClientes;
        private System.Windows.Forms.Label lbProveedores;
        private System.Windows.Forms.Label lbInventario;
    }
}