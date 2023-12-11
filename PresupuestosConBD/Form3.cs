using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresupuestosConBD
{
    public partial class Form3 : Form
    {
        public Form3(string cadenaconex)
        {
            InitializeComponent();
            fecha.CustomFormat = "dd/MM/yyyy";
        }
    }
}
