using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace UI
{
    public partial class frmPrincipal : Form
    {

        #region Campos

        BECombinacion oBECombinacion;

        BECombinacion combinacion1;
        BECombinacion combinacion2;
        BECombinacion combinacion3;
        BECombinacion combinacion4;
        BECombinacion combinacion5;

        #endregion

        #region Propiedades

        public string Combo1 { get; set; }

        public string Combo2 { get; set; }

        public string Combo3 { get; set; }

        public string Combo4 { get; set; }


        public int Cantidad1 { get; set; }

        public int Cantidad2 { get; set; }

        public int Cantidad3 { get; set; }

        public int Cantidad4 { get; set; }

        public int Cantidad_Combinaciones { get; set; }

        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Funciones privadas

        private void Mostrar_Datos()
        {
            BD bd = new BD();
            List<BECombinacion> lista = new List<BECombinacion>();
            lista = bd.Listar_Datos();

            listBox2.Items.Clear();

            if (lista != null)
            {
                foreach (BECombinacion combinacion in lista)
                {
                    listBox2.Items.Add(combinacion.Estado + " - " + combinacion.SubEstado + " - " + combinacion.TipoCarga);
                }
            }
        }

        private bool Validar_D()
        {
            if(cboTipoCarga.Text == "No variable" && txtCantidadVariables.Text == "1")
            {
                return true;
            }
            else { return false; }
        }

        private void Limpiar_Combos()
        {
            cbo1.Items.Clear();
            cbo2.Items.Clear();
            cbo3.Items.Clear();
            cbo4.Items.Clear();
            cbo5.Items.Clear();
        }

        private void Cargar_Combos()
        {
            try
            {
                List<BECombinacion> lista = new List<BECombinacion>();
                BD bd = new BD();
                lista = bd.Listar_Datos();

                Limpiar_Combos();

                //Cargar_combos

                cbo1.Items.Add("Elegir");
                cbo2.Items.Add("Elegir");
                cbo3.Items.Add("Elegir");
                cbo4.Items.Add("Elegir");
                cbo5.Items.Add("Elegir");

                foreach (BECombinacion combinacion in lista)
                {
                    cbo1.Items.Add(combinacion.Estado);
                    cbo2.Items.Add(combinacion.Estado);
                    cbo3.Items.Add(combinacion.Estado);
                    cbo4.Items.Add(combinacion.Estado);
                    cbo5.Items.Add(combinacion.Estado);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Creacion_Combinaciones()
        {
            try
            {
                BD bd = new BD();
                string combinacion_inicial = "";
                List<string> combinaciones = new List<string>();
                int cantidad_estados = 0;
                string combinacion = "";
               
                if(cbo1.Text != "Elegir")
                { 
                    combinacion1 = (BECombinacion)bd.Seleccionar(cbo1.Text);
                    combinacion_inicial = txt1.Text + cbo1.Text;
                    cantidad_estados++;

                    if (cbo2.Text != "Elegir")
                    { 
                        combinacion2 = (BECombinacion)bd.Seleccionar(cbo2.Text);
                        combinacion_inicial = combinacion_inicial + " + " + txt2.Text + cbo2.Text;
                        cantidad_estados++;

                        if (cbo3.Text != "Elegir")
                        { 
                            combinacion3 = (BECombinacion)bd.Seleccionar(cbo3.Text);
                            combinacion_inicial = combinacion_inicial + " + " + txt3.Text + cbo3.Text;
                            cantidad_estados++;

                            if (cbo4.Text != "Elegir")
                            { 
                                combinacion4 = (BECombinacion)bd.Seleccionar(cbo4.Text);
                                combinacion_inicial = combinacion_inicial + " + " + txt4.Text + cbo4.Text;
                                cantidad_estados++;

                                if (cbo5.Text != "Elegir")
                                { 
                                    combinacion5 = (BECombinacion)bd.Seleccionar(cbo5.Text);
                                    combinacion_inicial = combinacion_inicial + " + " + txt5.Text + cbo5.Text;
                                    cantidad_estados++;
                                }
                            }
                        }
                    }
                }

                combinacion = txt1.Text + combinacion1.Estado;
                combinacion_inicial = combinacion;
                int flag_2 = 0;
                
                for(int c2 = 1; c2 < combinacion2.SubEstado + 1; c2++)
                {
                    int flag_3 = 0;
                    string combi2 = combinacion;

                    if(flag_2 == 0 && combinacion2.TipoCarga == "Variable")
                    {
                        combi2 = combi2 + " + " + combinacion2.Estado + " x 0 ";
                        flag_2 = 1;
                        c2--;
                    }
                    else
                    {
                        combi2 = combi2 + " + " + txt2.Text + combinacion2.Estado + c2;
                    }

                    if(cantidad_estados >= 3)
                    {
                        for(int c3 = 1; c3 < combinacion3.SubEstado + 1; c3++)
                        {
                            int flag_4 = 0;
                            string combi3 = combi2;

                            if(flag_3 == 0 && combinacion3.TipoCarga == "Variable")
                            {
                                combi3 = combi3 + " + " + combinacion3.Estado + " x 0 ";
                                flag_3 = 1;
                                c3--;
                            }
                            else
                            {
                                combi3 = combi3 + " + " + txt3.Text + combinacion3.Estado + c3;
                            }

                            if(cantidad_estados >= 4)
                            {
                                for(int c4 = 1; c4 < combinacion4.SubEstado + 1; c4++)
                                {
                                    int flag_5 = 0;
                                    string combi4 = combi3;

                                    if(flag_4 == 0 && combinacion4.TipoCarga == "Variable")
                                    {
                                        combi4 = combi4 + " + " + combinacion4.Estado + " x 0 ";
                                        flag_4 = 1;
                                        c4--;
                                    }
                                    else
                                    {
                                        combi4 = combi4 + " + " + txt4.Text + combinacion4.Estado + c4;
                                    }

                                    if(cantidad_estados == 5)
                                    {
                                        for(int c5 = 1; c5 < combinacion5.SubEstado + 1; c5++)
                                        {
                                            string combi5 = combi4;

                                            if(flag_5 == 0 && combinacion5.TipoCarga == "Variable")
                                            {
                                                combi5 = combi5 + " + " + combinacion5.Estado + " x 0 ";
                                                flag_5 = 1;
                                                c5--;
                                            }
                                            else
                                            {
                                                combi5 = combi5 + " + " + txt5.Text + combinacion5.Estado + c5;
                                            }

                                            combinaciones.Add(combinaciones.Count + 1 + "- " + combi5);
                                        }
                                            
                                    }
                                    else
                                    {
                                        combinaciones.Add(combinaciones.Count + 1 + "- " + combi4);
                                    }
                                }
                            }
                            else
                            {
                                combinaciones.Add(combinaciones.Count + 1 + "- " + combi3);
                            }
                        }
                    }
                    else
                    {
                        combinaciones.Add(combinaciones.Count + 1 + "- " + combi2);
                    }
                }


                foreach(string combi in combinaciones)
                {
                    listBox1.Items.Add(combi);
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private void Completar_Datos()
        {
            try
            {
                List<BECombinacion> lista = new List<BECombinacion>();
                BD bD = new BD();
                lista = bD.Listar_Datos();

                int i = 1;

                foreach(BECombinacion combinacion in lista)
                {
                    switch(i)
                    {
                        case 1:
                            Combo1 = combinacion.Estado;
                            Cantidad1 = combinacion.SubEstado;
                            break;
                        
                        case 2:
                            Combo2 = combinacion.Estado;
                            Cantidad2 = combinacion.SubEstado;
                            break;
                        
                        case 3:
                            Combo3 = combinacion.Estado;
                            Cantidad3 = combinacion.SubEstado;
                            break;

                        case 4:
                            Combo4 = combinacion.Estado;
                            Cantidad4 = combinacion.SubEstado;
                            break;
                    }

                    i++;
                }
            }
            catch (Exception ex) { throw ex; }
        }

        private bool Validar_Combos_Completos()
        {
            if(cbo1.Text != "Elegir" && cbo2.Text != "Elegir")
            { return true; }
            else { return false; }
        }

        private void Contar_Combinaciones()
        {
            Cantidad_Combinaciones = listBox1.Items.Count;
            lblCantidadCombinaciones.Text = Cantidad_Combinaciones.ToString();
        }

        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Cantidad_Combinaciones = 0;
                BD bd = new BD();
                Cargar_Combos();
                Mostrar_Datos();
                //bd.Establecer_Todo_Desactivado();
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboLetra.Text == "D")
                {
                    if(Validar_D() == true)
                    {

                        oBECombinacion = new BECombinacion();
                        oBECombinacion.Estado = cboLetra.Text;
                        oBECombinacion.SubEstado = Convert.ToInt32(txtCantidadVariables.Text);
                        if (cboTipoCarga.Text == "Variable")
                        {
                            oBECombinacion.TipoCarga = "Variable";
                        }
                        else
                        {
                            oBECombinacion.Estado = "No variable";
                        }

                        BD bd = new BD();

                        bd.Modificar(oBECombinacion);
                        Mostrar_Datos();
                        Cargar_Combos();
                    }
                    else { MessageBox.Show("Los datos ingresados no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    if(Convert.ToInt32(txtCantidadVariables.Text) > 0)
                    {
                        oBECombinacion = new BECombinacion();
                        oBECombinacion.Estado = cboLetra.Text;
                        oBECombinacion.SubEstado = Convert.ToInt32(txtCantidadVariables.Text);
                        if (cboTipoCarga.Text == "Variable")
                        {
                            oBECombinacion.TipoCarga = "Variable";
                        }
                        else
                        {
                            oBECombinacion.TipoCarga = "No variable";
                        }

                        BD bd = new BD();

                        bd.Modificar(oBECombinacion);
                        Mostrar_Datos();
                        Cargar_Combos();
                        
                    }
                    else { MessageBox.Show("Tipo de carga debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    
                    cboLetra.Text = "Seleccionar";
                    cboLetra.Focus();
                    txtCantidadVariables.Text = "1";
                    cboTipoCarga.Text = "Seleccionar";
                }

            }
            catch (Exception ex) { throw ex; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(Validar_Combos_Completos() == true)
                {
                    string combinacion = "";

                    combinacion = combinacion + txt1.Text + cbo1.Text;

                    if (cbo2.Text != "Elegir")
                    {
                        combinacion = combinacion + " - " + txt2.Text + cbo2.Text;

                        if (cbo3.Text != "Elegir")
                        {
                            combinacion = combinacion + " - " + txt3.Text + cbo3.Text;
                        }

                        if (cbo4.Text != "Elegir")
                        {
                            combinacion = combinacion + " - " + txt4.Text + cbo4.Text;
                        }

                        if (cbo5.Text != "Elegir")
                        { combinacion = combinacion + " - " + txt5.Text + cbo5.Text; }
                    }

                    lblCombinacionPrincipal.Text = combinacion;
                    Completar_Datos();
                    //Crear_Combinaciones();
                    Creacion_Combinaciones();
                    Contar_Combinaciones();
                }
                else { MessageBox.Show("Debe completar dos estados minimamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                lblCombinacionPrincipal.Text = "";
                cbo1.Text = "Elegir";
                cbo2.Text = "Elegir";
                cbo3.Text = "Elegir";
                cbo4.Text = "Elegir";
                cbo5.Text = "Elegir";
                txt1.Text = "";
                txt2.Text = "";
                txt3.Text = "";
                txt4.Text = "";
                txt5.Text = "";
                Cantidad_Combinaciones = 0;
            }
            catch (Exception ex) { throw ex; }
        }

        private void btnExportarTXT_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter file = new StreamWriter("C:\\Archivo_XML\\Resultado.txt", false);
                foreach(var text in listBox1.Items)
                {
                    string texto = text.ToString();
                    file.WriteLine(texto);
                }

                file.Close();
                file.Dispose();

                MessageBox.Show("Exportado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { throw ex; }
        }

    }
}
