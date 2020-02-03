using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes
{
    public partial class Form1 : Form
    {

        // creo la cadena de conexion con  LINQ q conecta a la BDatos 
        DataClasses1DataContext PROYECTO = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();
        }
        //  para que carga el formulario,  
        private void Form1_Load(object sender, EventArgs e)
        {
            cargaGrid();
            // cargar el 2º datagrid y
            cargaGrid2();
        }
        // creo los Método para cargar el Datagrid
        public void cargaGrid()
        {
            // objeto de la clase DataClasses1DataContext
            PROYECTO = new DataClasses1DataContext();
            dataGridView1.DataSource = (from p in PROYECTO.VIAJES
                                        select p);
            comboBoxContolBuscar.DataSource = (from p in PROYECTO.VIAJES
                                               select p.IdViaje);
        }//end método cargarGrig
        
        // añadir los datos de los clientes
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // creo la variables 
            string viaje, usuario, discapacidad, destino, sexo ;
            int satisfacion;
            DateTime fecha;
            try
            {
                viaje = txtControl_idViaje.Text;
                usuario = txtControlUsuario.Text;
                destino = txtControl_destino.Text;
                fecha = Convert.ToDateTime(txtControlFecha.Text);
                satisfacion = Convert.ToInt32(txtContolSatisfacion.Text);
                sexo = txtContolSexo.Text;
                discapacidad = txtControlDiscapacidad.Text;
                
                // Valido que introduccca el viaje 
                if (viaje.CompareTo("") != 0)
                {
                    // creo el obje viaje y lo configuro 
                    VIAJES miviaje = new VIAJES();
                    miviaje.IdViaje = viaje;
                    miviaje.Usuario = usuario;
                    miviaje.Destino = destino;
                    miviaje.Fecha = fecha;
                    miviaje.NivelSatisfacion = satisfacion;
                    miviaje.Sexo = sexo;
                    miviaje.Discapacidad= discapacidad;
                   
                    
                    
                    // insertamos el comentario 
                    PROYECTO.VIAJES.InsertOnSubmit(miviaje);
                    PROYECTO.SubmitChanges();
                    cargaGrid();
                    // limpiamos los campos 
                    txtControl_idViaje.Clear();
                    txtControlDiscapacidad.Clear();
                    txtContolSexo.Clear();
                    txtContolSatisfacion.Clear();
                    txtControlFecha.Clear();
                    txtControlUsuario.Clear();
                    txtControl_destino.Clear();


                }


            }
            catch (Exception errorInsert)
            {
                MessageBox.Show("Se ha producido un error :Asegurese de  haber completado los campos correctamente");
                MessageBox.Show(errorInsert.Message);
            }


        }//end btnNuevo_Click

        // seleccion de fila en  el dataGrid
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    txtControl_idViaje.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtControlUsuario.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtControl_destino.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtControlFecha.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    txtContolSatisfacion.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    txtContolSexo.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                    txtControlDiscapacidad.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    
                }
            }
            catch
            {
                // controlamos que no hay seleccion 
            }

        }//dataGridView1_SelectionChanged

        // eleminar comentario 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    // creo el obj 
                    VIAJES miviaje = new VIAJES();
                    miviaje = PROYECTO.VIAJES.Single(p => p.IdViaje.CompareTo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) == 0);
                    PROYECTO.VIAJES.DeleteOnSubmit(miviaje);
                    PROYECTO.SubmitChanges();
                    cargaGrid();
                }

            }
            catch (Exception errorDelete)
            {
                MessageBox.Show(errorDelete.Message);
            }
           
        }//btnEliminar_Click

        // modificar un comentario 
        private void btnModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows != null)
                {
                    // creo el objte 
                    VIAJES miviaje = new VIAJES();

                    miviaje = PROYECTO.VIAJES.Single(p => p.IdViaje == comboBoxContolBuscar.SelectedItem.ToString());
                    miviaje.Usuario = txtControlUsuario.Text;
                    miviaje.Destino = txtControl_destino.Text;
                    miviaje.Fecha = Convert.ToDateTime(txtControlFecha.Text);
                    miviaje.NivelSatisfacion = Convert.ToDecimal(txtContolSatisfacion.Text);
                    miviaje.Sexo = txtContolSexo.Text;
                    miviaje.Discapacidad = txtControlDiscapacidad.Text;
                    PROYECTO.SubmitChanges();
                    cargaGrid();

                    // limpiamos los campos 
                    txtControl_idViaje.Clear();
                    txtControlDiscapacidad.Clear();
                    txtContolSexo.Clear();
                    txtContolSatisfacion.Clear();
                    txtControlFecha.Clear();
                    txtControlUsuario.Clear();
                    txtControl_destino.Clear();


                }

            }
            catch (Exception errorDelete)
            {
                MessageBox.Show(errorDelete.Message);
            }

        }//btnModificar_Click

        // busqueda en  comboBox
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VIAJES miviaje = PROYECTO.VIAJES.Single(p => p.IdViaje == comboBoxContolBuscar.Text);
            txtControl_idViaje.Text = miviaje.IdViaje;
            txtControl_destino.Text = miviaje.Destino;
            txtContolSatisfacion.Text = miviaje.NivelSatisfacion.ToString();
            txtContolSexo.Text = miviaje.Sexo;
            txtControlUsuario.Text = miviaje.Usuario;
            txtControlFecha.Text = miviaje.Fecha.ToString();
            txtControlDiscapacidad.Text = miviaje.Discapacidad;

        }//endbtnBuscar_Click
         // creo los Métodos para cargar el datagrid_los comentarios del los viajeros
        public void cargaGrid2()
        {
            PROYECTO = new DataClasses1DataContext();
            dataGridView2.DataSource = (from p in PROYECTO.CLIENTE
                                        select p);
             cmBDiscapacidad.DataSource = (from p in PROYECTO.CLIENTE
            select p.Discapacidad);
              //var selecion= cmBDiscapacidad.SelectedValue.ToString();
        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // creo la variables 
            string viaje, usuario, discapacidad, destino, descripcion;
            int satisfacion;
            string genero;
            DateTime fechaS, fechaV;
            // creo este método para validar los datos 
            validarCampos();

            try
            {
                viaje = txtNumviaje.Text;
                usuario = txtNombre.Text;
                discapacidad = cmBDiscapacidad.SelectedValue.ToString();
                destino = txtDestino.Text;
                descripcion = txtDescripcion.Text;
                satisfacion = Convert.ToInt32(txtSatisfacion.Text);
                //genero = Convert.ToBoolean(chKhombre.Checked);

                if (rBHombre.Checked == true) genero = "Hombre";
                else genero = "Mujer";
                fechaS = Convert.ToDateTime(dateTimePickerS.Value);
                fechaV = Convert.ToDateTime(dateTimePickerV.Value);

                //validadcion que inserte el nombre de usuario y nº de viaje 
                if (usuario.CompareTo("") != 0)
                {

                    // creamos un comentario y lo configuramos 
                    CLIENTE micomentario = new CLIENTE();
                    micomentario.Viaje = viaje;
                    micomentario.NombreApell = usuario;
                    micomentario.Discapacidad = discapacidad;
                    micomentario.Destino = destino;
                    micomentario.Descripcion = descripcion;
                    micomentario.Satisfacion = satisfacion;
                    micomentario.Sexo = Convert.ToString(genero);
                    micomentario.FechaSalida = fechaS;
                    micomentario.FechaVuelta = fechaV;
                    // Insertamos el comentario   
                    PROYECTO.CLIENTE.InsertOnSubmit(micomentario);
                    PROYECTO.SubmitChanges();
                    cargaGrid2();
                    // limpio los textBoxt



                }


            }
            catch (Exception errorInsert)
            {
                MessageBox.Show("Se ha producido un error :Asegurese de  haber completado los campos correctamente");
                MessageBox.Show(errorInsert.Message);
            }

        }// end btnEnviar_Click

        private bool validarCampos() 
        {
            bool validar = true;
            if (txtNumviaje.Text == "")
            {
                validar = false;
                errorProviderViajeros.SetError(txtNumviaje, "Debe ingresar su nº de viaje ");
                
            }
            if (txtNombre.Text == "")
            {
                validar = false;
                errorProviderViajeros.SetError(txtNombre, "Debe ingresar su nombre y apellidos  ");

            }
            if (txtDestino.Text == "")
            {
                validar = false;
                errorProviderViajeros.SetError(txtDestino, "Debe ingresar el destino de su viaje,   ");

            }
            if (cmBDiscapacidad.SelectedItem.ToString() == "")
            {
                validar = false;
                errorProviderViajeros.SetError(cmBDiscapacidad, "Debe escoger de la selección  ");

            }
            
            if (txtDescripcion.Text == "")
            {
                validar = false;
                errorProviderViajeros.SetError(txtDescripcion, "Tiene que hacer una pequeña descripción d su viaje.max300  ");

            }
            if (txtSatisfacion.Text == "")
            {
                validar = false;
                errorProviderViajeros.SetError(txtSatisfacion, "De 1 al 10, anote su nivel de saltisfación.");

            }
            
            return validar;
        }
    }
}

             
              
             
              
             

               
               