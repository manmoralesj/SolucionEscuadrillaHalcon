using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
   public class DAO_Credenciales
    {
        EscHalconEntities db = new EscHalconEntities();

        public List<CREDENCIALES> BuscarCredenciales(string rut)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("CREDENCIALES", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("CREDENCIALES", rut);
                List<CREDENCIALES> cred = db.Database.SqlQuery<CREDENCIALES>("begin sp_buscar_credenciales(:v_rut, :cred); end;", param2, param1).ToList();

                return cred;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
