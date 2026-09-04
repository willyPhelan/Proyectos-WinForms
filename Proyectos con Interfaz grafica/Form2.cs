using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Proyectos_con_Interfaz_grafica {
    public partial class Elemento : Form {
        public Elemento() { 
        
            InitializeComponent() ;
                            
            comboBox1.Items.Add("Norte"); // Desplego items al abrirse la pantalla

            comboBox1.Items.Add("Sur") ;

            comboBox1.Items.Add("Oeste") ; }

        private void Btn_Click(object sender, EventArgs e) {

            string elemento = textElemento.Text; 


            lwElemento.Items.Add(elemento) ;

        }

        private void textElemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

     
         
        /*     private void BotonSaludar_Click(object sender, EventArgs e) {

                string texto = textElemento.Text ;

                BotonSaludar.Text = "Hola " + texto ;  ;

             }


     */
        /*     private void Form2_Load(object sender, EventArgs e) { 



             }
             */


        /* private void Form2_FormClosing(object sender, FormClosingEventArgs e)
          {
              MessageBox.Show("Quisiera que esto dure para siempre...");
          }
          */

          private void VerPerfil_Click(object sender, EventArgs e) {
            
          // Escribí acá la lógica del botón
          MessageBox.Show("Mostrando el perfil...") ;
          
          string nombre = textElemento.Text ;

          DateTime fecha = dateTimePicker1.Value ;

          string fuma = checkBox1.Checked ? "Sí" : "No" ;

          string tipo ; 

          if(radioButton1.Checked) { tipo ="Bebe alcohol"  ; } else { tipo = "Bebe alcohol" ; }

          string region = comboBox1.SelectedItem?.ToString() ?? "No seleccionada" ;

          string paquete = numericUpDown1.Value.ToString() ;

          string mensaje = $"Nombre: {nombre}\nFecha: {fecha.ToShortDateString()}\nFuma: {fuma}\nTipo: {tipo}\nRegión: {region}\nPaquete: {paquete}";

          MessageBox.Show(mensaje, "Perfil del Usuario") ;
        }

        private void Elemento_Load(object sender, EventArgs e)
        {

        }
    }
    }


