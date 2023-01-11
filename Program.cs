using CalcularImc.Models;

// Declarando as variáveis;
decimal seuPeso = 0;
decimal suaAltura = 0;

// Interação com o usuário;
Console.WriteLine("Bem vindo ao programa para calculo de IMC!\n" +
                  "Digite o seu peso atual:");
seuPeso = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite a sua altura atual (ex: 1.40) :");
suaAltura = Convert.ToDecimal(Console.ReadLine());

// Adicioando a variável cl na classe Calculo;
Calculo cl = new Calculo(seuPeso, suaAltura);

// Buscando o método Calcular;
cl.Calcular();


