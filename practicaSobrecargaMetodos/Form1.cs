using System;
using System.Runtime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaSobrecargaMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Contacto[] a = new Contacto[1];
        int i = 0;

        // Utilizacion del metodo save sin parametros 
        private void btnagregar_Click(object sender, EventArgs e)
        {
            Save();
        }

        // Utilizacion del metodo save con parametros 
        private void btnPathSelect_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt|*.txt";
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            FileInfo f = new FileInfo(sfd.FileName);
            Save(f);
        }

        // SOBRECARGA DE METODOS

        // METODO SIN ARGUMENTOS
        private void Save()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\af339\OneDrive\Desktop\Prueba.txt", true);
            try
            {
                Contacto x = new Contacto();

                if (i < a.Length)
                {
                    x.Nombre = txtboxnombre.Text;
                    x.FechaN = dtpfecha.Value;
                    x.Telefono = txtboxtelefono.Text;
                    x.Correo = txtboxcorreo.Text;
                    a[i] = x;

                    sw.WriteLine(x.ToString());
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            MessageBox.Show("uwu");
            sw.Close();
        }

        // METODO CON ARGUMENTOS
        private void Save(FileInfo f)
        {
            StreamWriter sw = new StreamWriter(f.FullName, true);
            try
            {
                Contacto x = new Contacto();

                if (i < a.Length)
                {
                    x.Nombre = txtboxnombre.Text;
                    x.FechaN = dtpfecha.Value;
                    x.Telefono = txtboxtelefono.Text;
                    x.Correo = txtboxcorreo.Text;
                    a[i] = x;

                    sw.WriteLine(x.ToString());
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
            sw.Close();
        }
    }
}
