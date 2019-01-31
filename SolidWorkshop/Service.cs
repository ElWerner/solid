using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public class Service : IService
    {
        protected readonly IDbConnection _dbConnection;

        public Service(IDbConnection dbConnection)
        {
            if (dbConnection == null)
            {
                throw new ArgumentNullException($"{nameof(dbConnection)} is null.");
            }

            _dbConnection = dbConnection;
        }

        public void SaveEntity(IEntity entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException($"{nameof(entity)} is null.");
            }

            _dbConnection.Open();
            //perform Save
            _dbConnection.Close();
        }

        public IEnumerable<IEntity> ReadEntities()
        {
            _dbConnection.Open();
            //perform Save
            _dbConnection.Close();

            return new List<IEntity>();
        }

    }
}
