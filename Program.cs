// Частотный словарь элементов двумерного массива. Показывает, сколько раз встречается эдемент входных данных


void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Counter(int[,] collection0)
{
    bool compare;
    int[] collection1 = new int[collection0.Length];
    int count0 = 0;
    for (int i = 0; i < collection0.GetLength(0); i++)
    {
        for (int j = 0; j < collection0.GetLength(1); j++)
        {
            compare = false;
            for (int k = 0; k < count0; k++)
            {
                if (collection0[i, j] == collection1[k])
                {
                    compare = true;
                    break;
                }
            }
            if (!compare)
            {
                collection1[count0] = collection0[i, j];
                count0++;
            }
        }
    }

    for (int l = 0; l < count0; l++)
    {
        int count1 = 0;
        int num = collection1[l];
        for (int o = 0; o < collection0.GetLength(0); o++)
        {
            for (int p = 0; p < collection0.GetLength(1); p++)
            {
                if (collection0[o,p] == num) count1++;
            }
        }
        Console.WriteLine("Число " + collection1[l] + " встречается " + count1 + " раз");
    }

}

int m = 3, n = 3;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
Console.WriteLine("_________________");
Counter(array);