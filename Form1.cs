using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ErrorProvider ep = new ErrorProvider();

        private void Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Aceptartxt.Text=="")
                {
                    ep.SetError(Aceptartxt,"No ha ingresado matricula");
                }
                else if (Matriculatxt.Text=="")
                {
                    ep.SetError(Matriculatxt, "No ha ingresado nombre");
                }
                else if (Semestretxt.Text=="")
                {
                    ep.SetError(Semestretxt, "No ha ingresado semestre");
                }
                else if (Carreratxt.Text=="")
                {
                    ep.SetError(Carreratxt,"No ha ingresado carrera");
                }
                else if (Telefonotxt.Text=="")
                {
                    ep.SetError(Telefonotxt, "No ha ingresado telefono");
                }
            }
            catch (System.Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Valor Incorrecto");

                
                
                
            }

            try
            {
                Alumno al = new Alumno();
                al.Matricula = Convert.ToInt32(Aceptartxt.Text);
                al.Nombre = Matriculatxt.Text;
                al.Semestre = Convert.ToInt32(Semestretxt.Text);
                al.Carrera = Carreratxt.Text;
                al.Telefono = Convert.ToInt32(Telefonotxt.Text);

                throw new SpecialException("Su alumno se creo exitosamente");

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Falla en registrar alumno"+"\n"+ex.Message);

            }
            catch (SpecialException espex)
            {
                MessageBox.Show(espex.Message);
            }
            finally
            {
                ep.Clear();
            }

         
            

            
        }

        private void txtCalif_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int cal = Convert.ToInt32(txtCalif.Text);
                if (cal<1 || cal>10)
                {
                    MessageBox.Show("Ingrese una calificacion de 1 a 10 ", " Error ");
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show("Erro en la entrada de datos"+
                MessageBoxButtons.YesNo+MessageBoxIcon.Error);
            }
        }
    }
}
