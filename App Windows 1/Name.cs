using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Windows_1 {
    public partial class Name : Form {
        public Name() {
            
        InitializeComponent() ; 
        
        this.MaximizeBox = false ;
        this.MinimizeBox = false ;
        
        }

   /*     private void Name_Load(object sender, EventArgs e){

            MessageBox.Show("Bienvenidos, damas y caballeros,  a C#") ; 
      
            } */

        private void Name_FormClosed(object sender, FormClosedEventArgs e){

            MessageBox.Show("Gracias por usar la aplicación, hasta pronto") ;

        }

 /*  private void PrimerBoton_Click(object sender, EventArgs e)
{
    // string.IsNullOrWhiteSpace verifica tanto texto vacío como espacios en blanco
    if (!string.IsNullOrWhiteSpace(textBox1.Text))
    {
        // Restablecemos el color normal de fondo (SystemColor)
        textBox1.BackColor = SystemColors.Window; 

        MessageBox.Show("El nombre ingresado es: " + textBox1.Text);
    }
    else
    {
        textBox1.BackColor = Color.Red;
        MessageBox.Show("Por favor, ingrese un nombre.");
    }
}*/

private void PrimerBoton_Click(object sender, EventArgs e)
{
    // Validación básica de campos vacíos
    if (string.IsNullOrWhiteSpace(textBox1.Text) || 
        string.IsNullOrWhiteSpace(textBox2.Text) || 
        string.IsNullOrWhiteSpace(textBox4.Text) || 
        string.IsNullOrWhiteSpace(textBox3.Text))
    {
        MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    // Captura de variables
    string nombre = textBox1.Text;
    string apellido = textBox2.Text;
    string edad = textBox4.Text;
    string direccion = textBox3.Text;

    // Formateo e inyección del resultado en la caja multilínea
    textBox5.Text = $"Nombre: {nombre}" + Environment.NewLine +
                    $"Apellido: {apellido}" + Environment.NewLine +
                    $"Edad: {edad}" + Environment.NewLine +
                    $"Dirección: {direccion}";
}


     
/*private void Name_MouseClick(object sender, MouseEventArgs e)
{
    // 'e' ya es MouseEventArgs, no hace falta castear nada
    if (e.Button == MouseButtons.Left)
        MessageBox.Show("Presionó el botón Izquierdo", "Atención");
    else if (e.Button == MouseButtons.Right)
        MessageBox.Show("Presionó el Botón Derecho", "Atención");
    else if (e.Button == MouseButtons.Middle)
        MessageBox.Show("Presionó el botón del Medio", "Atención");
}
*/
        private void Name_Load(object sender, EventArgs e)
        {

        }

        private void lblEtiqueta_Click(object sender, EventArgs e)
        {
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = Color.Transparent ;
            lblEtiqueta.Cursor = Cursors.Default ; 
        }

     /*   private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e) {
            
            lblEtiqueta.BackColor = Color.Red ;
            lblEtiqueta.Cursor = Cursors.Hand ; 
        } 
        */
        private void textBox2_Leave(object sender, EventArgs e){ 
        
        MessageBox.Show("El apellido tiene: " + textBox2.Text.Length + " caracteres.") ;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}