namespace Solid_Responsiblity_principle
{
    //Solid Responsibilitiy Principle - A class should have only one reason to change,
    // - meaning it should have only one rresponsibilityor purpose
    internal class Program
    {
        static void Main(string[] args)
        {
            // Without Solid Responsibility Principle
            //look into the user class
            User user = new User();

            //User class manages both properties and methods 
            user.UserName = "Test";
            user.Password = "password";
            user.email = "Test";

            user.Register();

/////////////////////////////////////////////////////////////////////////////////////////////
            
            // With Solid Responsibility Principle
            //look into Usermodel and Userservice class

            //Usermodel manages only properties
            UserModel model = new UserModel();
            model.UserName = "Test";
            model.Password = "password";
            model.email = "Test";

            //userService Manages only Register method
            UserService service = new UserService();
            service.Register(model.email);




            Console.ReadLine();
        }
    }
}
