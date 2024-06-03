using Pokedex.Models;
using Pokedex.Servicios;

namespace Pokedex;

public partial class ResumenPokemon : ContentPage
{
	CaracteristicasPokemon caracteristicas =new CaracteristicasPokemon();
	public ResumenPokemon(string url)
	{
		InitializeComponent();
		CargaPokemon(url);

	}
	public async void CargaPokemon(string url) {
		PokemonAPIs poke_services=new PokemonAPIs();
		caracteristicas = await poke_services.DevuelveCaracteristicasPokemon(url);
		ImagenPokemon.Source= caracteristicas.sprites.front_default;
		string habilidades = "";
		foreach (var ability in caracteristicas.abilities) {
			habilidades += ability.ability.name + "!";
		}
		Habilidades.Text=habilidades;
	}

}