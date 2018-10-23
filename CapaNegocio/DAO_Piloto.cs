using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
    public class DAO_Piloto
    {
        EscHalconEntities db = new EscHalconEntities();

        public bool AgregarPiloto(USUARIOS usu,PILOTOS pi, string pw)
        {
            try
            {
                db.SP_AGREGAR_PILOTO(usu.ESTADO_IDESTADO, pi.RUT,
                    usu.NOMBRES, usu.AP_PATERNO, usu.AP_MATERNO,
                    usu.DOMICILIO, usu.TEL_CEL, usu.TEL_FIJO, usu.CORREO, pi.HORAS_VOLADAS,pw);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool ModificarPiloto(USUARIOS usu, PILOTOS pi, string pw)
        {
            try
            {
                db.SP_MODIFICAR_PILOTO(usu.ESTADO_IDESTADO, pi.RUT,
                    usu.NOMBRES, usu.AP_PATERNO, usu.AP_MATERNO,
                    usu.DOMICILIO, usu.TEL_CEL, usu.TEL_FIJO, usu.CORREO, pi.HORAS_VOLADAS, pw);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<USUARIOS> BuscarPiloto(string rut)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("USUARIOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("USUARIOS", rut);
                List<USUARIOS> pi = db.Database.SqlQuery<USUARIOS>("begin sp_buscar_piloto(:v_rut, :pi); end;", param2, param1).ToList();

                return pi;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<USUARIOS> listarPiloto()
        {
            try
            {
                OracleParameter param1 = new OracleParameter("USUARIOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                List<USUARIOS> pi = db.Database.SqlQuery<USUARIOS>("begin sp_listado_pilotos( :usu); end;", param1).ToList();

                return pi;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EliminarPiloto(string rut)
        {
            try
            {
                db.SP_ELIMINAR_PILOTO(rut);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
