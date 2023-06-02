using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC12_Jogo_da_Forca
{
    public partial class FormSelecao : Form
    {
        public FormSelecao()
        {
            InitializeComponent();
        }

      

        private void button_ENVIAR_Click(object sender, EventArgs e)
        {
            if (textBox_DEFINIR.Text.Length <= 10)
            {
                for (Class1.i = 0; Class1.i < textBox_DEFINIR.Text.Length; Class1.i++)
                {

                    Class1.palavra_secreta[Class1.i] = textBox_DEFINIR.Text.Substring(Class1.i, 1);


                }

            }

            Form FormJogo = new FormJOGOS();
            FormJogo.Show();
        }
    }
}
