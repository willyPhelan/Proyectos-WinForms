using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyectos_con_Interfaz_grafica {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {

            InitializeComponent() ;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e){

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e){

            
            foreach(var item in Application.OpenForms){
            
            if(item.GetType() == typeof(Elemento)) {

                MessageBox.Show("La ventana ya se encuentra abierta") ; // validacion para no abrir multiples ventanas de la misma clase
                    
                return ;
            }
           } ; // validacion para no abrir multiples ventanas de la misma clase        

            Elemento ventana = new Elemento() ; // guardo en memoria la ventana que quiero abrir

            ventana.MdiParent = this ;

            ventana.Show() ; // muestro la ventana

            
           
        }
        
        private void toolStripButton4_Click(object sender, EventArgs e)
        {


        }

        private void obtenerDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
