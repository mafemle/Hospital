using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CapaEntidad;
using CapaReglasNegocio;
using System.Data;

namespace Hostipal
{
    public partial class Pacientes : System.Web.UI.Page
    {
        CRegPaciente oregpaciente = new CRegPaciente();
        ClEntidadPaciente oentpaciente = new ClEntidadPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btconsultarPaciente_Click(object sender, EventArgs e)
        {
            if (TxtId_paciente.Text =="")
            {
                lblConsultarPaciente.Text = "No se ha digitado codigo Paciente";
                TxtId_paciente.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oentpaciente.Id_paciente1 = TxtId_paciente.Text;
                
                ds = oregpaciente.consultar_Paciente(oentpaciente);

                if (ds.Tables[0].Rows.Count==0)
                {
                    lblConsultarPaciente.Text = "No hay registros del paciente";
                    Txtnom_paciente.Focus();
                }
                else
                {
                    Droptip_doc.Text= ds.Tables[0].Rows[0]["tip_doc"].ToString();
                    Txtnom_paciente.Text = ds.Tables[0].Rows[0]["nom_paciente"].ToString();
                    Txtdir_paciente.Text= ds.Tables[0].Rows[0]["dir_paciente"].ToString();                   
                    Txttel_paciente.Text = ds.Tables[0].Rows[0]["tel_paciente"].ToString();
                    Txtcel_paciente.Text = ds.Tables[0].Rows[0]["cel_paciente"].ToString();

                    lblConsultarPaciente.Text = "Ya existe un registro del paciente";

                }
            }
        }

        protected void btguardarPaciente_Click(object sender, EventArgs e)
        {
            oentpaciente.Id_paciente1 = TxtId_paciente.Text;
            oentpaciente.Tip_doc = Droptip_doc.Text;
            oentpaciente.Nom_paciente = Txtnom_paciente.Text;
            oentpaciente.Tel_paciente = Txttel_paciente.Text;
            oentpaciente.Cel_paciente = Txtcel_paciente.Text;
            oentpaciente.Dir_paciente = Txtdir_paciente.Text;

            if (oregpaciente.guardar_Paciente(oentpaciente))
            {
                lblguardarPaciente.Text = "Registro guardado Exitosamente";
            }
            else
            {
                lblguardarPaciente.Text = "Registro no pudo ser guardado";
            }
        }
    }
}