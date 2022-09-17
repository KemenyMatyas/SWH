namespace SWH.Services.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using SWH.Data.Models;
    using SWH.Services.IServices;

    public class DataAccess : IDataAccess
    {
        public IEnumerable<Person> GetAllPersons()
        {
            var persons = File.ReadLines("..\\database.csv").Skip(1)
                .Select(ParsePersonFromLine).ToList();

            return persons;
        }

        public Person GetPersonDetails(Guid id)
        {
            var person = File.ReadLines("..\\database.csv")
                .Skip(1)
                .Select(ParsePersonFromLine)
                .FirstOrDefault(p => p.Id == id);
            return person;
        }

        public void EditPersonData(Person person)
        {
            IEnumerable<Person> persons = new List<Person>();

            var firstLine = true;
            foreach (var line in File.ReadLines("..\\database.csv"))
            {
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }
                
                if (ParsePersonFromLine(line).Id == person.Id)
                {
                    persons = persons.Append(person);
                    continue;
                }

                persons =persons.Append(ParsePersonFromLine(line));
            }

            File.WriteAllLines("..\\database.csv", ParsePersonToString(persons));
        }

        public Person LoginUserData(LoginUserDto userDto)
        {
            var person = File.ReadLines("..\\database.csv")
                .Skip(1)
                .Select(ParsePersonFromLine)
                .FirstOrDefault(p => p.UserName == userDto.UserName && p.Password == userDto.Password);
            return person;
        }


        private static Person ParsePersonFromLine(string line)
        {
            var parts = line.Split(',');
            return new Person
            {
                Id = Guid.Parse(parts[0]),
                UserName = parts[1],
                Password = parts[2],
                FirstName = parts[3],
                LastName = parts[4],
                BirthDay = DateTime.Parse(parts[5]),
                PlaceOfBirth = parts[6],
                Domicile = parts[7],
            };
        }

        private static IEnumerable<string> ParsePersonToString(IEnumerable<Person> persons)
        {
            IEnumerable<string> strings = new List<string>();
            strings =strings.Append("Guid,UserName,Password,FirstName,LastName,BirthDay,PlaceOfdBirth,Domicile");
            strings = strings.Union(persons.Select(p =>
                    $"{p.Id}," +
                    $"{p.UserName}," +
                    $"{p.Password}," +
                    $"{p.FirstName}," +
                    $"{p.LastName}," +
                    $"{p.BirthDay.ToString("yyyy/MM/dd")}," +
                    $"{p.PlaceOfBirth}," +
                    $"{p.Domicile}"));
            return strings;
        }
    
    }
}