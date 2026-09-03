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
    public partial class Form2 : Form {
        public Form2() { InitializeComponent() ; }

       
        private void BotonSaludar_Click(object sender, EventArgs e) {

           string texto = textBox1.Text ;

           BotonSaludar.Text = "Hola " + texto ;  ;
           
        }

        

    /*    private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bueeeenas");
        }
    
    */

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Quisiera que esto dure para siempre...");
        }

     

       }
    }


