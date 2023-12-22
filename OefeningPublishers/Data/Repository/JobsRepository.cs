using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefeningPublishers.Data.Repository
{
    public class JobsRepository : BaseRepository, IJobsRepository
    {
        public IEnumerable<Job> OphalenJobs()
        {
            string sql = "SELECT * FROM job ORDER BY description";
            using (IDbConnection db = new SqlConnection(ConnectionString))
            {
                return db.Query<Job>(sql);
            }
        }
    }
}
