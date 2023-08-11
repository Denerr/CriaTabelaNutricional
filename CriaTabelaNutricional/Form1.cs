using Microsoft.VisualBasic.Devices;

namespace Prototipo_CriaTabelaNutri
{
    public partial class frmCriaTabelaNutri : Form
    {
        public frmCriaTabelaNutri()
        {
            InitializeComponent();
        }

        public void validaAltoTeor()
        {
            double validaAcucarAdicionado, validaGorduraSaturada, validaSodio, validaPorcao;
            double acucarAcidicionado, gorduraSaturada, sodio, porcao;

            porcao = Double.Parse(txtPorcao.Text);
            acucarAcidicionado = Double.Parse(txtAcucaresAdicionados.Text);
            gorduraSaturada = Double.Parse(txtGordurasSaturadas.Text);
            sodio = Double.Parse(txtSodio.Text);

            validaPorcao = porcao / 100;
            validaAcucarAdicionado = acucarAcidicionado / validaPorcao;
            validaGorduraSaturada = gorduraSaturada / validaPorcao;
            validaSodio = sodio / validaPorcao;

            if (cmbPorcaoUnidade.SelectedItem.ToString() == "Gramas(g)")
            {
                if (validaAcucarAdicionado >= 15)
                {
                    ckbAltoAcucarAdicionado.Checked = true;
                }
                else
                {
                    ckbAltoAcucarAdicionado.Checked = false;
                }
                if (validaGorduraSaturada >= 6)
                {
                    ckbAltoGorduraSaturada.Checked = true;
                }
                else
                {
                    ckbAltoGorduraSaturada.Checked = false;
                }
                if (validaSodio >= 0.6)
                {
                    ckbAltoSodio.Checked = true;
                }
                else
                {
                    ckbAltoSodio.Checked = false;
                }
            }
        }

        public void habilitaLactoseGalactose()
        {
            if (ckbImprimeLactoseGalactose.Checked)
            {
                txtLactose.Enabled = true;
                txtGalactose.Enabled = true;
            }
            else
            {
                txtGalactose.Enabled = false;
                txtLactose.Enabled = false;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            validaAltoTeor();
        }

        private void ckbImprimeLactoseGalactose_CheckedChanged(object sender, EventArgs e)
        {
            habilitaLactoseGalactose();
        }
    }
}