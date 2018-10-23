using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using Oracle.ManagedDataAccess.Client;

namespace CapaNegocio
{
    
    public class DAO_Vuelo
    {
        //string rutPiloto, rutCopiloto="N/A";
        //int idPiloto,idCopiloto=0;
        EscHalconEntities db = new EscHalconEntities();

        public bool AgregarVuelo(VUELOS vu, string rutPiloto, string rutCopiloto, int idPiloto, int idCopiloto)
        {
            try
            {
                db.SP_AGREGAR_VUELO(vu.ESTADO_IDESTADO,vu.AERONAVES_IDAERONAVE,vu.HORAS_ESTIMADAS,
                    vu.MISION,vu.FECHAHORA_INICIO,vu.CONDICION_IDCONDICION_VUELO,idPiloto,idCopiloto,rutPiloto,rutCopiloto);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool CompletarVuelo(int id, int horas)
        {
            try
            {
                db.SP_COMPLETAR_VUELO(id,horas);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }



        public List<VUELOS> BuscarVuelos(int id)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("VUELOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("VUELOS", id);
                List<VUELOS> vu = db.Database.SqlQuery<VUELOS>("begin sp_buscar_vuelo(:v_idvuelo, :vu); end;", param2, param1).ToList();

                return vu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CL_PILOTOS_VUELOS> BuscarPilotos(int id)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("PILOTOS_VUELOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("PILOTOS_VUELOS", id);
                List<CL_PILOTOS_VUELOS> vu = db.Database.SqlQuery<CL_PILOTOS_VUELOS>("begin sp_buscar_pilotos_vuelo(:v_idvuelo, :vu); end;", param2, param1).ToList();

                return vu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CL_COPILOTOS_VUELOS> BuscarCopilotos(int id)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("PILOTOS_VUELOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("PILOTOS_VUELOS", id);
                List<CL_COPILOTOS_VUELOS> vu = db.Database.SqlQuery<CL_COPILOTOS_VUELOS>("begin sp_buscar_copilotos_vuelo(:v_idvuelo, :pi); end;", param2, param1).ToList();

                return vu;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool BuscarCompletarVuelo(int id)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("VUELOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("VUELOS", id);
                List<VUELOS> vu = db.Database.SqlQuery<VUELOS>("begin sp_buscar_vuelo(:v_idvuelo, :vu); end;", param2, param1).ToList();
                if (vu.Count > 0)
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
        public bool ModificarVuelo(VUELOS vu, string rutPiloto, string rutCopiloto, int idPiloto, int idCopiloto)
        {
            try
            {
                db.SP_MODIFICAR_VUELO(vu.AERONAVES_IDAERONAVE,vu.HORAS_ESTIMADAS,vu.MISION,vu.FECHAHORA_INICIO,vu.CONDICION_IDCONDICION_VUELO,
                    idPiloto,rutPiloto,idCopiloto,rutCopiloto, vu.IDVUELO);
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
