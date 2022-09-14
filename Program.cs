// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//bool maiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

//if (maiorDeIdade || possuiAutorizacaoDoResponsavel)
//{
    //Console.WriteLine("Entrada Liberada!");
//}
//else
//{
   // Console.WriteLine("Entrada não liberada!");
//}


bool MaiordeIdade = true;
bool AutorizacaDosPais = true;

Console.WriteLine("Você é maior de idade?");
Console.WriteLine("[1] para 'Sim' e [2] para 'Não' ");
int resposta = int.Parse(Console.ReadLine());


if (resposta == 2)
{
    MaiordeIdade = false;
    Console.WriteLine("Você tem autorização dos pais?");
    Console.WriteLine("[1] para 'Sim' e [2] para 'Não' ");
    resposta = int.Parse(Console.ReadLine());
    AutorizacaDosPais = false;
}

if(MaiordeIdade == true && 
    AutorizacaDosPais == false)
{
    Console.WriteLine($"{MaiordeIdade} . {AutorizacaDosPais}" );
    Console.WriteLine("Entrada Liberada!");

}
 else if(MaiordeIdade == false && 
    AutorizacaDosPais == true)
{
    Console.WriteLine($"{MaiordeIdade} . {AutorizacaDosPais}" );
    Console.WriteLine("Entrada Liberada!");
   
}

else
{

    

    Console.WriteLine("Entrada não liberada!");
}