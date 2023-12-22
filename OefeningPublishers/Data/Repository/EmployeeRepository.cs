using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Data.Repository
{
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public IEnumerable<Employee> OphalenEmployees()
        {
            string sql = "SELECT * FROM Employee ORDER BY lastName, firstName";

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>(sql);
            }
        }
        public List<Employee> OphalenEmployeesViaHireDate(DateTime hiredate)
        {
            string sql = "SELECT * FROM Employee WHERE hireDate <= @hiredate ORDER BY lastName, firstName"; ;

            var parameters = new { @hiredate = hiredate };

            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Employee>(sql, parameters).ToList();
            }
        }
    }
}
