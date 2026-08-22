using AdvancedCSharp01.Generics;

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

            Console.WriteLine("==============");

            #region Q2 Generic Container

            Container<int> numberContainer = new Container<int>();

            numberContainer.Add(100);

            Console.WriteLine($"Number: {numberContainer.Get()}");


            Container<string> textContainer = new Container<string>();

            textContainer.Add("Hello Generics");

            Console.WriteLine($"Text: {textContainer.Get()}");

            #endregion

            Console.WriteLine("==============");

            #region Q3 Multiple Type Parameters

            // Multiple type parameters allow a generic class
            // to work with more than one data type.

            // Example:
            // Pair<TKey, TValue>
            // TKey represents the type of the key.
            // TValue represents the type of the value.

            Pair<int, string> student = new Pair<int, string>(1, "Ibrahim");

            Console.WriteLine($"Key: {student.Key}");
            Console.WriteLine($"Value: {student.Value}");

            #endregion

            Console.WriteLine("==============");

            #region Q4 Generic Method

            // A generic method is a method that works with different data types
            // by using a type parameter such as <T>.

            int x = 10;
            int y = 20;

            Console.WriteLine($"Before Swap: x = {x}, y = {y}");

            GenericMethods.Swap(ref x, ref y);

            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            #endregion

            Console.WriteLine("==============");

            #region Q5 Generic FindMax Method

            int maxNumber = GenericMethods.FindMax(10, 20);

            Console.WriteLine($"Maximum Number: {maxNumber}");

            double maxDouble = GenericMethods.FindMax(15.5, 9.8);

            Console.WriteLine($"Maximum Double: {maxDouble}");

            #endregion

            Console.WriteLine("==============");

            #region Q6 Generic Interface

            // A generic interface is an interface that uses a type parameter.
            // It can work with different data types while keeping type safety.

            #endregion

            Console.WriteLine("==============");

            #region Q7 Struct Constraint

            // The struct constraint restricts a generic type
            // to non-nullable value types only.

            // Examples:
            // int, double, bool, char, DateTime

            ValueContainer<int> number = new ValueContainer<int>(100);

            ValueContainer<double> price = new ValueContainer<double>(99.5);

            Console.WriteLine($"Number: {number.Value}");
            Console.WriteLine($"Price: {price.Value}");

            #endregion

            Console.WriteLine("==============");

            #region Q8 Class Constraint

            // The class constraint restricts a generic type
            // to reference types only.

            ReferenceContainer<string> name =
    new ReferenceContainer<string>("Ibrahim");

            Console.WriteLine($"Name: {name.Value}");

            // ReferenceContainer<int> number =
            //     new ReferenceContainer<int>(100);

            // Error: int is a value type.

            #endregion

            Console.WriteLine("==============");


        }
    }
}
