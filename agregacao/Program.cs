namespace agregacao;
class Program
{
  static void Main(string[]args)
{
    Console.WriteLine("Trabalhando com agregação");

    //instanciando os objetos de cada classe
    CartaoDeCredito cdc = new CartaoDeCredito();
    Cliente cli = new Cliente();

    //Adicionando um nome para o cliente
    cli.Nome = "Danilo Keithi";

    //Adicionando número e validade do Cartão de Crédito
    cdc.Numero = "400289222";
    cdc.DataValidade = "4/2027";

    //Associando o cliente ao atributo de agregação em Cartão de Crédito
    cdc.Cliente = cli;

    //Visualizando as informações
    Console.WriteLine("O nome do cliente é: " + cli.Nome);
    Console.WriteLine("O numero do cartão é: " + cdc.Numero);
    Console.WriteLine("A data de validade é: " + cdc.DataValidade);
    Console.WriteLine("O nome do cliente agregado é: " + cdc.Cliente.Nome);
}
}
