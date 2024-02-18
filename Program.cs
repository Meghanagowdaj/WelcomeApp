// See https://aka.ms/new-console-template for more information
using WelcomeAppNew;

Console.WriteLine("wlcome to authenticate app");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@1256"));