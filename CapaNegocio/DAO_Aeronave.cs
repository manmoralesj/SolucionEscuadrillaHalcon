using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
     public class DAO_Aeronave
    {

        EscHalconEntities db = new EscHalconEntities();

        public bool AgregarAeronave(AERONAVES av)
        {
            try
            {
                db.SP_INGRESAR_AERONAVE(av.TIPO_AERONAVE_IDTIPO_AERONAVE, av.ESTADO_IDESTADO, av.FABRICANTES_AERO_IDFABRICANTE, av.MODELOS_AERO_IDMODELO,
                    av.HORAS_VOLADAS, av.CANT_MAX_HORAS, av.PATENTE, av.ANIO_FAB, av.CANT_MAX_PILOTOS, av.FECHA_INSPECCION_ANUAL, av.CAP_LITROS,
                    av.MOTOR, av.RUEDAS, av.CANT_HELICES, av.CANT_TURBINAS);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        


        public List<AERONAVES> BuscarAeronave(string matricula)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("AERONAVES", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("AERONAVES", matricula);
                List<AERONAVES> av = db.Database.SqlQuery<AERONAVES>("begin sp_buscar_aeronave(:v_matricula, :av); end;", param2, param1).ToList();

                return av;
            }
            catch (Exception)
            {

                throw;
            }
        }
  
        public bool ModificarAeronave(AERONAVES av)
        {
            try
            {
                db.SP_MODIFICAR_AERONAVE(av.TIPO_AERONAVE_IDTIPO_AERONAVE, av.ESTADO_IDESTADO, av.FABRICANTES_AERO_IDFABRICANTE, av.MODELOS_AERO_IDMODELO,
                    av.HORAS_VOLADAS, av.CANT_MAX_HORAS, av.PATENTE, av.ANIO_FAB, av.CANT_MAX_PILOTOS, av.FECHA_INSPECCION_ANUAL, av.CAP_LITROS,
                    av.MOTOR, av.RUEDAS, av.CANT_HELICES, av.CANT_TURBINAS,av.IDAERONAVE);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool DesactivarAeronave(string patente)
        {
            try
            {
                db.SP_DESACTIVAR_AERONAVE(patente);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
