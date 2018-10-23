using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
     public class DAO_Consultor
    {
        EscHalconEntities db = new EscHalconEntities();

        public bool AgregarOperador(USUARIOS usu, CONSULTORES co, string pw)
        {
            try
            {
                db.SP_AGREGAR_CONSULTOR( co.RUT,
                    usu.NOMBRES, usu.AP_PATERNO, usu.AP_MATERNO,
                    usu.DOMICILIO, usu.TEL_CEL, usu.TEL_FIJO, usu.CORREO, pw);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool ModificarOperador(USUARIOS usu, CONSULTORES co, string pw)
        {
            try
            {
                db.SP_MODIFICAR_CONSULTOR(
                    usu.NOMBRES, usu.AP_PATERNO, usu.AP_MATERNO,
                    usu.DOMICILIO, usu.TEL_CEL, usu.TEL_FIJO, usu.CORREO, co.RUT, pw);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<CONSULTORES> BuscarConsultor(string rut)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("CONSULTORES", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("CONSULTORES", rut);
                List<CONSULTORES> co = db.Database.SqlQuery<CONSULTORES>("begin sp_buscar_consultor(:v_rut, :co); end;", param2, param1).ToList();

                return co;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarConsultor(string rut)
        {
            try
            {
                db.SP_ELIMINAR_CONSULTOR(rut);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
