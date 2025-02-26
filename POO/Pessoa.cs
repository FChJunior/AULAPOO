using System;

public class Pessoa
{
    #region Atributos
    public string? nome;
    public string? rg;
    public string? cpf;
    public char sexo;
    public int idade;
    bool morreu;

    #endregion

    public Pessoa(string? nome, string? rg, string? cpf, char sexo, int idade)
    {
        this.nome = nome;
        this.rg = rg;
        this.cpf = cpf;
        this.sexo = sexo;
        this.idade = idade;
        morreu = false;
    }

    #region  Metódos

    public void Falar()
    {
        if (!morreu)
        {
            System.Console.WriteLine($"Olá, meu nome é {nome}. Tenho {idade} anos.");
        }
        else
        {
            System.Console.WriteLine("O indivio está morto!");
        }
    }
    public void Andar()
    {
        if (!morreu)
        {
            System.Console.WriteLine($"{nome} está andando...");
        }
        else
        {
            System.Console.WriteLine("O indivio está morto!");
        }
    }
    public void Cadastrar()
    {
        if (!morreu)
        {
            System.Console.WriteLine("Informações Cadastrais:\n" +
                                                        $"Nome: {nome}\n" +
                                                        $"Idade: {idade}\n" +
                                                        $"RG: {rg}\n" +
                                                        $"CPF: {cpf}\n" +
                                                        $"Sexo: {sexo}\n" +
                                                        "Cadastro Realizado com sucesso!!!");
        }
        else
        {
            System.Console.WriteLine("O indivio está morto!");
        }
    }
    public void Morrer()
    {
        if (!morreu)
        {
            cpf = "000.000.000-00";
            rg = "0000000000.0";
            morreu = true;
            System.Console.WriteLine($"O individuo {nome} morreu.\n" +
                                                        $"Idade: {idade}\n" +
                                                        $"RG: {rg}\n" +
                                                        $"CPF: {cpf}\n" +
                                                        $"Sexo: {sexo}\n");
        }else
        {
            System.Console.WriteLine("O indivio está morto!");
        }
    }

    #endregion
}