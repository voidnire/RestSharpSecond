using RestSharp;

namespace RestSharpSecond
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Digite um cep gooo");
            var cep = Console.ReadLine();

            if (cep.Length == 8)
            {
                var client = new RestClient(string.Format("https://viacep.com.br/ws/{0}/json", cep));
                var req = new RestRequest();

                var resp = await client.GetAsync(req); //bad req

                if (resp != null)
                    Console.WriteLine(resp.Content.ToString());
                else
                    Console.WriteLine(":(((((( erro bobo");
            }
            else
            {
                Console.WriteLine("assim nao ne");
            }
            Console.WriteLine("\nPressione enter para sair.");
            Console.ReadKey();
        }
    }
}