using System;
using System.Windows.Forms;

namespace Tabela_de_Pontos
{
    public partial class FrmPonto : Form
    {
        public FrmPonto()
        {
            InitializeComponent();
        }
        private void FrmPonto_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bem vindo ao programa, para saber como ele funciona, pressione o botão Instruções.", "Saudações", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Mensagem de boas vindas, apresentada antes de iniciar o programa
            //Instrui o usuário em como utilizar o programa
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close(); 
            //Encerra o programa
        }

        private void btnInstrucoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O programa funciona da seguinte maneira, você deve preencher os seguintes campos: Placar, Mínimo Temporada e Máximo Temporada. O campo Jogo será preenchido automaticamente pelo programa. " + "\n" + "\n" +
                "Em seguida, você deve pressionar o botão 'Novo Jogo', fazendo com que os dados informados sejam marcados no campo ao lado." + "\n" + "\n" +
                "O botão 'Limpar' irá apagar TODOS os dados inseridos." + "\n" + "\n" +
                "O botão 'Sair' irá encerrar o programa." + "\n" + "\n" +
                "O botão 'Pesquisar' irá procurar o número do jogo que você procura, basta informar o jogo no campo 'Insira o jogo a ser pesquisado'.", "Instruções", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Exibe todas as instruções de utilização do programa
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtJogo.Text = "1";
            txtPlacar.Text = "0";
            txtMin.Text = "0";
            txtMax.Text = "0";
            txtQRMin.Text = "0";
            txtQRMax.Text = "0";
            txtPesquisa.Text = "Jogo nº";
            lstDados.Items.Clear();
            //Formata todo o programa, redefinindo todas as textBox para o padrão e limpando a listBox
        }

        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            int jogo, placar, min, max, QRMin, QRMax, i; 
            //Declara todas as variáveis
            jogo = Convert.ToInt16(txtJogo.Text);
            placar = Convert.ToInt16(txtPlacar.Text);
            min = Convert.ToInt16(txtMin.Text);
            max = Convert.ToInt16(txtMax.Text);
            QRMin = Convert.ToInt16(txtQRMin.Text);
            QRMax = Convert.ToInt16(txtQRMax.Text);
            i = Convert.ToInt16(txtJogo.Text); 
            //Converte as variáveis inseridas pelo usuário
            lstDados.Items.Add("Jogo nº" + jogo + ".");
            lstDados.Items.Add("Seu placar foi de: " + placar + " pontos.");
            lstDados.Items.Add("Seu mínimo nesta temporada foi: " + min + " pontos.");
            lstDados.Items.Add("Seu máximo nesta temporada foi: " + max + " pontos.");
            lstDados.Items.Add("Seu recorde mínimo quebrado foi: " + QRMin + " pontos.");
            lstDados.Items.Add("Seu recorde máximo quebrado foi: " + QRMax + " pontos.");
            //Adiciona informações na listBox
            lstDados.Items.Add("\n"); 
            //Adiciona uma linha em branco na listBox
            i++;
            //Incrementa o valor de i (Jogo nº)
            txtJogo.Text = "" + i;
            //Informa o jogo a ser preenchido
            //i++ & txtJogo.Text = "" + i; fazem a seguinte operação: Aumentam o valor de "jogo" automaticamente, em ordem crescente
            MessageBox.Show("Jogo registrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int Pesquisa = lstDados.FindString(txtPesquisa.Text); 
            //Define variável e pesquisa na listBox os dados da textBox txtPesquisa
            if (Pesquisa != -1) //Se encontrar o valor solicitado, leva o usuário até ele
                lstDados.SetSelected(Pesquisa, true);
            else
                MessageBox.Show("A pesquisa não localizou o jogo informado, certifique-se de que o valor foi informado.", "Erro na pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //Caso contrário, retorna erro informando que não foi localizado o jogo
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.TextLength <= 7)
            {
                txtPesquisa.Text = "Jogo nº"; 
                //Bloqueia o usuário de apagar as informações
            }
        }

        private void txtPlacar_TextChanged(object sender, EventArgs e)
        {
            if (txtPlacar.TextLength <= 0)
            {
                txtPlacar.Text = "0"; //Bloqueia o usuário de apagar as informações
            }
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            if (txtMin.TextLength <= 0)
            {
                txtMin.Text = "0"; //Bloqueia o usuário de apagar as informações
            }
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            if (txtMax.TextLength <= 0)
            {
                txtMax.Text = "0"; //Bloqueia o usuário de apagar as informações
            }
        }

        private void txtQRMin_TextChanged(object sender, EventArgs e)
        {
            if (txtQRMin.TextLength <= 0)
            {
                txtQRMin.Text = "0"; //Bloqueia o usuário de apagar as informações
            }
        }

        private void txtQRMax_TextChanged(object sender, EventArgs e)
        {
            if (txtQRMax.TextLength <= 0)
            {
                txtQRMax.Text = "0"; //Bloqueia o usuário de apagar as informações
            }
        }

        private void txtPlacar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Verifica se os valores digitados são apenas números
            }
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Verifica se os valores digitados são apenas números
            }
        }

        private void txtMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Verifica se os valores digitados são apenas números
            }
        }

        private void txtQRMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Verifica se os valores digitados são apenas números
            }
        }

        private void txtQRMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Verifica se os valores digitados são apenas números
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; //Verifica se os valores digitados são apenas números
            }
        }
    }
}
