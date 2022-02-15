/*
 Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, calcule o perímetro do triângulo e apresente a mensagem:


Perimetro = XX.X


Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, mostrando a mensagem


Area = XX.X

Entrada
A entrada contém três valores reais.

Saída
O resultado deve ser apresentado com uma casa decimal.
 */

using System;



class quest15_csharp
{

    static void Main(string[] args)
    {

        double lado1, lado2, lado3;

        string[] valor = Console.ReadLine().Split();



        lado1 = Convert.ToDouble(valor[0]);

        lado2 = Convert.ToDouble(valor[1]);

        lado3 = Convert.ToDouble(valor[2]);



        if ((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2))
        {

            double per = lado1 + lado2 + lado3;



            Console.WriteLine("Perimetro = {0:0.0}", per);

        }
        else
        {

            double area = ((lado1 + lado2) * lado3) / 2;



            Console.WriteLine("Area = {0:0.0}", area);

        }

    }

}