using System;

namespace prg15
{
    class ExceptionalHandling
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.displayAge();

            }
            catch (AgelsNegativeException e)
            {
                Console.WriteLine("AngelsNegativeException:{0}", e.Message);

            }
            finally
            {
                Console.WriteLine("Execution of Finally block is done. ");

            }
        }
    }
}
public class AgelsNegativeException : Exception
{
    public AgelsNegativeException(string message):base(message)
    {

    }
}
public class Age
{
    int age = -5;
    public void displayAge()
    {
        if(age<0)
        {
            throw (new AgelsNegativeException("Age cannot be negative"));
        }
        else
        {
            Console.WriteLine("Age is:{0}", age);
        }
    }
}