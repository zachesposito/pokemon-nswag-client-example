using NSwag;
using NSwag.CodeGeneration.CSharp;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace PokemonLookupCSharp.ClientGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateClient().GetAwaiter().GetResult();
        }

        static async Task GenerateClient()
        {
            var document = await SwaggerDocument.FromUrlAsync("http://localhost:58829/swagger/v1/swagger.json");

            var settings = new SwaggerToCSharpClientGeneratorSettings
            {
                ClassName = "PokemonLookupAPIClient",
                CSharpGeneratorSettings =
                {
                    Namespace = "PokemonLookupCSharp"
                }
            };

            var generator = new SwaggerToCSharpClientGenerator(document, settings);
            var code = generator.GenerateFile(NSwag.CodeGeneration.ClientGeneratorOutputType.Full);
            var appFolder = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName, "PokemonLookupCSharp");
            File.WriteAllText(Path.Combine(appFolder, "Client.cs"), code);
        }
    }
}
