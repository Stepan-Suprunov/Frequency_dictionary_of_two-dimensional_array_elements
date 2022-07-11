// Частотный словарь элементов двумерного массива. Показывает, сколько раз встречается эдемент входных данных


void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void Counter(int[,] collection)
{
    int zero = 0;
    int one = 0;
    int two = 0;
    int three = 0;
    int four = 0;
    int five = 0;
    int six = 0;
    int seven = 0;
    int eight = 0;
    int nine = 0;

    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            if (collection[i,j] == 0) zero++;
            if (collection[i,j] == 1) one++;
            if (collection[i,j] == 2) two++;
            if (collection[i,j] == 3) three++;
            if (collection[i,j] == 4) four++;
            if (collection[i,j] == 5) five++;
            if (collection[i,j] == 6) six++;
            if (collection[i,j] == 7) seven++;
            if (collection[i,j] == 8) eight++;
            if (collection[i,j] == 9) nine++;
        }
    }

    if (zero > 0) Console.WriteLine("0 встречается " + zero + " раз");
    if (one > 0) Console.WriteLine("1 встречается " + one + " раз");
    if (two > 0) Console.WriteLine("2 встречается " + two + " раз");
    if (three > 0) Console.WriteLine("3 встречается " + three + " раз");
    if (four > 0) Console.WriteLine("4 встречается " + four + " раз");
    if (five > 0) Console.WriteLine("5 встречается " + five + " раз");
    if (six > 0) Console.WriteLine("6 встречается " + six + " раз");
    if (seven > 0) Console.WriteLine("7 встречается " + seven + " раз");
    if (eight > 0) Console.WriteLine("8 встречается " + eight + " раз");
    if (nine > 0) Console.WriteLine("9 встречается " + nine + " раз");
}

int m = 3, n = 3;
int[,] array = new int[m,n];

FillArray(array);
PrintArray(array);
Counter(array);