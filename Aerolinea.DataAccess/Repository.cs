using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private OrmLiteConnectionFactory _conexion;
        private IDbConnection _db;

        public Repository()
        {
            _conexion = new OrmLiteConnectionFactory(BD.Default.conexion, SqlServerDialect.Provider);
            this._db = _conexion.Open();
        }

        public virtual List<T> GetAll()
        {
            return _db.Select<T>();
        }

        public List<T> Get(Expression<Func<T, bool>> exp)
        {
            return _db.Select<T>(exp);
        }

        public virtual T GetById(int id)
        {
            var o = _db.SingleById<T>(id);
            return o;
        }

        public virtual T GetById(string id)
        {
            var o = _db.SingleById<T>(id);
            return o;
        }

        public bool Save(T o)
        {
            _db.Save<T>(o);
            return true;
        }

        public void Delete(int id)
        {
            _db.DeleteById<T>(id);
        }

        public void Delete(Expression<Func<T, bool>> exp)
        {
            _db.Delete<T>(exp);
        }
    }
}
