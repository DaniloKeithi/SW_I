namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadLine();
        //INSTANCIA DE UM OBJETO DA CLASSE AVIAO
        Aviao tecoteco = new Aviao();

        //USANDO ATRIBUTOS E/OU METODOS DA CLASSE PELO OBJETO CRIADO
        tecoteco.acelerar();

        //USANDO METODO SEM RETORNO E COM PARAMETRO

        tecoteco.acelerarParametro("Danilo Keithi");


    //METODO COM RETORNO E SEM PARAMETROS

    tecoteco.potato();

    Console.WriteLine(tecoteco.potato());


    //METODO COM RETORNO E COM PARAMETRO

    Console.WriteLine(tecoteco.somar(20,50));



    }
}
