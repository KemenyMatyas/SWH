namespace SWH.DataAccess.Access
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using SWH.Data.Models;
    using SWH.DataAccess.CSVMapping;
    using SWH.DataAccess.IAccess;
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