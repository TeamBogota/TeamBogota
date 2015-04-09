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
                Username = "Pesho",
                Password = "Pesho",
                Birthday = new DateTime(1981, 11, 20),
                FirstName = "Pesho",
                LastName = "Pesho",
                Email = "pesho@gmail.com",
                Gender = Gender.Male
            };

            db.Users.Add(user);
            db.SaveChanges();

            Console.WriteLine(user.UserId + ": " + user.Username);
        }
    }
}
