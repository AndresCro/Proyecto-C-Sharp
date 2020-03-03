using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cartaToolStripMenuItem.Enabled = false;
        }

        private void créditosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ubicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeshabilitarItem(sugerenciasToolStripMenuItem);
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            cartaToolStripMenuItem.Enabled = false;
            HabilitarItem(ordenToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
        }

        private void ordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ordenToolStripMenuItem.Enabled = false;
            DeshabilitarInicio();
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            pictureBox4.Visible = true;
            label3.Visible = true;
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeshabilitarItem(nosotrosToolStripMenuItem);
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
        }

        private void créditosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            unCheck(entradasToolStripMenuItem1);
            DeshabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            pictureBox3.Visible = true;
            label2.Visible = true;
            DeshabilitarNosotros();
        }

        private void entradasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(ordenToolStripMenuItem);
            Check(entradasToolStripMenuItem1);
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
        }

        private void platillosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            Check(platillosToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
        }

        private void postresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            Check(postresToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(bebidasToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
        }

        private void bebidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeshabilitarInicio();
            HabilitarItem(nosotrosToolStripMenuItem);
            HabilitarItem(ordenToolStripMenuItem);
            HabilitarItem(sugerenciasToolStripMenuItem);
            HabilitarItem(créditosToolStripMenuItem1);
            Check(bebidasToolStripMenuItem1);
            unCheck(entradasToolStripMenuItem1);
            unCheck(platillosToolStripMenuItem1);
            unCheck(postresToolStripMenuItem1);
            DeshabilitarCreditos();
            DeshabilitarNosotros();
        }

        private void DeshabilitarNosotros()
        {
            pictureBox4.Visible = false;
            label3.Visible = false;
        }

        private void DeshabilitarCreditos()
        {
            pictureBox3.Visible = false;
            label2.Visible = false;
        }

        private void DeshabilitarInicio() {
            pictureBox1.Visible = false;
            label1.Visible = false;
            HabilitarItem(cartaToolStripMenuItem);
        }

        private void HabilitarItem(ToolStripMenuItem  opcion) {
            opcion.Enabled = true;
        }

        private void DeshabilitarItem(ToolStripMenuItem opcion)
        {
            opcion.Enabled = false;
        }

        private void unCheck(ToolStripMenuItem casilla) {
            casilla.Checked = false;
        }
        private void Check(ToolStripMenuItem casilla)
        {
            casilla.Checked = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
