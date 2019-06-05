using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaLogica;

namespace capaPresentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmMesas ventana = new frmMesas();
            ventana.Visible = true;
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            frmMesas ventana = new frmMesas();
            ventana.Visible = true;
        }

        private void FlowLayoutPanel2_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            ControllerProducto enlace = new ControllerProducto();
            dgvAlmuerzo.DataSource = enlace.listarProductos(1);
            for(int i = 0; i < dgvAlmuerzo.RowCount; i++)
            {
                string image = dgvAlmuerzo.Rows[i].Cells[0].Value.ToString();
                dgvAlmuerzo.Columns.RemoveAt(0);
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                //imageColumn.Image = Image.FromFile(@"" + image);
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvAlmuerzo.Columns.Insert(0, imageColumn);
            }
        }
    }
}
