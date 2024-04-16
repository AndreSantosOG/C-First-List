namespace TrabalhoOne;

public class Program
{
 static void Main()
    {
        //1
        Console.WriteLine("Digite seu nome:");
        var nameOne  = Console.ReadLine();
        Console.WriteLine($"Olá, {nameOne}! Seja muito bem-vindo!");

        //2
        Console.WriteLine("Digite seu nome:");
        var nameTwo = Console.ReadLine();
        Console.WriteLine("Digite seu sobrenome:");
        var surname = Console.ReadLine();
        Console.WriteLine($"Este é seu nome completo: {nameTwo} {surname}");

        //3
        Console.WriteLine("Digite o primeiro número:");
        var numberOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        var numberTwo = double.Parse(Console.ReadLine());
        if (numberTwo == 0)
        {
            Console.WriteLine("Número dois não pode ser zero");
        }
        else
        {
        Console.WriteLine("Soma é " + numberOne + numberTwo);
        Console.WriteLine("Subtração é " + (numberOne - numberTwo));
        Console.WriteLine("Multiplicação é " + numberOne * numberTwo);
        Console.WriteLine("Divisão é " + numberOne / numberTwo);
        Console.WriteLine("A média é " + (numberOne + numberTwo) / 2);

        }

        //4
        Console.WriteLine("Digite uma palavra:");
         string word = Console.ReadLine();
         string textoSemEspacos = word.Replace(" ", "");
        Console.WriteLine("Esse é o número de letras da sua palavra:");
        Console.WriteLine(textoSemEspacos.Length);

        //5
        Console.WriteLine("Digite a placa do seu veiculo:");
        var placa = Console.ReadLine();
        var letter = char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]);
        var numbers = char.IsNumber(placa[3]) && char.IsNumber(placa[4]) && char.IsNumber(placa[5]) && char.IsNumber(placa[6]);
        if (placa.Length == 7 && letter && numbers)
            Console.WriteLine("Sua placa é válida!!");
        else
            Console.WriteLine("Sua placa não é válida!!");

        //6
        DateTime dataAtual = DateTime.Now;

        string formatoCompleto = dataAtual.ToString("dddd, dd/MM/yyyy HH:mm:ss");
        string apenasData = dataAtual.ToString("dd/MM/yyyy");
        string apenasHora = dataAtual.ToString("HH:mm:ss");
        string dataMesExtenso = dataAtual.ToString("dd 'de' MMMM 'de' yyyy");

        Console.WriteLine("Formato completo: " + formatoCompleto);
        Console.WriteLine("Apenas a data: " + apenasData);
        Console.WriteLine("Apenas a hora: " + apenasHora);
        Console.WriteLine("Data com mês por extenso: " + dataMesExtenso);


    }

}
