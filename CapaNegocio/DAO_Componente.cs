using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
    public class DAO_Componente
    {
        EscHalconEntities db = new EscHalconEntities();

        public bool AgregarComponente(COMPONENTES co)
        {
            try
            {
                db.SP_AGREGAR_COMPONENTE(co.ESTADO_IDESTADO, co.NOMBRE, co.HORAS_USADO, co.HORAS_MAX_USO,
                    co.VECES_USADO,co.MAX_NUM_USOS,co.COMPONENTES_IDCOMPONENTE);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool DesactivarComponente(int id)
        {
            try
            {
                db.SP_DESACTIVAR_COMPONENTE(id);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool ModificarComponente(COMPONENTES co)
        {
            try
            {
                db.SP_MODIFICAR_COMPONENTE( co.NOMBRE, co.HORAS_USADO, co.HORAS_MAX_USO,
                    co.VECES_USADO, co.MAX_NUM_USOS, co.COMPONENTES_IDCOMPONENTE,co.IDCOMPONENTE);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<COMPONENTES> BuscarComponente(int id)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("COMPONENTES", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("COMPONENTES", id);
                List<COMPONENTES> com = db.Database.SqlQuery<COMPONENTES>("begin sp_buscar_componentes(:v_idcomponente, :co); end;", param2, param1).ToList();
                return com;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
