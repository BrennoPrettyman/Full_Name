namespace Full_Name;
class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();
        
        String nome, sobrenome, Nomecompleto, Nomedecatalogo;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine()!;

    Console.WriteLine();

        Console.WriteLine("Digite seu sobrenome: ");
        sobrenome = Console.ReadLine()!;

    Console.Clear();

    Console.WriteLine();
    Nomecompleto = nome + " " + sobrenome;
    Nomedecatalogo = sobrenome + ", " + nome;

         Console.WriteLine($"Seu nome Completo é: {Nomecompleto}"); 
         Console.WriteLine();   
         Console.WriteLine($"Seu nome de Catalógo é: {Nomedecatalogo.ToUpper()}"); 




        
        
    }
}
