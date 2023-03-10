using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaSobrecargaMetodos
{
    internal class Contacto : Persona
    {
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set
            {
                telefono = value.Replace(" ", "").Replace("-", "");

            }
        }
        public string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        // CONSTRUCTORS
        public Contacto() : base()
        {
            telefono = string.Empty;
            correo = string.Empty;
        }
        public Contacto(string nombre, DateTime? fechaN, string telefono, string correo) : base(nombre, fechaN)
        {
            this.telefono = telefono;
            this.correo = correo;
        }

        ~Contacto()
        {
            MessageBox.Show("destructr called");
            // DESTRUCTOR 
        }

        public override string ToString()
        {
            return base.ToString() + " " + telefono + " " + correo;
        }
    }
}
