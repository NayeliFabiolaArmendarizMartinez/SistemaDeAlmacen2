using SistemaDeAlmacen2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAlmacen2
{
    public partial class FrmProductos : Form
    {
        public int id;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
            TodosProductos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    
                    var productos = context.ProductosAlmacen.First(x => x.Id == id);
                    if (productos != null)
                    {
                        productos.Producto = txtProductos.Text;
                        productos.Cantidad = int.Parse(txtCantidad.Text);
                        productos.Categoria = rbtnComestibles.Checked ? "Comestible" : "Material";
                        productos.FechaIngreso = dtpFechaIngreso.Value.Date;
                        productos.PrecioCompra = double.Parse(txtPrecioCompra.Text);
                        productos.PrecioVenta = double.Parse(txtPrecioVenta.Text);

                        context.SaveChanges();

                        TodosProductos();
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                if (id != 0)
                {
                    
                    var productos = context.ProductosAlmacen.First(x => x.Id == id);
                    if (productos != null)
                    {
                        context.Remove(productos);
                        context.SaveChanges();

                        TodosProductos();
                    }
                }

            }
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            TodosProductos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void AgregarProducto()
        {
            using (var context = new ApplicationDbContext())
            {

                var productos = new ProductosAlmacen();
                productos.Producto = txtProductos.Text;
                productos.Cantidad = int.Parse(txtCantidad.Text);
                productos.Categoria = rbtnComestibles.Checked ? "Comestible" : "Material";
                productos.FechaIngreso = dtpFechaIngreso.Value.Date;
                productos.PrecioCompra = double.Parse(txtPrecioCompra.Text);
                productos.PrecioVenta = double.Parse(txtPrecioVenta.Text);

                context.ProductosAlmacen.Add(productos);

                context.SaveChanges();

            }
        }
        private void TodosProductos()
        {
            using (var context = new ApplicationDbContext())
            {
                var productos = context.ProductosAlmacen.ToList();
                dgvProductos.DataSource = productos;
            }
        }

        private void BuscarProducto()
        {

            using (var context = new ApplicationDbContext())
            {
                var productos = context.ProductosAlmacen.Where(x => x.Producto.Contains(txtBuscar.Text)).ToList();
                dgvProductos.DataSource = productos;
            }

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());
            txtProductos.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            if (dgvProductos.CurrentRow.Cells[3].Value.ToString() == "Comestibles")
            {
                rbtnComestibles.Checked = true;
            }
            else
            {
                rbtnMateriales.Checked = true;
            }
            dtpFechaIngreso.Value = Convert.ToDateTime(dgvProductos.CurrentRow.Cells[4].Value.ToString());
            txtPrecioCompra.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            txtPrecioVenta.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
