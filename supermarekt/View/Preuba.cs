using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermarekt.View
{
    public partial class Preuba : Form
    {
        public Preuba(string nombre)
        {
            InitializeComponent();
            comboBox1.Items.Add(nombre); // agregamos el nombre al comboBox1
            comboBox1.SelectedIndex = 0; // seleccionamos el primer elemento del comboBox1
        }
        private void Preuba_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
