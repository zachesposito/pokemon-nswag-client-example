using System;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonLookupCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pokemon Lookup!");
            Console.WriteLine("Your random Pokemon is: ");
            var randomPokemon = GetRandomPokemon().GetAwaiter().GetResult();
            PrintPokemon(randomPokemon);

            Console.WriteLine(Environment.NewLine + "Press enter to close.");
            Console.ReadLine();
        }

        private static void PrintPokemon(Pokemon pokemon)
        {
            Console.WriteLine($"* * * {pokemon.Name} * * *");
            Console.WriteLine($"ID: {pokemon.Id.ToString()}");
            Console.WriteLine($"Species: {pokemon.Species.Name}");
            Console.WriteLine($"Types: {pokemon.Types.Select(t => t.Type.Name).Aggregate((built, next) => built + ", " + next) }");
            Console.WriteLine($"Stats:");
            foreach (var stat in pokemon.Stats)
            {
                Console.WriteLine($"  {stat.Stat1.Name}: {stat.Base_stat}");
            }
            Console.WriteLine($"Moves:");
            foreach (var move in pokemon.Moves.Where(m => m.Version_group_details.Any(d => d.Move_learn_method.Name == "level-up")).Take(5))
            {
                Console.WriteLine($"  {move.Move1.Name}");
            }
        }

        public static async Task<Pokemon> GetRandomPokemon()
        {
            var client = new PokemonLookupAPIClient("http://localhost:58829", new System.Net.Http.HttpClient());
            var names = await client.GetPokemonIndexAsync();
            var randomPokemon = await client.GetSpecificPokemonAsync(names.ToArray()[new Random().Next(0, names.Count - 1)]);
            return randomPokemon;
        }
    }
}
