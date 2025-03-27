namespace PrjVinculo;

public partial class ListaProdutoPage : ContentPage
{
	public ListaProdutoPage()
	{
		InitializeComponent();
		List<Produto> lista = new List<Produto>();

		lista.Add(
			new Produto
			{
				Categoria = "Vestimenta",
				Descricao = "Camiseta Corinthians",
				Preco = 700
			}
			);
		lista.Add(
			new Produto
			{
				Categoria = "Instrumento",
				Descricao = "Violino",
				Preco = 1800
			}
			);
		lista.Add(
			new Produto
			{
				Categoria = "Lazer",
				Descricao = "Puff",
				Preco = 349
			}
	);
		
		ListaProduto.ItemsSource = lista;
	}

    private void ViewCell_Tapped(object sender, EventArgs e)
    {
        var context = (sender as ViewCell).BindingContext;
		Navigation.PushAsync(new PagProduto { BindingContext = context});
		
    }
}