using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace capaPresentacion
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateButton(5);
            Bloquear();
        }

        private void Bloquear()
        {
 	        btnAgregar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnFinalizar.Enabled = false;
            btnAgregar.BackgroundImage = null;
            btnCancelar.BackgroundImage = null;
            btnEditar.BackgroundImage = null;
            btnFinalizar.BackgroundImage = null;  
        }
        public void CreateButton(int numButtons)
        {
            for(int i = 1; i <= numButtons; i++)
            {
                Button btnAdd = new Button();
                btnAdd.FlatStyle = FlatStyle.Flat;
                btnAdd.FlatAppearance.BorderSize = 0;
                btnAdd.Width = 146;
                btnAdd.Height = 142;
                btnAdd.BackColor = Color.White;
                btnAdd.Text = "09";
                btnAdd.Cursor = Cursors.Hand;
                btnAdd.Text = "" + i;
                flpMesas.Controls.Add(btnAdd);
                btnAdd.Click += new EventHandler(btnAdd_click);

            }
        }//Creación de botón

        private void btnAdd_click(object sender, EventArgs e)
        {
            Menu ventana = new Menu();
            ventana.Show();
            this.Visible = false;
                
        }

        private void frmMesas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
        /*
        public Desbloquear()
        {
            btnAgregar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = true;
            btnFinalizar.Enabled = true;
            btnAgregar.BackgroundImage = Properties.Resources.backbutton;
            btnCancelar.BackgroundImage = Properties.Resources.backbutton;
            btnEditar.BackgroundImage = Properties.Resources.backbutton;
            btnFinalizar.BackgroundImage = Properties.Resources.backbutton;
            btnAgregar.BackColor = Color.Transparent;
            btnCancelar.BackColor = Color.Transparent;
            btnEditar.BackColor = Color.Transparent;
            btnFinalizar.BackColor = Color.Transparent;
        }*/