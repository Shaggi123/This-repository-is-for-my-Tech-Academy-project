// Define the IQuittable interface
public interface IQuittable
{
    void Quit();
}

// Implement the Employee class and inherit the IQuittable interface
public class Employee : IQuittable
{
    public string Name { get; set; }

    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine("Employee quitting: " + Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type IQuittable and assign it an instance of Employee
        IQuittable quittableEmployee = new Employee { Name = "John Doe" };

        // Call the Quit() method on the object of type IQuittable
        quittableEmployee.Quit();

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
