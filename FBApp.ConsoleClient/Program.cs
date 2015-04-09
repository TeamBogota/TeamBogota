namespace FBApp.ConsoleClient
{
    using System;
    using FaceBookApp.Data;
    using FaceBookApp.Models;

    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new FaceBookAppDbContext();

            var user = new User
            {
                Username = "Pecata",
                Password = "Pecata",
                Birthday = new DateTime(1981, 11, 20),
                FirstName = "Petko",
                LastName = "Petkov",
                Email = "Pecata@gmail.com",
                Gender = Gender.Male
            };

            db.Users.Add(user);
            db.SaveChanges();

            Console.WriteLine(user.UserId + ": " + user.Username);
        }
    }
}
