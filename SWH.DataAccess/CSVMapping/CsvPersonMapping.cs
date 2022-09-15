namespace SWH.DataAccess.CSVMapping
{
    using Data.Models;
    using TinyCsvParser.Mapping;

    public class CsvPersonMapping : CsvMapping<Person>
    {
        public CsvPersonMapping() : base()
        {
            MapProperty(0, person => person.Id);
            MapProperty(1, person => person.UserName);
            MapProperty(2, person => person.Password);
            MapProperty(3, person => person.FirstName);
            MapProperty(4, person => person.LastName);
            MapProperty(5, person => person.BirthDay);
            MapProperty(6, person => person.PlaceOfBirth);
            MapProperty(7, person => person.Domicile);
        }
    }
}