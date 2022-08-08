using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Codigo;
            int Cantidad;
            string Nombre;
            float Precio;

            Codigo = cmbProducto.SelectedIndex;
            Nombre = cmbProducto.SelectedItem.ToString();
            Precio = cmbProducto.SelectedIndex;
            Cantidad = cmbProducto.SelectedIndex;
             
            switch (Codigo)
            {
                case 0: lblCodigo.Text = "7034"; break;
                case 1: lblCodigo.Text = "2101"; break;
                case 2: lblCodigo.Text = "1010"; break;
                case 3: lblCodigo.Text = "2356"; break;
                case 4: lblCodigo.Text = "4895"; break;
                case 5: lblCodigo.Text = "6231"; break;
                case 6: lblCodigo.Text = "1245"; break;
                case 7: lblCodigo.Text = "3526"; break;
                case 8: lblCodigo.Text = "3215"; break;
                case 9: lblCodigo.Text = "4698"; break;
                case 10: lblCodigo.Text = "6475"; break;
                case 11: lblCodigo.Text = "3265"; break;
                case 12: lblCodigo.Text = "4115"; break;
                case 13: lblCodigo.Text = "4242"; break;
                case 14: lblCodigo.Text = "3535"; break;
                case 15: lblCodigo.Text = "6598"; break;
                case 26: lblCodigo.Text = "5050"; break;
                case 27: lblCodigo.Text = "3578"; break;
                default: lblCodigo.Text = "0726"; break;
            }
            switch (Nombre)
            {
                case "Arandano": lblNombre.Text = "Arandano"; break;
                case "Carambola": lblNombre.Text = "Carambola"; break;
                case "Cereza": lblNombre.Text = "Cereza"; break;
                case "Ciruela": lblNombre.Text = "Ciruela"; break;
                case "Coco": lblNombre.Text = "Coco"; break;
                case "Frambuesa": lblNombre.Text = "Frambuesa"; break;
                case "Fresa": lblNombre.Text = "Fresa"; break;
                case "Kiwi": lblNombre.Text = "Kiwi"; break;
                case "Limon": lblNombre.Text = "Limon"; break;
                case "Mandarina": lblNombre.Text = "Mandarina"; break;
                case "Mango": lblNombre.Text = "Mango"; break;
                case "Manzana": lblNombre.Text = "Manzana"; break;
                case "Melocoton": lblNombre.Text = "Melocoton"; break;
                case "Melon": lblNombre.Text = "Melon"; break;
                case "Naranja": lblNombre.Text = "Naranja"; break;
                case "Pera": lblNombre.Text = "Pera"; break;
                case "Piña": lblNombre.Text = "Piña"; break;
                case "Sandia": lblNombre.Text = "Sandia"; break;
                default: lblNombre.Text = "Uva"; break;
            }
            switch (Codigo)
            {
                case 0: lblPrecio.Text = "25.00"; break;
                case 1: lblPrecio.Text = "08.50"; break;
                case 2: lblPrecio.Text = "60.75"; break;
                case 3: lblPrecio.Text = "50.55"; break;
                case 4: lblPrecio.Text = "94.99"; break;
                case 5: lblPrecio.Text = "30.00"; break;
                case 6: lblPrecio.Text = "20.35"; break;
                case 7: lblPrecio.Text = "07.10"; break;
                case 8: lblPrecio.Text = "10.98"; break;
                case 9: lblPrecio.Text = "5.98"; break;
                case 10: lblPrecio.Text = "35.65"; break;
                case 11: lblPrecio.Text = "70.00"; break;
                case 12: lblPrecio.Text = "55.95"; break;
                case 13: lblPrecio.Text = "15.32"; break;
                case 14: lblPrecio.Text = "28.38"; break;
                case 15: lblPrecio.Text = "45.95"; break;
                case 16: lblPrecio.Text = "60.05"; break;
                case 17: lblPrecio.Text = "70.20"; break;
                default: lblPrecio.Text = "120,00"; break;
            }
            switch (Cantidad)
            {
                case 0: txtCantidad.Text = "1"; break;
                case 1: txtCantidad.Text = "1"; break;
                case 2: txtCantidad.Text = "1"; break;
                case 3: txtCantidad.Text = "1"; break;
                case 4: txtCantidad.Text = "1"; break;
                case 5: txtCantidad.Text = "1"; break;
                case 6: txtCantidad.Text = "1"; break;
                case 7: txtCantidad.Text = "1"; break;
                case 8: txtCantidad.Text = "1"; break;
                case 9: txtCantidad.Text = "1"; break;
                case 10: txtCantidad.Text = "1"; break;
                case 11: txtCantidad.Text = "1"; break;
                case 12: txtCantidad.Text = "1"; break;
                case 13: txtCantidad.Text = "1"; break;
                case 14: txtCantidad.Text = "1"; break;
                case 15: txtCantidad.Text = "1"; break;
                case 16: txtCantidad.Text = "1"; break;
                case 17: txtCantidad.Text = "1"; break;
                default: txtCantidad.Text = "1"; break;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvLista);

            file.Cells[0].Value = lblCodigo.Text;
            file.Cells[1].Value = lblNombre.Text;
            file.Cells[2].Value = lblPrecio.Text;
            file.Cells[3].Value = txtCantidad.Text;

            if (lblCodigo.Text == "" || lblNombre.Text == "" || lblPrecio.Text == "" || txtCantidad.Text == "")
            {
                MessageBox.Show("Uno de los campos está vacío", ".:AVISO:.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            file.Cells[4].Value = (float.Parse(lblPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();
            
            dgvLista.Rows.Add(file);


            obtenerTotal();
        }
        public void obtenerTotal()
        {
            float costot = 0;
            int contador = 0;

            contador = dgvLista.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costot += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }
            lblTotatlPagar.Text = costot.ToString();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dgvLista.Rows.Remove(dgvLista.CurrentRow);
                }
            }
            catch { }
            obtenerTotal();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotatlPagar.Text)).ToString();
            }
            catch { }
            if (txtEfectivo.Text == "")
            {
                lblDevolucion.Text = "";
            }
        }
        private void txtEfectivo_TextChanged(object sender, KeyPressEventArgs x)
        {
            if ((x.KeyChar >= 32 && x.KeyChar <= 47) || (x.KeyChar >= 58 && x.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITE LA ENTRADA DE NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                x.Handled = true;
                return;
            }
        }
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (lblDevolucion.Text == "Insuficiente")
            {
                MessageBox.Show("EL DINERO INGRESADO ES MENOR AL TOTAL A PAGAR", ".:ALERTA:.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // e.Handled = true;
                return;
            }
            else
            {
                clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

                Ticket1.TextoCentro("********************************");
                Ticket1.TextoCentro("J A K E D O ' S");
                Ticket1.TextoCentro("F R U I T S");
                Ticket1.TextoCentro("********************************");

                Ticket1.TextoIzquierda("");
                Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
                Random aleatorio = new Random();
                long numFactura = aleatorio.Next(100000, 999999999);
                Ticket1.TextoIzquierda("No Fac: " + numFactura);
                Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
                Ticket1.TextoIzquierda("Le Atendio: " + Login.NombreEmpleado);
                Ticket1.TextoIzquierda("");
                clsFactura.CreaTicket.LineasGuion();

                clsFactura.CreaTicket.EncabezadoVenta();
                clsFactura.CreaTicket.LineasGuion();
                foreach (DataGridViewRow r in dgvLista.Rows)
                {
                    // PROD                     //PrECIO                                    CANT                         TOTAL
                    Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
                }
                clsFactura.CreaTicket.LineasGuion();
                Ticket1.TextoIzquierda(" ");
                Ticket1.AgregaTotales("Total", double.Parse(lblTotatlPagar.Text)); // imprime linea con total
                Ticket1.TextoIzquierda(" ");

                if (txtEfectivo.Text == "")
                {
                    MessageBox.Show("NO SE HA INGRESADO LA CANTIDAD DE EFECTIVO.", ".:AVISO:.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }

                Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
                Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));
                clsFactura.CreaTicket.LineasGuion();

                // Ticket1.LineasTotales(); // imprime linea 

                Ticket1.TextoIzquierda(" ");
                Ticket1.TextoCentro("=================================");
                Ticket1.TextoCentro("=     Gracias por preferirnos   =");

                Ticket1.TextoCentro("=================================");
                Ticket1.TextoIzquierda(" ");
                string impresora = "Microsoft XPS Document Writer";
                Ticket1.ImprimirTiket(impresora);

                MessageBox.Show("Gracias por preferirnos");
                dgvLista.Rows.Clear();
                lblTotatlPagar.Text = "";
                lblDevolucion.Text = "";
                lblCodigo.Text = "";
                lblNombre.Text = "";
                lblPrecio.Text = "";
                txtCantidad.Text = "1";
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO SE PERMITE LA ENTRADA DE NUMEROS", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void lblDevolucion_Click(object sender, EventArgs e)
        {

        }
        private void lblDevolucion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(txtEfectivo.Text) >= float.Parse(lblTotatlPagar.Text))
                {

                    lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotatlPagar.Text)).ToString();
                }

                else
                {
                    try
                    {
                        lblDevolucion.Text = "Insuficiente";
                    }
                    catch { }
                }

            }
            catch { txtEfectivo.Text = "0"; txtEfectivo.Focus(); }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea volver atras?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    Menu Menu1 = new Menu();
                    this.Hide();
                    Menu1.ShowDialog();
                    this.Close();
                }
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, EventArgs e)
        {

        }
    }
}