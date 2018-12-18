using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        public string[,] arreglo = { { "Giovanni"}, { "1234" } };
        private int intentos;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reloj_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) => Application.Exit();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button_log_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == arreglo[0, 0] && textBox2.Text == arreglo[1, 0])
            {
                           
                MessageBox.Show("Bienvenido Giovanni Rodríguez", "Mensaje del Sistema", MessageBoxButtons.OK);
                textBox1.Hide();
                textBox2.Hide();
                label3.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();
                button_log.Hide();
                pictureBox4.Visible = true;
                label4.Visible = true;
                btnInven.Visible = true;
                btnObras.Visible = true;
                btnPresu.Visible = true;
                calcu_ico.Visible = true;
                obraIco.Visible = true;
                invent_ico.Visible = true;

                
               
                    
            }
            else if (intentos == 3)
            {
                MessageBox.Show("Ha alcanzado el número máximo de intentos y su usuario ha sido bloqueado. Para desbloquearlo, por favor contacte al Administrador del Sistema", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                
            }
            else
            {
                intentos += 1;
                MessageBox.Show("Error de autenticación, verifique usuario y/o contraseña. O es posible que su cuenta este inhabilitada", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Text = "";

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {        
            pictureBox4.Visible = false;               
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPresu_Click(object sender, EventArgs e)
        {
            panel_pres.Visible = true;
            panel_obras.Hide();
            panel_inv.Hide();
            panel3_obra_recep.Hide();
            panel_sub1_pres.Hide();
            panel_sub2_request.Hide();
            panel4_obra_List.Hide();
        }

        private void btnObras_Click(object sender, EventArgs e)
        {
            panel_obras.Visible = true;
            panel_pres.Hide();
            panel_inv.Hide();
            panel3_obra_recep.Hide();
            panel_sub1_pres.Hide();
            panel_sub2_request.Hide();
            panel4_obra_List.Hide();
        }

        private void btnInven_Click(object sender, EventArgs e)
        {
            panel_inv.Visible = true;
            panel_pres.Hide();
            panel_obras.Hide();
            panel3_obra_recep.Hide();
            panel_sub1_pres.Hide();
            panel_sub2_request.Hide();
            panel4_obra_List.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncliente_cre_Click(object sender, EventArgs e)
        {
            panel_pres.Visible = true;
            panel_sub1_pres.Visible = false;
            panel_sub2_request.Visible = false;
            panel4_obra_List.Hide();
            panel_insertadatclie.Visible = true;
            panel_pres.Visible = false;
        }

        private void btnpres_cre_Click(object sender, EventArgs e)
        {
            panel_pres.Visible = true;
            panel_sub1_pres.Visible = true;
            panel_sub2_request.Visible = false;
            panel4_obra_List.Hide();
        }

        private void btn_list_pre_Click(object sender, EventArgs e)
        {
            panel_pres.Visible = true;
            panel_sub1_pres.Visible = false;
            panel_sub2_request.Visible = false;
            panel3_obra_recep.Hide();
            panel4_obra_List.Hide();
        }

        private void btn_metric_Click(object sender, EventArgs e)
        {
            panel_pres.Visible = true;
            panel_sub1_pres.Visible = false;
            panel_sub2_request.Visible = false;
            panel3_obra_recep.Hide();
            panel4_obra_List.Hide();
        }

        private void btn_Recep_Click(object sender, EventArgs e)
        {
            panel_obras.Visible = true;
            panel3_obra_recep.Visible = true;
            panel4_obra_List.Hide();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            panel_obras.Visible = true;
            panel3_obra_recep.Hide();
            panel4_obra_List.Visible = true;
        }

        private void btn_Metric_obr_Click(object sender, EventArgs e)
        {
            panel_obras.Visible = true;
            panel3_obra_recep.Hide();
            panel4_obra_List.Hide();
        }

        private void btnlistado_inv_Click(object sender, EventArgs e)
        {
            panel_inv.Visible = true;
        }

        private void btnentrada_inv_Click(object sender, EventArgs e)
        {
            panel_inv.Visible = true;
        }

        private void btnsalidas_inv_Click(object sender, EventArgs e)
        {
            panel_inv.Visible = true;
        }

        private void btnajustes_inv_Click(object sender, EventArgs e)
        {
            panel_inv.Visible = true;
        }

        private void btnmetricas_inv_Click(object sender, EventArgs e)
        {
            panel_inv.Visible = true;
        }

        private void btnInven_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_datos_pres_Click(object sender, EventArgs e)
        {
            panel_sub2_request.Visible = false;
            panel_sub1_pres.Visible = true;
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btn_request_pres_Click(object sender, EventArgs e)
        {
            panel_sub1_pres.Visible = true;
            panel_sub2_request.Visible = true;
        }

        private void btnvertical_Click(object sender, EventArgs e)
        {

        }

        private void CV(object sender, EventArgs e)
        {

        }

        private void btn_segAdm_Click(object sender, EventArgs e)
        {

        }

        private void btn_cierra_clie_cre_Click(object sender, EventArgs e)
        {
            panel_insertadatclie.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
