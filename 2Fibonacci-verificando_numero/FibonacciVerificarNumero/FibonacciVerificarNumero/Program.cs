// See https://aka.ms/new-console-template for more information

int a = 0, b = 1, fibonacci = 0, numero = 0;

Console.WriteLine("Digite um número ");
numero = Convert.ToInt32(Console.ReadLine());

while (numero > fibonacci)
{
    fibonacci = a + b;
    a = b;
    b = fibonacci;
}

if (numero == fibonacci)
{
    Console.WriteLine("o número " + numero + " pertence a sequencia fibonacci");
}
else
{
    Console.WriteLine("o número " + numero + " não pertence a sequencia fibonacci");
}



Console.WriteLine("Hello, World!");
