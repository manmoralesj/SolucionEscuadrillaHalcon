using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDALC;
using System.Data.Objects;
using Oracle.ManagedDataAccess.Client;


using System.IO;
using System.Net;
using System.Net.Mail;


namespace CapaNegocio
{
    public class DAO_Usuario
    {
        EscHalconEntities db = new EscHalconEntities();
     

        public int login(string rut, string pass)
        {
            try
            {

                OracleParameter param1 = new OracleParameter("x_tipo_user", OracleDbType.Int32, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("in_rut", rut);
                OracleParameter param3 = new OracleParameter("in_pw", pass);
                int tipoTrabajador = db.Database.ExecuteSqlCommand("begin SP_LOGIN_RETORNA_NUMBER(:in_rut, :in_pw, :x_tipo_user); end;", param2, param3, param1);
                return int.Parse(param1.Value.ToString());
            }
            catch (OracleException ex)
            {
    
                return 0;
            }
        }

        public bool ModificarUsuario(USUARIOS usu, string pw)
        {
            try
            {
                db.SP_MODIFICAR_USUARIO(
                    usu.NOMBRES, usu.AP_PATERNO, usu.AP_MATERNO,
                    usu.DOMICILIO, usu.TEL_CEL, usu.TEL_FIJO, usu.CORREO, usu.RUT, pw);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<USUARIOS> BuscarUsuario(string rut)
        {
            try
            {
                OracleParameter param1 = new OracleParameter("USUARIOS", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                OracleParameter param2 = new OracleParameter("USUARIOS", rut);
                List<USUARIOS> usu = db.Database.SqlQuery<USUARIOS>("begin sp_buscar_usuario(:v_rut, :usu); end;", param2, param1).ToList();

                return usu;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DesactivarUsuario(string rut)
        {
            try
            {
                db.SP_DESACTIVAR_USUARIO(rut);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }




        public void correo(string aeronave,string destinatario)
        {
            using (MailMessage mm = new MailMessage("vueloescuadrillahalcon@gmail.com", destinatario))
            {
                mm.Subject = "Aviso de Aeronave";
                mm.Body = "Se comunica a ud. que la aeronave con matricula "+ aeronave+" queda fuera de servicio por motivos de operaciones de mantenimiento,   por favor considerar esta información para planificar sus vuelos. Por favor No responda este correo.";
                
                mm.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential("vueloescuadrillahalcon@gmail.com", "Escuadrilla.1234");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
               
                smtp.Send(mm);
               
            }
        }

        public List<AERONAVES> AlertaMantenimiento()
        {
            try
            {
                OracleParameter param1 = new OracleParameter("AERONAVES", OracleDbType.RefCursor, System.Data.ParameterDirection.Output);
                List<AERONAVES> av = db.Database.SqlQuery<AERONAVES>("begin sp_alerta_inspeccion_anual(:av); end;", param1).ToList();
                return av;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
