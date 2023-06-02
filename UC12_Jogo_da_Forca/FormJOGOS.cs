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
    public partial class FormJOGOS : Form
    {
        int vidas = 6;
        public FormJOGOS()
        {
            InitializeComponent();
           
            labelVIDAS.Text = (vidas - 1 + "");
            endgame();

        }

        private void reiniciar()
        {
            int i = 0;
            vidas = 6;
            labelPALAVRA1.Text = "_";
            labelPALAVRA2.Text = "_";
            labelPALAVRA3.Text = "_";
            labelPALAVRA4.Text = "_";
            labelPALAVRA5.Text = "_";
            labelPALAVRA6.Text = "_";
            labelPALAVRA7.Text = "_";
            labelPALAVRA8.Text = "_";
            labelPALAVRA9.Text = "_";
            labelPALAVRA10.Text = "_";

            for (i = 0; i <= 10; i++)
            {
                Class1.palavra_secreta[i] = "";
            }
            Form FormJogo = new FormSelecao();
            FormJogo.Show();
        }

        private void endgame()
        {
            if (textBoxLETRA.Text != Class1.palavra_secreta[0] && textBoxLETRA.Text != Class1.palavra_secreta[1] && textBoxLETRA.Text != Class1.palavra_secreta[2] && textBoxLETRA.Text != Class1.palavra_secreta[3] && textBoxLETRA.Text != Class1.palavra_secreta[4] && textBoxLETRA.Text != Class1.palavra_secreta[5] && textBoxLETRA.Text != Class1.palavra_secreta[6] && textBoxLETRA.Text != Class1.palavra_secreta[7] && textBoxLETRA.Text != Class1.palavra_secreta[8] && textBoxLETRA.Text != Class1.palavra_secreta[9])
            {
                vidas = vidas - 1;
            }

            if (vidas == 0)
            {
                DialogResult decisao = MessageBox.Show("Você perdeu o jogo! Gostaria de tentar novamente?", "Opção", MessageBoxButtons.YesNo);

                if (decisao == DialogResult.Yes)
                {
                    reiniciar();
                }
                else
                {
                    Form FormJOGOS = new FormJOGOS();
                    FormJOGOS.Show();
                }
                if (textBoxLETRA.Text != Class1.palavra_secreta[0] && textBoxLETRA.Text == Class1.palavra_secreta[1] && textBoxLETRA.Text == Class1.palavra_secreta[2] && textBoxLETRA.Text == Class1.palavra_secreta[3] && textBoxLETRA.Text == Class1.palavra_secreta[4] && textBoxLETRA.Text == Class1.palavra_secreta[5] && textBoxLETRA.Text == Class1.palavra_secreta[6] && textBoxLETRA.Text == Class1.palavra_secreta[7] && textBoxLETRA.Text == Class1.palavra_secreta[8] && textBoxLETRA.Text == Class1.palavra_secreta[9])
                {
                    DialogResult vitoria = MessageBox.Show("Você ganhou o jogo! Parabéns! Gostaria de tentar novamente?", "Opção", MessageBoxButtons.YesNo);

                    if (vitoria == DialogResult.Yes)
                    {
                        reiniciar();
                    }
                    else
                    {
                        Form FormJOGOS = new FormJOGOS();
                        FormJOGOS.Show();
                    }
                }
            }


        }

        private void buttonRESPOSTA_Click(object sender, EventArgs e)
        {


            if (textBoxLETRA.Text == Class1.palavra_secreta[0])
            {
                labelPALAVRA1.Text = Class1.palavra_secreta[0];

            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[1])
            {
                labelPALAVRA2.Text = Class1.palavra_secreta[1];
            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[2])
            {
                labelPALAVRA3.Text = Class1.palavra_secreta[2];

            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[3])
            {
                labelPALAVRA4.Text = Class1.palavra_secreta[3];
            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[4])
            {
                labelPALAVRA5.Text = Class1.palavra_secreta[4];

            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[5])
            {
                labelPALAVRA6.Text = Class1.palavra_secreta[5];
            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[6])
            {
                labelPALAVRA7.Text = Class1.palavra_secreta[6];

            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[7])
            {
                labelPALAVRA8.Text = Class1.palavra_secreta[7];
            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[8])
            {
                labelPALAVRA9.Text = Class1.palavra_secreta[8];

            }

            if (textBoxLETRA.Text == Class1.palavra_secreta[9])
            {
                labelPALAVRA10.Text = Class1.palavra_secreta[9];
            }

            endgame();

        }

        private void buttonREINICIAR_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
    }
}
