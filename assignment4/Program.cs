using System; 
class Program
{
    static void Main(string[] args)
    {
        #region Question 1

        double[] Prices = [25.5, 40.0, 33.75];
        Console.WriteLine(Prices[1])
;
        #endregion

        #region Question 2
        int[,] ShelfCopies =
        {
            {3,5 },
            {1,4 }
        };
        Console.WriteLine(ShelfCopies[1, 0]);
        #endregion
    }
}
