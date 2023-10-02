using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ModeloParcial1
{
    /*
    Datos para el cálculo de la reparación
    Tipos de dispositivo a mostrar en el ComboBox: Smartphone, Tablet y Consola
    costo base: smartphone $5500, tablet $4850 y consola $9000
    los dias de plazo de entrega varian en función del dispositivo seleccionado:
    smartphone: entre 2 y 10 días (mostrar 2, 3, 4, 5, 6, 7, 8, 9 y 10)
    tablet: entre 1 y 7 días (mostrar 1, 2, 3, 4, 5, 6 y 7)
    consola: entre 5 y 12 días (mostrar 5, 6, 7, 8, 9, 10, 11 y 12)

    Opcionales: Actualizar software $1500, Extender la garantía $1000

    Forma de pago: Crédito: se agrega un 5% de recargo al precio total
    si es Contado se descuenta un 10% del precio total.
    
    
    El botón calcular se habilita solamente cuando se ingrese el nombre del cliente
    -En el evento del botón se realizará el cálculo y se mostrará su resultado en el TextBox "txtTotal", 
     además se almacenará en un arreglo de estructura REPARACION estos datos:
      - Cliente      string
      - Dispositivo  string
      - Importe      float
     El arreglo para almacenar las reparaciones tiene capacidad para 20 registros

    El botón Reporte mostrará en un cuadro de mensaje (MessageBox) la suma de todos los importes
    registrados en el arreglo.

    //Practicar con obtener el importe mas alto y el mas bajo del arreglo
    //Ver cuando en vez de un texto quiero un numero desde el formulario
     */

    public partial class frmService : Form
    {
        //Nombre del cliente
        string name;

        //Precio del dispositivo elegido
        int precio = 0;

        //Dispositivo elegido

        string dispositivo;

        //Opciones
        int opciones = 0;
        
        //Total

        float total = 0.0f;

        //Struct
        public struct REPARACION
        {
            public string Cliente;
            public string Dispositivo;
            public float Importe;
        }
        //Arreglo

        REPARACION[] misVentas;

        //Posicion de arranque para guardar las ventas en el arreglo
        int i = 0;

        //Importes totales

        float importesTotales = 0.0f;

        public frmService()
        {
            InitializeComponent();
        }

        private void frmService_Load(object sender, EventArgs e)
        {
           //El combo dispositivo arranca cargado de arranque
            cmbTipoDispositivo.Items.Add("Smartphone");
            cmbTipoDispositivo.Items.Add("Tablet");
            cmbTipoDispositivo.Items.Add("Consola");

           //El boton calcular arranca deshabilitado de arranque
            btnCalcular.Enabled = false;

            

            // Inicializar el arreglo de tipo reparacion
            misVentas = new REPARACION[20];
        }

        private void cmbTipoDispositivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Antes de que se ejecute el evento tipo de dispositivo tengo que limpiar el combo plazo de entrega sino se suman los valores que habia antes
            cmbPlazo.Items.Clear();

            //Si es tal dispositivo agrego dias de entrega de tal a tal numero
            
            if (cmbTipoDispositivo.SelectedItem.ToString() == "Smartphone")
            {
                for (int i = 2; i<= 10; i++)
                {
                    cmbPlazo.Items.Add(i);
                }
                precio = 5500;
            }
            if (cmbTipoDispositivo.SelectedItem.ToString() == "Tablet")
            {
                for (int i = 1; i <= 7; i++)
                {
                    cmbPlazo.Items.Add(i);
                }
                precio = 4850;
            }
            if (cmbTipoDispositivo.SelectedItem.ToString() == "Consola")
            {
                for (int i = 5; i <= 12; i++)
                {
                    cmbPlazo.Items.Add(i);
                }
                precio = 9000;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            //Nombre elegido en la caja
            name = txtNombre.Text;

            //Dispositivo elegido en el combo

            dispositivo = cmbTipoDispositivo.SelectedItem.ToString();
            
            //Opciones 
            if (chkActualizarSoftware.Checked)
            {
                // El CheckBox está marcado
                opciones += 1500;
            }
            if (chkExtenderGarantia.Checked)
            {
                // El CheckBox está marcado
                opciones += 1000;
            }

            //Total sin tener en cuenta la forma de pago
            total = precio + opciones;
            
            //Pago final
            if (optContado.Checked)
            {
                total = total - (total * 0.1f); //Descuento
            } else if (optCredito.Checked)
            {
                total = total + (total * 0.05f);//Recargo
            }

            //Total final con descuento o recargo depende

            txtTotal.Text = total.ToString();

            //Guardo datos en la estructura, la variable venta es de tipo reparacion

            // Crear una instancia de la estructura REPARACION
            REPARACION venta = new REPARACION();

            // Asignar valores a los campos de la structura.
            venta.Cliente = name;
            venta.Dispositivo = dispositivo;
            venta.Importe = total;



            ////Verifico que guarde
            ///
            //Console.WriteLine("Cliente: " + venta.Cliente);
            //Console.WriteLine("Dispositivo: " + venta.Dispositivo);
            //Console.WriteLine("Importe: " + venta.Importe);

            //Console.ReadKey();


            //Guardo datos en el arreglo teniendo en cuenta de ir cambiando el lugar donde se guarda
            
            if(i<20)
            {
               misVentas[i] = venta;
                i++;
            } else
            {
                MessageBox.Show("Arreglo de structuras lleno");
            }


            //Calculos los importes totales sumandolos

            importesTotales += total;



        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                // El TextBox está vacío o contiene solo espacios en blanco, deshabilita el botón
                btnCalcular.Enabled = false;
            }
            else
            {
                // El TextBox contiene texto, habilita el botón
                btnCalcular.Enabled = true;
            }
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); //Cierro formulario
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            MessageBox.Show(importesTotales.ToString());
        }
    }
}
