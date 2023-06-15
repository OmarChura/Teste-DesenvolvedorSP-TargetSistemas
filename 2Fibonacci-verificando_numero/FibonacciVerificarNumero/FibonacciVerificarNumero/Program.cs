// See https://aka.ms/new-console-template for more information

int a = 0, b = 1, fibonacci = 0, numeroaCalcular = 0;

Console.WriteLine("Digite um número ");
numeroaCalcular = Convert.ToInt32(Console.ReadLine());

while (numeroaCalcular > fibonacci)
{
    fibonacci = a + b;
    a = b;
    b = fibonacci;
}

if (numeroaCalcular == fibonacci)
{
    Console.WriteLine("o número " + numeroaCalcular + " pertence a sequencia fibonacci");
}
else
{
    Console.WriteLine("o número " + numeroaCalcular + " não pertence a sequencia fibonacci");
}



Console.WriteLine("Hello, World!");
