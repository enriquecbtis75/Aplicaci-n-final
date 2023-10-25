using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String name = textBox1.Text;
                String num = textBox5.Text;
                String numem = textBox3.Text;
                String tit = textBox6.Text;
                String dep = textBox2.Text;
                String sal = textBox7.Text;
                String numcuen = textBox4.Text;
                String corre = textBox8.Text;
                MessageBox.Show("\nNombre" + name + "\nNúmero de telefono" + num + "\nNúmero de empleado"
                    + numem + "\n Titulo del puesto" + tit+ "\nDepartamento" + dep + 
                    "\nSalario" + sal + "\n Número de cuenta" + numcuen + "\nCorreo" + corre);
            }
            catch
            {
                MessageBox.Show("Error");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow renglon = (DataGridViewRow)dataestudiante.Rows[0].Clone();
                renglon.Cells[0].Value = textBox1.Text;
                renglon.Cells[1].Value = textBox5.Text;
                renglon.Cells[2].Value = textBox3.Text;
                renglon.Cells[3].Value = textBox6.Text;
                renglon.Cells[4].Value = textBox2.Text;
                renglon.Cells[5].Value = textBox7.Text;
                renglon.Cells[6].Value = textBox4.Text;
                renglon.Cells[7].Value = textBox8.Text;
                

                dataestudiante.Rows.Add(renglon);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Agregando Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
