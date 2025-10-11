using Maui.Tutorials.Models;
using Maui.Tutorials.ViewModels;

namespace Maui.Tutorials.Pages;

public partial class PokemonPage : ContentPage
{
    //public List<PokemonModel> Pokemons { get; private set; } = new List<PokemonModel>();

    private PokemonViewModel viewModel;

    public PokemonPage()
	{
		InitializeComponent();
        //CreateMonkeyCollection();
        BindingContext = new PokemonViewModel();
    }

    public PokemonPage(PokemonViewModel vm)
    {
        InitializeComponent();
        viewModel = vm;
        BindingContext = vm;
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await viewModel.Load();
        //var items = await  PokemonModel.LoadAsync();
        //Pokemons = new List<PokemonModel>(items);
        //BindingContext = this;
    }

    //void CreateMonkeyCollection()
    //{
    //    Pokemons = new List<PokemonModel>();

    //    Pokemons.Add(new PokemonModel
    //    {
    //        Name = "Baboon",
    //        Location = "Africa & Asia",
    //        Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
    //        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
    //    });

    //    Pokemons.Add(new PokemonModel
    //    {
    //        Name = "Capuchin Monkey",
    //        Location = "Central & South America",
    //        Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
    //        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
    //    });

    //    Pokemons.Add(new PokemonModel
    //    {
    //        Name = "Blue Monkey",
    //        Location = "Central and East Africa",
    //        Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia",
    //        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
    //    });
    //}

}