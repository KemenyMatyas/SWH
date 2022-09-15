namespace SWH.Data.Models
{
    using System;

    public class Person
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Domicile { get; set; }
        public string PlaceOfBirth { get; set; }
    }
}