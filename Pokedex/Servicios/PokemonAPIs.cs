using Newtonsoft.Json;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Servicios
{
    public class PokemonAPIs
    {
        public HttpClient _httpClient;
        public PokemonAPIs() { 

        _httpClient=new HttpClient();
        
        }
        public async Task <List<PokemonInfo>> DevuelveListadoPokemones() {

            string url = "https://pokeapi.co/api/v2/pokemon/?limit=40&offset=0";
            string json = await _httpClient.GetStringAsync(url);

           PokemonList resourse_pokemon = JsonConvert.DeserializeObject<PokemonList>(json); 
            return resourse_pokemon.results;

        }


        public async Task<CaracteristicasPokemon> DevuelveCaracteristicasPokemon(string url) {

            string json = await _httpClient.GetStringAsync(url);
            CaracteristicasPokemon caracteristicas= JsonConvert.DeserializeObject<CaracteristicasPokemon>(json);

            return caracteristicas;

        }


    }
}
