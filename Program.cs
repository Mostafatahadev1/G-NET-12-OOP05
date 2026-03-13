
namespace G_NET_12_OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 1 Q1
            // An interface in C# is a contract that defines a set of methods or properties
            // that a class must implement. It does not contain the implementation, only
            // the method signatures.

            // We use interfaces instead of depending on concrete classes to depend on
            // abstraction rather than a specific implementation.

            // Benefits of using interfaces:
            // 1) Loose Coupling: Classes depend on the interface, not a specific class.
            // 2) Flexibility: We can change or replace implementations without modifying the main code.
            // 3) Easier Testing: Interfaces allow creating mock implementations for unit testing.
            // 4) Multiple Inheritance: A class can implement multiple interfaces.

            #endregion

            #region Part 1 Q2 A
            // a) The problem is that both interfaces contain a method called Greet().
            //    The Translator class currently provides only one implementation,
            //    so both interfaces will use the same method, which prevents having
            //    different behavior for each language.


            // class Translator : IEnglishSpeaker, IArabicSpeaker
            //     {
            //         public void Greet()
            //         {
            //             Console.WriteLine("Hello / Ahlan");
            //         }
            //     }


            #endregion

            #region Part 1 Q2 B
            // b) The fix is to use Explicit Interface Implementation so that each
            //    interface has its own implementation of Greet().
            //    This technique is called Explicit Interface Implementation.

            // class Translator implements both interfaces
            // class Translator : IEnglishSpeaker, IArabicSpeaker

            // explicit implementation of Greet() for IEnglishSpeaker
            // void IEnglishSpeaker.Greet()
            // {
            //     Console.WriteLine("Hello");
            // }

            // explicit implementation of Greet() for IArabicSpeaker
            // void IArabicSpeaker.Greet()
            // {
            //     Console.WriteLine("Ahlan");
            // }


            #endregion

            #region Part 1 Q2 C

            // c) No, we cannot call Greet() directly on the Translator object
            //    because the methods are implemented explicitly.
            //    We must cast the object to the appropriate interface.

            // creating an object of Translator
            // Translator translator = new Translator();

            // calling the English version of Greet()
            // ((IEnglishSpeaker)translator).Greet(); // Hello

            // calling the Arabic version of Greet()
            // ((IArabicSpeaker)translator).Greet();  // Ahlan
            #endregion

            #region Part 1 Q3
            // A shallow copy creates a new object but copies the references of reference-type fields.
            // This means both objects share the same referenced objects in memory.

            // A deep copy creates a completely independent copy of the object,
            // including new copies of all reference-type fields.

            // When to use each:
            // Shallow Copy: used when the object contains only value types or when
            // sharing referenced objects is acceptable.

            // Deep Copy: used when we need a completely independent object and
            // changes in the copy should not affect the original object.

            // Risk of using Shallow Copy:
            // If the object contains reference-type fields, both the original object
            // and the copied object will point to the same referenced data.
            // Modifying the data in one object will also affect the other object.

            #endregion

            #region Part 1 Q4

            /*
            Output Explanation:
            
            class Department { public string Name; }
            class Employee
            {
                public string Title;
                public Department Dept;
                public Employee ShallowCopy() => (Employee)this.MemberwiseClone();
            }
            
            var e1 = new Employee { Title = "Dev", Dept = new Department { Name = "IT" } };
            var e2 = e1.ShallowCopy();
            e2.Title = "QA";
            e2.Dept.Name = "Testing";
            
            // Shallow copy: e2 shares the same Dept object as e1
            // Modifying e2.Dept.Name also changes e1.Dept.Name
            // But e2.Title is independent
            
            Console.WriteLine($"{e1.Title} - {e1.Dept.Name}"); // Output: Dev - Testing
            Console.WriteLine($"{e2.Title} - {e2.Dept.Name}"); // Output: QA  - Testing
            */
            #endregion
        }
    }
}
