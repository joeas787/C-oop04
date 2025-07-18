using System.Reflection.Metadata;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1-To define a blueprint for a class
            //2-private
            3-no
            4-Yes, interfaces can inherit from multiple interfaces
            5-:
            6-yes
            7- No, all members are implicitly public
            8-To hide the interface members from outside access
            9-No, interfaces cannot have constructors
            10-By separating interface names with commas
            */
           
            
            

            
        }
    }
    
}
#region 1
interface IShape
{
   public double Area { get; }
    void DisplayShapeInfo();
}
interface ICircle : IShape
{
  public  double Radius { get; set; }
}
interface IRectangle : IShape
{
   public double Width { get; set; }
   public double Height { get; set; }
}
class Circle : ICircle
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Area => Math.PI * Radius * Radius;

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine();
    }
}
class Rectangle : IRectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area => Width * Height;
     

    public void DisplayShapeInfo()
    {
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine();
    }
}
#endregion
#region 2
public interface IAuthenticationService
{
    bool AuthenticateUser(string username, string password);
    bool AuthorizeUser(string username, string role);
}
public struct User
{
    public string Username;
    public string Password;
    public string Role;
}
public class BasicAuthenticationService  : IAuthenticationService
{

    private User[] users = new User[]
   {
        new User { Username = "joe", Password = "1234", Role = "Admin" },
        new User { Username = "ashraf", Password = "abcd", Role = "User" },
        new User { Username = "mona", Password = "1234", Role = "Editor" }
   };




    public bool AuthenticateUser(string username, string password)
    {
        foreach (var user in users)
        {
            if (user.Username == username && user.Password == password)
                return true;
        }
        return false;
    }

    public bool AuthorizeUser(string username, string role)
    {
        foreach (var user in users)
        {
            if (user.Username == username && user.Role == role)
                return true;
        }
        return false;
    }
}
#endregion
#region 3
public interface INotificationService
{
    void SendNotification(string recipient, string message);
}



public class EmailNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($" Email sent to {recipient}: {message}");
    }
}

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($" SMS sent to {recipient}: {message}");
    }
}

public class PushNotificationService : INotificationService
{
    public void SendNotification(string recipient, string message)
    {
        Console.WriteLine($" Push notification sent to {recipient}: {message}");
    }
}

#endregion






