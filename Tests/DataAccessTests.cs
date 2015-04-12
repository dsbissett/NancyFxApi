using DataAccess.EDMX;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Tests
{
    public class DataAccessTests
    {
        public DataAccessTests()
        {
            _repository = new EmployeesRepository();

            _employee = CreateDummyEmployee();
        }

        private EmployeesRepository _repository;
        private Employees _employee;

        private Employees CreateDummyEmployee()
        {
            const string test = "TEST";

            return new Employees
            {
                LastName = test,
                FirstName = test,
                Title = test,
                TitleOfCourtesy = test,
                BirthDate = DateTime.Now.AddYears(-35).Date,
                HireDate = DateTime.Now.AddDays(-345).Date,
                Address = test,
                City = test,
                Region = test,
                PostalCode = test,
                Country = test,
                HomePhone = test,
                Extension = test,
                Photo = null,
                Notes = null,
                ReportsTo = 2,
                PhotoPath = null
            };
        }

        [Fact]
        public void CanGetEmployees()
        {
            var result = _repository.Get();

            Assert.NotNull(result);
            Assert.IsType(typeof(List<Employees>), result);
        }

        [Fact]
        public void CanCreateEmployee()
        {
            var result = _repository.Create(_employee);

            Assert.NotNull(result);
            Assert.IsType(typeof(Employees), result);
        }

        [Fact]
        public void CanUpdateEmployee()
        {
            var employee = _repository.FindOne(x => x.FirstName == "UpdateTest");
            employee.FirstName = "UpdateTest";
            employee.LastName = "UpdateTest";

            var result = _repository.Update(employee);

            Assert.NotNull(result);
            Assert.Equal(employee.FirstName, "UpdateTest");
            Assert.Equal(employee.LastName, "UpdateTest");
        }

        [Fact]
        public void CanDeleteEmployee()
        {
            var employee = _repository.FindOne(x => x.FirstName == "UpdateTest");

            var result = _repository.Delete(employee);

            Assert.NotNull(result);
        }

        [Fact]
        public void CanFindOneEmployee()
        {
            var result = _repository.FindOne(x => x.FirstName == "Robert");

            Assert.NotNull(result);
            Assert.True(result.LastName == "King");
        }

        [Fact]
        public void CanFindManyEmployees()
        {
            var result = _repository.FindMany(x => x.City == "London");

            Assert.NotNull(result);
            Assert.True(result.Count() == 4);
        }
    }
}
