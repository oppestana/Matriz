

/*


string[,] nomes = { {"Pedro"}, {"Lais"}, {"Maysa"} };
double[,] notas =
{
    {10, 6},
    {7.5, 8},
    {9, 7},  
};



for(int linha = 0; linha < 3; linha++)
{
    double soma = 0;
    for(int coluna = 0; coluna < 2; coluna++)
    {
        soma += notas[linha, coluna];
    }
    double media = soma / 2;
    Console.WriteLine($"A media do aluno(a) {nomes[linha, 0]} são: {media:F2}");
}

*/