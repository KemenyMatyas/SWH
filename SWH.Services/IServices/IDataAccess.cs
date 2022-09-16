namespace SWH.Services.IServices
{
    using System;
    using System.Collections.Generic;
    using SWH.Data.Models;

    public interface IDataAccess
    {
        public IEnumerable<Person> GetAllPersons();
        public Person GetPersonDetails(Guid id);
        public void EditPersonData(Person person);

        public Person LoginUserData(LoginUserDto userDto);
    }
}