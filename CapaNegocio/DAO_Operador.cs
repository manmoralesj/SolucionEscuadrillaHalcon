using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
    public class DAO_Operador
    {
        EscHalconEntities db = new EscHalconEntities();

        public bool AgregarOperador(USUARIOS usu, OPERARIOS op, string pw)
        {
            try
            {
                db.SP_AGREGAR_OPERARIO(usu.ESTADO_IDESTADO, op.RUT,
                    usu.NOMBRES, usu.AP_PATERNO, usu.AP_MATERNO,
                    usu.DOMICILIO, usu.TEL_CEL, usu.TEL_FIJO, usu.CORREO, pw);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool ModificarOperador(USUARIOS usu, OPERARIOS op, string pw)
        {
            try
            {
                db.SP_MODIFICAR_OPERARIO(
                    usu.NOMBRES, usu.AP_PATERNO, usu.AP_MATERNO,
                    usu.DOMICILIO, usu.TEL_CEL, usu.TEL_FIJO, usu.CORREO,op.RUT, pw);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<OPERARIOS> BuscarOperario(string rut)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("OPERARIOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("OPERARIOS", rut);
                List<OPERARIOS> op = db.Database.SqlQuery<OPERARIOS>("begin sp_buscar_operador(:v_rut, :op); end;", param2, param1).ToList();

                return op;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarOperario(string rut)
        {
            try
            {
                db.SP_ELIMINAR_OPERADOR(rut);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
