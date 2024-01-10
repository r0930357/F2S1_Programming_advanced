using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorbereidingsexamen.Data.Repository
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public List<Employee> OphalenWerkenemrsUSA()
        {
            string sql = "SELECT E.*, P.* FROM Employee E INNER JOIN Publisher P ON E.publisherId = P.id WHERE P.country = 'USA'";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                var debugVar = db.Query<Employee, Publisher, Employee>(
                    sql,
                    (employee, publisher) =>
                    {
                        employee.publiser = publisher;
                        return employee;
                    },
                    splitOn: "Id"
                );
                return debugVar.ToList();
            }
        }
    }
}
