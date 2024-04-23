Console.WriteLine("Seja bem vindo ao calculo do Indice de Massa Corporal! ");

do
{
    Console.WriteLine("Digite a sua altura em metros: ");
    double altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o seu peso: ");
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite a sua idade: ");
    int idade = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Digite o seu nome: ");
    var nome = Console.ReadLine();
   
    double imc = peso / (altura * altura);

    string faixaEtaria = "";

    if (idade < 10)
    {
        faixaEtaria = "Criança";
    }
    else if (idade >= 10 && idade < 20)
    {
        faixaEtaria = "Adolescente";
    }
    else if (idade >= 20 && idade < 60)
    {
        faixaEtaria = "Adulto(a)";
    }
    else
    {
        faixaEtaria = "Idoso(a)";
    }

    if (imc < 18.5)
    {
        Console.WriteLine($"{nome} através do calculo você é {faixaEtaria} e está abaixo do peso ideal! ");//interpolção
    }
    else if (imc >= 18.5 && imc < 24.9)
    {
        Console.WriteLine($"Parabéns {nome} através do calculo você é {faixaEtaria} e está no peso ideal! ");
    }
    else if (imc >= 25.0 && imc < 29.9)
    {
        Console.WriteLine(nome + " através do calculo você é " + faixaEtaria + " e está acima do peso ideal!");//concatenação
    }
    else
    {
        Console.WriteLine(nome + " através do calculo você é " + faixaEtaria + " e infelizmente você está obeso!");
    }
    Console.WriteLine("Você gostaria de gerar um novo relatório? (s/n)");
    string resposta = Console.ReadLine();

    if (resposta.ToLower() == "s")
    {
        
    }
    else
    {
        Console.WriteLine("Programa encerrado!");
        break;
    }
        
}
while(true);

