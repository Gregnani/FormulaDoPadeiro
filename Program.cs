
using System;

class Program
{
    const double ReceitaFarinha = 1;
    const double ReceitaAgua = 0.7;
    const double ReceitaFermento = 0.4;
    const double ReceitaSal = 0.02;

    static void Main(string[] args)
    {   Console.Clear();
        double percentualPaoRelativoFarinha = ReceitaFarinha + ReceitaAgua + ReceitaFermento + ReceitaSal;

        Console.WriteLine("--- Cálculo de Ingredientes para Pão Italiano ---\n");

        Console.Write("Peso desejado de pão italiano (em gramas): ");
        double pesoPaoDesejado = Convert.ToDouble(Console.ReadLine());

        double quantidadeFarinha = pesoPaoDesejado / percentualPaoRelativoFarinha;
        double quantidadeAgua = quantidadeFarinha * ReceitaAgua;
        double quantidadeFermento = quantidadeFarinha * ReceitaFermento;
        double quantidadeSal = quantidadeFarinha * ReceitaSal;

        Console.WriteLine("\nQuantidade de ingredientes necessários:");

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkGreen;

        Console.WriteLine($"Farinha....: {quantidadeFarinha:N2} g");
        Console.WriteLine($"Água.......: {quantidadeAgua:N2} g");
        Console.WriteLine($"Fermento...: {quantidadeFermento:N2} g");
        Console.WriteLine($"Sal........: {quantidadeSal:N2}  g");

        Console.ResetColor();

        Console.WriteLine();
    }
}



