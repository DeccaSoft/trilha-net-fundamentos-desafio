namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuÃ¡rio digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a Placa do Veí­culo para Estacionar:");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a Placa do Veí­culo para Remover:");

            // Pedir para o usuÃ¡rio digitar a placa e armazenar na variÃ¡vel placa
            // *IMPLEMENTE AQUI*
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veÃ­culo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a Quantidade de Horas Excedentes que o Veículo Permaneceu Estacionado:");

                // TODO: Pedir para o usuÃ¡rio digitar a quantidade de horas que o veÃ­culo permaneceu estacionado,
                // TODO: Realizar o seguinte cÃ¡lculo: "precoInicial + precoPorHora * horas" para a variÃ¡vel valorTotal                
                // *IMPLEMENTE AQUI*
                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (horas * precoPorHora);

                // TODO: Remover a placa digitada da lista de veÃ­culos
                // *IMPLEMENTE AQUI*
                veiculos.Remove(placa);
                Console.WriteLine($"O veí­culo de Placa {placa} foi Removido e o Valor Total a Pagar é de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse Veí­culo NÃO está Estacionado Aqui! Por Favor, Confira se Digitou a Placa Corretamente...");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se hÃ¡ veÃ­culos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os Veículos Estacionados são:");
                // TODO: Realizar um laÃ§o de repetiÃ§Ã£o, exibindo os veÃ­culos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("NÃO há Veí­culos Estacionados.");
            }
        }

    }
}
