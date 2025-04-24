

/*
Desenvolva uma lógica que leia o peso e a altura de uma pessoa, 
calcule seu Índice de Massa Corporal (IMC) e mostre seu status, de acordo com a tabela abaixo:
- IMC abaixo de 18,5: Abaixo do Peso
- Entre 18,5 e 25: Peso Ideal
- 25 até 30: Sobrepeso
- 30 até 40: Obesidade
- Acima de 40: Obesidade Mórbida

fórmula: IMC = peso / (altura x altura)
 */

using System;

class Treino
{
    static void Main()
    {
        var (peso, altura) = Dados();
        double imc = Calculo_imc(peso, altura);

        Console.Clear();
        Console.WriteLine("-=-=-=-=-= índice de massa corporal -=-=-=-=-=");

        if (imc < 18.5) {
            
            Console.Write($">Peso: {peso}kg.\n>Abaixo do peso!\n");
        }
        else if (imc >= 18.5 && imc <= 25)
        {
            
            Console.Write($">Peso: {peso}kg.\n>Peso normal!\n");
        }
        else if (imc > 25 && imc <= 30)
        {
            
            Console.Write($">Peso: {peso}kg.\n>Sobrepeso!\n");
        }
        else if (imc > 30 && imc <= 40)
        {
            
            Console.Write($">Peso: {peso}kg.\n>Obesidade!\n");
        }
        else
        {
            
            Console.Write($">Peso: {peso}kg.\n>Obesidade mórbida!\n");
        }
    }

    static (double peso, double altura) Dados()
    {
        double peso;
        double altura;
        while (true)
        {
            Console.Write("\n>Digite o seu peso: ");
            string pe = Console.ReadLine();
            if (double.TryParse(pe, out peso) && peso > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um número 'inteiro ou real'\n");
            }
        }
        while (true)
        {
            Console.Write("\n>Digite a sua altura em metros: ");
            string al = Console.ReadLine();
            if (double.TryParse(al, out altura) && altura > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.Write(">Entrada inválida! Esperava um número 'inteiro ou real'\n");
            }
        }

        return (peso, altura);
    }

    static double Calculo_imc(double peso, double altura)
    {
        //fórmula: IMC = peso / (altura x altura)
        return peso / (altura * altura);
    }
}