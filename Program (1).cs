class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размерность массива: ");

        int dimension = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[dimension];

        Console.WriteLine("Введите элементы массива: ");

        for (int i = 0; i < dimension; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 1; i < arr.Length; i++)
        {
            int k = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > k)
            {
                arr[j + 1] = arr[j];
                arr[j] = k;
                j--;
            }
        }

        Console.Write("Сортировка: ");

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "| ");
        }

    }
}
