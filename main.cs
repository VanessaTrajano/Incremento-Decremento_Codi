using System;

class Program {
  public static void Main (string[] args) {
    // Exercício 1 ------------------------------------
    // Escreva um programa que leia do teclado um valor inteiro e atribua a uma segunda variável o valor lido do teclado, porém incrementado em duas unidades, no final imprima no Console a nova variável incrementada.
    int valor, novoValor;
    valor = Convert.ToInt32(Console.ReadLine());
    novoValor = valor + 2;
    Console.WriteLine(novoValor);


    // Exercício 2 ------------------------------------
    // Faça um programa que leia do teclado um valor inteiro e em seguida, usando o decremento, reduza o número lido em 3 unidades, ao final imprima a variável.
    int val = Convert.ToInt32(Console.ReadLine());
    val -= 3;
    Console.WriteLine(val);
  }
}