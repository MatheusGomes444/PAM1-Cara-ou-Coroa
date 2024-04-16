using CoinFlip.Models;

namespace CoinFlip
{
    public partial class MainPage : ContentPage
    {
        string escolha = "";
        int escolhaResultado = 0;

        public MainPage()
        {
            InitializeComponent();
            CoinPicker.SelectedIndex = 0;
        }

        private void CoinFlipButton_Clicked(System.Object sender, System.EventArgs e)
        {
            //Pegar a opção escolhida e armazenar
            escolha = CoinPicker.SelectedItem.ToString();

            //Sortear um número
            int rnd = new Coin().Girar();

            //Comparar o que o usuário escolheu com o número sorteado
            EscolhaResultado("Cara");

            //Exibe a mensagem de resultado do sorteio
            ExibirMensagem(rnd);

            //Troca a imagem de acordo com o número sorteado
            TrocarImagem(rnd);
        }

        private void EscolhaResultado(string escolhaDoUsuario)
        {
            if (escolha == escolhaDoUsuario)
            {
                escolhaResultado = (int)CoinType.CARA;
            }
            else
            {
                escolhaResultado = (int)CoinType.COROA;
            }
        }
        private void ExibirMensagem(int rnd)
        {
            if (escolhaResultado == rnd)
            {
                ResultLabel.Text = $"Eba, deu {escolha}, você ganhou!";
            }
            else
            {
                ResultLabel.Text = $"Que pena, não deu {escolha}, você perdeu!";
            }
        }

        private void TrocarImagem(int rnd)
        {
            switch (rnd)
            {
                case (int)CoinType.CARA:
                default:
                    CoinImage.Source = "cara.jpg";
                    break;
                case (int)CoinType.COROA:
                    CoinImage.Source = "coroa.jpg";
                    break;
            }
        }
    }
}
