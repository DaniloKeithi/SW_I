
namespace Juros;
class Banco
{   
    public void Calculo(decimal emprestimo, decimal taxa, int prazo){
        decimal prestação = emprestimo/prazo;
        decimal juros = emprestimo * (taxa/100);
        decimal jep = juros+prestação;
        decimal total = jep*prazo;
        Console.WriteLine("Valor do emprestimo é de: R$" + emprestimo);
        Console.WriteLine("O prazo é de: " + prazo + " meses");
        Console.WriteLine("Valor da taxa é de: " + taxa + "%");
        Console.WriteLine("Valor da prestação é de: R$" + prestação);
        Console.WriteLine("O juros é de: R$" + juros);
        Console.WriteLine("O valor de juros mais a prestação: R$" + jep);
        Console.WriteLine("O total a pagar é de: R$" + total);


    }



    }


    
    





