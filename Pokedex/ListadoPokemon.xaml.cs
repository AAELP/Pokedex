using Pokedex.Models;
using Pokedex.Servicios;

namespace Pokedex;

public partial class ListadoPokemon : ContentPage
{
	public List<PokemonInfo> listado_pokemones;

	public ListadoPokemon()
	{
		InitializeComponent();
		LoadData();
	}

	public async void LoadData() { 
	
		PokemonAPIs _poke_apis = new PokemonAPIs();
		listado_pokemones = await _poke_apis.DevuelveListadoPokemones();
		PokemonList.ItemsSource = listado_pokemones;

	}
	public void MuestraResumenPokemon(object sender,SelectedItemChangedEventArgs e) {
		

		PokemonInfo poke_
		Navigation.PushAsync(new ResumenPokemon());
	
	}
}