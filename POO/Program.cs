using System;

public class Program
{
    public static void Main(string[] args)
    {
        Pessoa[] pessoas = new Pessoa[5];

        for (int i = 0; i < pessoas.Length; i++)
        {
            System.Console.Write("Nome da nova pessoa: ");
            string? nome = Console.ReadLine();
            System.Console.Write("Sua Idade: ");
            int idade = int.Parse(Console.ReadLine());
            System.Console.Write("Sexo: M ou F");
            char sexo = char.Parse(Console.ReadLine().ToUpper());
            System.Console.Write("Seu RG: ");
            string? rg = Console.ReadLine();
            System.Console.Write("Seu CPF: ");
            string? cpf = Console.ReadLine();

            pessoas[i] = new Pessoa(nome, rg, cpf, sexo, idade);
            pessoas[i].Cadastrar();
        }
        for (int i = 0; i < pessoas.Length; i++)
        {
            pessoas[i].Falar();
            pessoas[i].Andar();
            pessoas[i].Morrer();
        }
    }
}