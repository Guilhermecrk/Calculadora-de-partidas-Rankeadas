
using System;

class Program
{
    static void Main()
    {
        // Exemplo de chamada da função com dados fictícios
        int vitorias = 75;
        int derrotas = 20;

        // Chamando a função para obter o saldo de ranqueadas e o nível
        int saldoVitorias = CalcularSaldoRankeadas(vitorias, derrotas);
        string nivel = DeterminarNivel(vitorias);

        // Exibindo resultado
        Console.WriteLine($"O Herói tem um saldo de {saldoVitorias} está no nível de {nivel}");
    }

    // Função para calcular o saldo de ranqueadas
    static int CalcularSaldoRankeadas(int vitorias, int derrotas)
    {
        return vitorias - derrotas;
    }

    // Função para determinar o nível baseado na quantidade de vitórias
    static string DeterminarNivel(int vitorias)
    {
        if (vitorias < 10)
        {
            return "Ferro";
        }
        else if (vitorias >= 11 && vitorias <= 20)
        {
            return "Bronze";
        }
        else if (vitorias >= 21 && vitorias <= 50)
        {
            return "Prata";
        }
        else if (vitorias >= 51 && vitorias <= 80)
        {
            return "Ouro";
        }
        else if (vitorias >= 81 && vitorias <= 90)
        {
            return "Diamante";
        }
        else if (vitorias >= 91 && vitorias <= 100)
        {
            return "Lendário";
        }
        else // vitorias >= 101
        {
            return "Imortal";
        }
    }
}

