using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
     public class DAO_Mantenimiento
    {
        EscHalconEntities db = new EscHalconEntities();

        public bool AgregarMantenimiento(MANTENIMIENTOS ma)
        {
            try
            {
                db.SP_AGREGAR_MANTENIMIENTO(ma.AERONAVES_IDAERONAVE,ma.ESTADO_IDESTADO,ma.OBS,ma.COMPONENTES_IDCOMPONENTE);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool CompletarMantenimiento(int id)
        {
            try
            {
                db.SP_COMPLETAR_MANTENIMIENTO(id);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



        public List<MANTENIMIENTOS> BuscarMantenimiento(int id)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("MANTENIMIENTOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("MANTENIMIENTOS", id);
                List<MANTENIMIENTOS> man = db.Database.SqlQuery<MANTENIMIENTOS>("begin sp_buscar_mantencion(:v_idmantenimiento, :man); end;", param2, param1).ToList();
                return man;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool BuscarCompletarMantenimiento(int id)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("MANTENIMIENTOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("MANTENIMIENTOS", id);
                List<MANTENIMIENTOS> man = db.Database.SqlQuery<MANTENIMIENTOS>("begin sp_buscar_mantencion(:v_idmantenimiento, :man); end;", param2, param1).ToList();
                if (man.Count >0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ModificarMantenimiento(MANTENIMIENTOS ma)
        {
            try
            {
                db.SP_MODIFICAR_MANTENIMIENTO(ma.AERONAVES_IDAERONAVE, ma.ESTADO_IDESTADO, ma.OBS, ma.COMPONENTES_IDCOMPONENTE,ma.IDMANTENIMIENTO);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
