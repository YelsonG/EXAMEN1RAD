using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN1RAD.CONTROLES
{
    public class DataBase
    {
        readonly SQLiteAsyncConnection _connection;
        public DataBase() { }


        public DataBase(string dbpath)
        {
        _connection = new SQLiteAsyncConnection(dbpath);

        _connection.CreateTableAsync<Models.ESTUDIANTES>().Wait();

        }

        public Task<int> AddEstudiante(Models.ESTUDIANTES est)
        {
            if (est.id == 0)
            {
                return _connection.InsertAsync(est);
            }
            else
            {
                return _connection.UpdateAsync(est);
            }
        }

        public Task<List<Models.ESTUDIANTES>> ObtenerListaEstudiante()
        {
            return _connection.Table<Models.ESTUDIANTES>().ToListAsync();
        }

        public Task<Models.ESTUDIANTES> ObtenerEstudiante(int pid)
        {
            return _connection.Table<Models.ESTUDIANTES>().Where(i => i.id == pid).FirstOrDefaultAsync();
        }

        public Task<int> DeleteEstudiante(Models.ESTUDIANTES est)
        {
            return _connection.DeleteAsync(est);
        }
    }
}
