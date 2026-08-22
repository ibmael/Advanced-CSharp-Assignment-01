using AdvancedCSharp01.Generics;
using AdvancedCSharp01.Interfaces;
using AdvancedCSharp01.Models;


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

            #region Q9 New Constraint

            // The new() constraint requires the generic type
            // to have a public parameterless constructor.

            // It allows us to create a new object of type T using new T().

            ObjectFactory<Student> studentFactory =
                new ObjectFactory<Student>();

            Student newStudent = studentFactory.Create();

            newStudent.Name = "Ibrahim";

            Console.WriteLine($"Student Name: {newStudent.Name}");

            #endregion

            Console.WriteLine("==============");

            #region Q10 Interface Constraint

            // An interface constraint restricts a generic type
            // to types that implement a specific interface.

            Student printableStudent = new Student();

            printableStudent.Name = "Ibrahim";

            Printer<Student> printer = new Printer<Student>();

            printer.PrintItem(printableStudent);

            #endregion

            Console.WriteLine("==============");

            #region Q11 Base Class Constraint

            // A base class constraint restricts a generic type
            // to a specific base class or any class derived from it.

            Student baseStudent = new Student();

            baseStudent.Name = "Ibrahim";

            PersonManager<Student> manager =
                new PersonManager<Student>();

            manager.DisplayName(baseStudent);

            #endregion

            Console.WriteLine("==============");

            #region Q12 Multiple Constraints

            // Multiple constraints allow a generic type parameter
            // to have more than one constraint at the same time.

            // Example:
            // T must inherit from Person,
            // implement IPrintable,
            // and have a public parameterless constructor.

            PersonProcessor<Student> processor =
    new PersonProcessor<Student>();

            Student processedStudent =
                processor.CreateAndPrint("Ibrahim");

            #endregion

            Console.WriteLine("==============");

            #region Q13 default(T)

            // default(T) returns the default value of a generic type T.

            // int          -> 0
            // bool         -> false
            // string       -> null
            // custom class -> null

            Console.WriteLine($"Default int: {default(int)}");
            Console.WriteLine($"Default bool: {default(bool)}");

            string? defaultString = default(string);
            Student? defaultStudent = default(Student);

            Console.WriteLine(
                $"Default string: {defaultString ?? "null"}"
            );

            Console.WriteLine(
                $"Default Student: {(defaultStudent == null ? "null" : "Object")}"
            );

            #endregion

            Console.WriteLine("==============");

            #region Q14 Assign Default Value to Generic Variable

            // We can assign a default value to a generic variable
            // by using the default keyword.

            // Example:
            // T value = default(T);

            // Modern C# also allows:
            // T value = default;

            #endregion

            Console.WriteLine("==============");

            #region Q15 Generic Inheritance

            // Yes, a generic class can inherit from another generic class.

            // The derived generic class can pass its type parameter
            // to the generic base class.

            AdvancedContainer<string> inheritanceContainer =
    new AdvancedContainer<string>();

            inheritanceContainer.Value = "Generic Inheritance";

            inheritanceContainer.Display();

            #endregion

            Console.WriteLine("==============");

            #region Q15 Covariance

            // Covariance allows a generic interface to use
            // a more derived type where a less derived type is expected.

            // The "out" keyword is used for covariance.
            // It means the generic type is used as an output type.

            IProducer<Student> studentProducer =
    new StudentProducer();

            IProducer<Person> personProducer =
                studentProducer;

            Person producedPerson = personProducer.GetItem();

            Console.WriteLine($"Produced Person: {producedPerson.Name}");

            #endregion

            Console.WriteLine("==============");

            #region Q16 Contravariance

            // Contravariance allows a generic interface to use
            // a less derived type where a more derived type is expected.

            // The "in" keyword is used for contravariance.
            // It means the generic type is used as an input type.

            IConsumer<Person> personConsumer =
    new PersonConsumer();

            IConsumer<Student> studentConsumer =
                personConsumer;

            Student consumedStudent = new Student();

            consumedStudent.Name = "Ibrahim";

            studentConsumer.Consume(consumedStudent);

            #endregion

            Console.WriteLine("==============");

            #region Q17 Covariance vs Contravariance

            // Covariance uses the "out" keyword.
            // It allows conversion from a more derived type
            // to a less derived type.

            // Example:
            // IProducer<Student> -> IProducer<Person>


            // Contravariance uses the "in" keyword.
            // It allows conversion from a less derived type
            // to a more derived type.

            // Example:
            // IConsumer<Person> -> IConsumer<Student>

            #endregion

            Console.WriteLine("==============");

            #region Q18 Static Members in Generic Types

            // Static members in generic types are separate
            // for each closed generic type.

            // Example:
            // Counter<int> has its own static counter.
            // Counter<string> has another static counter.

            GenericCounter<int> intCounter1 = new GenericCounter<int>();
            GenericCounter<int> intCounter2 = new GenericCounter<int>();

            GenericCounter<string> stringCounter1 = new GenericCounter<string>();

            Console.WriteLine(
                $"int Counter: {GenericCounter<int>.Count}"
            );

            Console.WriteLine(
                $"string Counter: {GenericCounter<string>.Count}"
            );

            #endregion

            Console.WriteLine("==============");

            #region Q19 Inheritance from Generic Class

            // A class can inherit from a generic class
            // by passing a type parameter to the base class.

            // Example:
            // AdvancedContainer<T> : BaseContainer<T>

            AdvancedContainer<string> genericInheritance =
                new AdvancedContainer<string>();

            genericInheritance.Value = "Generic Inheritance";

            genericInheritance.Display();

            #endregion

            Console.WriteLine("==============");

            #region Q20 Generic Cache

            Cache<int, string> cache = new Cache<int, string>();

            cache.Add(
                1,
                "Laptop",
                TimeSpan.FromMinutes(5)
            );

            cache.Add(
                2,
                "Phone",
                TimeSpan.FromMinutes(5)
            );

            cache.Add(
    3,
    "Expired Item",
    TimeSpan.FromSeconds(-1)
);

            Console.WriteLine(
                $"Expired Key Exists: {cache.Contains(3)}"
            );

            Console.WriteLine($"Key 1 Exists: {cache.Contains(1)}");
            Console.WriteLine($"Key 2 Exists: {cache.Contains(2)}");

            Console.WriteLine($"Key 1 Value: {cache.Get(1)}");

            cache.Remove(2);

            Console.WriteLine($"Key 2 After Remove: {cache.Contains(2)}");



            #endregion
        }
    }
}
