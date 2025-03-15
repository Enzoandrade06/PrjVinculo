namespace PrjVinculo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void bntProduto_Clicked(object sender, EventArgs e)
        {

        }

        private void btnProduto_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Camiseta Real Madrid";
            produto.Preco = 900;
            produto.Categoria = "Vestimenta";
            Navigation.PushAsync(new ProdutoPage() {BindingContext = produto});
        }

        private void btnProduto2_Clicked(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Descricao = "Camiseta PSG";
            produto.Preco = 500;
            produto.Categoria = "Vestimenta";
            Navigation.PushAsync(new ProdutoPage2() {BindingContext = produto});
        }

        private void btnCelular1_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Samsumg";
            celular.Numero = 11912345678;
            celular.Operadora = "Vivo";
            celular.Capinha = "Sim";
            celular.Imei = "354865095206314";
            Navigation.PushAsync(new ProdutoPage() { BindingContext = celular });
        }

        private void btnCelular2_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Motorola";
            celular.Numero = 21987654321;
            celular.Operadora = "Vivo";
            celular.Capinha = "Sim";
            celular.Imei = "869852032015682";
            Navigation.PushAsync(new ProdutoPage() { BindingContext = celular });
        }

        private void btnCelular4_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Xiaomi";
            celular.Numero = 31998765432;
            celular.Operadora = "Vivo";
            celular.Capinha = "Sim";
            celular.Imei = "351832074213960";
            Navigation.PushAsync(new ProdutoPage() { BindingContext = celular });
        }

        private void btnCelular3_Clicked(object sender, EventArgs e)
        {
            Celular celular = new Celular();

            celular.Marca = "Iphone";
            celular.Numero = 41963257485;
            celular.Operadora = "Vivo";
            celular.Capinha = "Sim";
            celular.Imei = "358198072419509";
            Navigation.PushAsync(new ProdutoPage() { BindingContext = celular });
        }
    }

}
