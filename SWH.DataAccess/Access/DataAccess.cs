namespace SWH.DataAccess
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;
    using CSVMapping;
    using Data.Models;
    using IAccess;
    using TinyCsvParser;
    

    public class DataAccess : IDataAccess
    {
        public IEnumerable<Person> GetAllPersons()
        {
            var csvParserOptions = new CsvParserOptions(true, ',');
            var csvParser = new CsvParser<Person>(csvParserOptions, new CsvPersonMapping());
            var records = csvParser.ReadFromFile("..\\database.csv", Encoding.UTF8);
            var persons =  records.Select(person => person.Result).ToList();
            return persons;
        }

        public Person GetPersonDetails(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}