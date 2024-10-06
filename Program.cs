internal class Program
{
    private static void Main(string[] args)
    {
        int dem = 0;
        Console.WriteLine("Danh sach so nguyen to nho hon 100:");
        for (int i = 2; i <= 100; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    dem++;
                }
            }

            if (dem == 2)
            {
                Console.WriteLine(i);
            }
            dem = 0;
        }
    }
}