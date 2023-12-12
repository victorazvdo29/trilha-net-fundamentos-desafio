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
            // IMPLEMENTADO!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();              //ReadLine para armazenar a placa no sistema.

            if (veiculos.Any(v => v.Equals(placa.ToUpper())))   //veiculos.Any(v => v.Equals(placa.ToUpper())) para saber se o veículo ja esta cadastrado.
            {
                Console.WriteLine("O veículo com essa placa já está estacionado"); //imprimir o código com a mensagem se ele já estiver estacionado.
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo estacionado com sucesso.");  //else para que se não, adicionar(Add) e estacionar o veículo.
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // IMPLEMENTADO!
            string placa = Console.ReadLine(); // Verifica se o veículo existe

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // IMPLEMENTADO!
                int horas = Convert.ToInt32(Console.ReadLine());                    //para digitar a quantidade de horas, o convert para converter em núimeros inteiros.
                decimal valorTotal = precoInicial + precoPorHora * horas;    //o calculo das horas que o veículo ficou estacionado.
             

                // IMPLEMENTADO!
                veiculos.Remove(placa.ToUpper());  //remover o veículos da lista apos o pagamento.

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
           
            if (veiculos.Any())        // Verifica se há veículos no estacionamento
            {
                Console.WriteLine("Os veículos estacionados são:");
                // IMPLEMENTADO!
                foreach (var automoveis in veiculos)   //para acessar a lista de veículos e armazena em automoveis.
                {
                    Console.WriteLine(automoveis);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
