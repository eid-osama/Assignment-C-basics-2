namespace Assignment_C__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object book = new Book();
            #region Question 
            //Console.WriteLine(book);

            #endregion

            #region Question 2
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            #endregion

            #region Question 3

            // Compile-time Error
            //int pages = 464;
            #endregion
            #region Question 4
            //try { 
            //    int x = 10;
            //    Console.WriteLine(x / 0);
            //}catch(Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region Question 5
            //int pages = 300;
            //double DoubPages = pages;
            #endregion
            #region Question 6
            //double Price = 49.99;
            //int IntPrice = (int)Price;
            #endregion
            #region Question 7
            //string pagesText = "464";
            //int IntPages = Convert.ToInt32(pagesText);
            #endregion
            #region Question 8
            //string yearText = "2023";
            //int Year = int.Parse(yearText);
            //string badText = "abc";
            //if(int.TryParse(badText, out int text))
            //{
            //    Console.WriteLine(text);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion
            #region Question 9
            //int pages = 464;
            //Console.WriteLine(pages.ToString().GetType());
            #endregion
            #region Question 10
            //int copies = 100;
            //object ObjCopies = copies;
            //int UnboxedCopies = (int)ObjCopies;
            //Console.WriteLine(ObjCopies);
            //Console.WriteLine(UnboxedCopies);
            #endregion

        }
        class Book
        {
            public string Title;
            public int Pages;

        }
    }
}

