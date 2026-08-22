namespace AdvancedCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 What is a generic class? Why use generics?

            // A generic class is a class that works with different data types
            // by using a type parameter such as <T>.

            // Generics are used to:
            // 1. Reuse the same code with different data types.
            // 2. Provide type safety.
            // 3. Avoid unnecessary casting.

            #endregion

            #region Q2 Generic Container

            Container<int> numberContainer = new Container<int>();

            numberContainer.Add(100);

            Console.WriteLine($"Number: {numberContainer.Get()}");


            Container<string> textContainer = new Container<string>();

            textContainer.Add("Hello Generics");

            Console.WriteLine($"Text: {textContainer.Get()}");

            #endregion
        }
    }
}
