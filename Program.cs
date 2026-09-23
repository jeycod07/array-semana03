//Función de impresion de notas
static void ImprimirNotas(int[] notasx)
{ for (int i = 0; i < notasx.Length; i++)
    {
        Console.WriteLine($"Nota {i + 1}: {notasx[i]}");
    }  
} 

//Funcion de promedio de nota
static double PromedioNotas(int[] notasx)
{
    int suma = 0;
    for (int i = 0; i < notasx.Length; i++)
    {
        suma += notasx[i];
    }
    return (double)suma / notasx.Length;
}   

//Función de nota máxima
static int NotaMaxima(int[] notasx)
{
    int max = notasx[0];
    for (int i = 1; i < notasx.Length; i++)
    {
        if (notasx[i] > max)
        {
            max = notasx[i];
        }
    }
    return max;
}

//Función de nota mínima
static int NotaMinima(int[] notasx)
{
    int min = notasx[0];
    for (int i = 1; i < notasx.Length; i++)
    {
        if (notasx[i] < min)
        {
            min = notasx[i];
        }
    }
    return min;
}

int[] notas = { 15,18,12,17,20};

//Imprimir el arreglo de notas
ImprimirNotas(notas);

//Promedio de las notas
double promedio = PromedioNotas(notas);
Console.WriteLine($"Promedio de las notas: {promedio:F2}");       


//Imprimir minimos y maximos de notas
int maxima = NotaMaxima(notas);
int min = NotaMinima(notas);
Console.WriteLine($"Mínima nota: {min}");
Console.WriteLine($"Máxima nota: {maxima}");
