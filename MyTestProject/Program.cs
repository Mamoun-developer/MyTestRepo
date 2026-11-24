
using MyTestProject;

Person person = new Person();

person.Id = 1;
person.FullName = "Mamoun Haimour";
person.PhoneNumber = "0787872164";
person.EmailAddress = "MamounHaimour@gmail.com";
person.City = "Zarqa";

Console.Write($"Person Id: {person.Id}");
Console.Write($"Person Id: {person.FullName}");
Console.Write($"Person Id: {person.PhoneNumber}");
Console.Write($"Person City: {person.City}");
Console.Write($"Person EmailAddress: {person.EmailAddress}");

Console.WriteLine("this person his name is mamoun");

