using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace ProjetoEscola;

public class Pessoa
{
    public string? Nome { get; set; }
    public string? Sobrenome { get; set; }
    public string? Endereco { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? CEP { get; set; }
    public string? Pais { get; set; }

    public Pessoa(string nome, string sobrenome, string endereco, string cidade, string estado, string cep, string pais)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Endereco = endereco;
        Cidade = cidade;
        Estado = estado;
        CEP = cep;
        Pais = pais;
    }

    public override bool Equals(object? obj)
    {
        if(obj == null || GetType() != obj.GetType())
            return false;

        Pessoa outraPessoa = (Pessoa)obj;
        return Nome == outraPessoa.Nome && Sobrenome == outraPessoa.Sobrenome &&
               Endereco == outraPessoa.Endereco && Cidade == outraPessoa.Cidade &&
               Estado == outraPessoa.Estado && CEP == outraPessoa.CEP && Pais == outraPessoa.Pais;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nome, Sobrenome, Endereco, Cidade, Estado, CEP, Pais);
    }

    public override string ToString()
    {
        return $"Nome: {Nome} {Sobrenome}, Endereço: {Endereco}, Cidade: {Cidade}, Estado: {Estado}, CEP: {CEP}, País: {Pais}";
    }
}

class Programa
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Ana", "Silva", "Rua A, 123", "São Paulo", "SP", "01234-567", "Brasil");
        Pessoa pessoa2 = new Pessoa("João", "Souza", "Rua B, 456", "Rio de Janeiro", "RJ", "23456-789", "Brasil");
        Pessoa pessoa3 = new Pessoa("Maria", "Oliveira", "Rua C, 789", "Belo Horizonte", "MG", "34567-890", "Brasil");
        Pessoa pessoa4 = new Pessoa("Pedro", "Santos", "Rua D, 1011", "Brasília", "DF", "45678-901", "Brasil");
        Pessoa pessoa5 = new Pessoa("Carlos", "Fernandes", "Rua E, 1213", "Salvador", "BA", "56789-012", "Brasil");
        Pessoa pessoa6 = new Pessoa("João", "Silva", "Rua das Flores, 123", "São Paulo", "SP", "01234-567", "Brasil");
        Pessoa pessoa7 = new Pessoa("Maria", "Santos", "Avenida Paulista, 456", "São Paulo", "SP", "98765-432", "Brasil");
        Pessoa pessoa8 = new Pessoa("Pedro", "Oliveira", "Rua Augusta, 789", "Rio de Janeiro", "RJ", "54321-678", "Brasil");
        Pessoa pessoa9 = new Pessoa("Ana", "Pereira", "Avenida Atlântica, 321", "Rio de Janeiro", "RJ", "87654-321", "Brasil");
        Pessoa pessoa10 = new Pessoa("Luiz", "Costa", "Rua Oscar Freire, 654", "São Paulo", "SP", "23456-789", "Brasil");
        Pessoa pessoa11 = new Pessoa("Ana", "Silva", "Rua A, 123", "São Paulo", "SP", "01234-567", "Brasil");

        Console.WriteLine("Pessoa 1: " + pessoa1);
        Console.WriteLine("Pessoa 2: " + pessoa2);
        Console.WriteLine("Pessoa 3: " + pessoa3);
        Console.WriteLine("Pessoa 4: " + pessoa4);
        Console.WriteLine("Pessoa 5: " + pessoa5);
        Console.WriteLine("Pessoa 6: " + pessoa6);
        Console.WriteLine("Pessoa 7: " + pessoa7);
        Console.WriteLine("Pessoa 8: " + pessoa8);
        Console.WriteLine("Pessoa 9: " + pessoa9);
        Console.WriteLine("Pessoa 10: " + pessoa10);
        Console.WriteLine("Pessoa 11: " + pessoa11);

        Console.WriteLine("");
        Console.WriteLine("Realizando a comparação das pessoas:");
        Console.WriteLine("");

        Console.WriteLine("Comparando pessoa1 e pessoa2: " + pessoa1.Equals(pessoa2));
        Console.WriteLine("Comparando pessoa1 e pessoa3: " + pessoa1.Equals(pessoa3));
        Console.WriteLine("Comparando pessoa1 e pessoa4: " + pessoa1.Equals(pessoa4));
        Console.WriteLine("Comparando pessoa1 e pessoa5: " + pessoa1.Equals(pessoa5));
        Console.WriteLine("Comparando pessoa1 e pessoa6: " + pessoa1.Equals(pessoa6));
        Console.WriteLine("Comparando pessoa1 e pessoa7: " + pessoa1.Equals(pessoa7));
        Console.WriteLine("Comparando pessoa1 e pessoa8: " + pessoa1.Equals(pessoa8));
        Console.WriteLine("Comparando pessoa1 e pessoa9: " + pessoa1.Equals(pessoa9));
        Console.WriteLine("Comparando pessoa1 e pessoa10: " + pessoa1.Equals(pessoa10));
        Console.WriteLine("Comparando pessoa1 e pessoa11: " + pessoa1.Equals(pessoa11));
    }
}