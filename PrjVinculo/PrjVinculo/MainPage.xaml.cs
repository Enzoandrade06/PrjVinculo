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
    }

}
