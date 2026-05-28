

using System.Runtime.Intrinsics.Arm;

Console.Clear();

int[,] numeros = new int [3, 3];

for(int linha = 0; linha < 3; linha++)
{
    for(int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write($"Digite o numero: ");
        numeros[linha, coluna] = int.Parse(Console.ReadLine()!);
    }
}


for(int linha1 = 0; linha1 < 3; linha1 ++)
{
    for(int coluna1  = 0; coluna1 < 3; coluna1++)
    {
        for(int linha2 = 0; linha2 < 3; linha2++)
        {
            for(int coluna2 = 0; coluna2 < 3; coluna2++)
            {
                if(numeros[linha1,coluna1] < numeros[linha2, coluna2])
                {
                    int vSup = numeros[linha1,coluna1];
                    numeros[linha1,coluna1] = numeros[linha2,coluna2];
                    numeros[linha2,coluna2] = vSup;
                }
            }
        }
    }
}
Console.WriteLine();
for (int linha = 0; linha < 3; linha++)
{ 
    for(int coluna = 0; coluna < 3; coluna++)
    {
        Console.Write(numeros[linha, coluna] + "\t");
    }
} 
