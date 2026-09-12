using System; 
class Program
{
    #region Question 3
    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Library!");
    }
    #endregion

    #region Question 4
    static void PrintBookTitle (string title)
    {
        Console.WriteLine("Book Title: " + title);
    }
    #endregion

    #region Question 5
    static void AddBonusPages(int pages)
    {
        pages += 50;
    }
    #endregion

    #region Question 6
    static void AppplyDiscount(double[] prices)
    {
        prices[0] -= 5;
    }
    #endregion

    #region Question 7
    static void AddBonusPagesByRef(ref int pages)
    {
        pages += 50;
    }
    #endregion

    #region Question 8
    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }
    #endregion

    #region Question 9
    static bool TryGetPrice(string bookTitle, out double price)
    {
        if (bookTitle == "Clean Code")
        {
            price = 25.5;
                return true;
        }
        else
        {
            price = 0.0;
            return false;
        }
    }
    #endregion
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

        #region Question 3
        PrintWelcomeMessage();

        #endregion

        #region Question 4
        PrintBookTitle("Clean Code");
        #endregion

        #region Question 5
        int pages = 400;
        AddBonusPages(pages);
        Console.WriteLine(pages); // because we are passing by value original still remains 400
        #endregion

        #region Question 6
        double[] prices = [25.5, 40.0];
        AppplyDiscount(prices);
        Console.WriteLine(prices[0]); // because we are passing by reference original is modified to 20.5
        #endregion

        #region question 7
        int pagesByRef = 400;
        AddBonusPagesByRef(ref pagesByRef);
        Console.WriteLine(pagesByRef); // because we are passing by reference original is modified to 450

        #endregion

        #region Question 8
        double[] prices2= {25.5, 40.0 };
        ReplaceArray(ref prices2);
        Console.WriteLine(prices2.Length); // because we are passing by reference original is modified to new array of length 3
        #endregion

        #region Question 9
        double price1;
        if(TryGetPrice("Clean Code", out price1))
        {
            Console.WriteLine(price1); 
        }
        else
        {
            Console.WriteLine("Book not found");
        }   

        #endregion


    }
}
