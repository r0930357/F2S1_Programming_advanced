using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningKlassikaalSQL.Data.Repository
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> OphalenEmployees();

        public List<Employee> OphalenEmployeesViaHireDate(DateTime hiredate);

        public List<Employee> OphalenEmployeesViaJob_id(int jobId);

        public List<Employee> OphalenEmployeesViaPub_id(int id);

        public List<Employee> OphalenEmployeesViaPub_idEnJob_id(int pubId, int jobId);

        public Employee OphalenEmployeeViaPK(int id);
    }
}
