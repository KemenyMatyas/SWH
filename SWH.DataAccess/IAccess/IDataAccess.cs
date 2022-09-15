namespace SWH.DataAccess.IAccess
{
    using System;
    using System.Collections.Generic;
    using Data.Models;

    public interface IDataAccess
    {
        public IEnumerable<Person> GetAllPersons();
        public Person GetPersonDetails(Guid id);
    }
}