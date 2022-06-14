using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using BE;

namespace UI
{
    public class BD
    {
        public List<BECombinacion> Listar_Datos()
        {
            var consulta = from Combinacion in XElement.Load("C:\\Archivo_XML\\Combinaciones.xml").Elements("Combinacion")
                           select new BECombinacion
                           {
                               Estado = Combinacion.Element("Estado").Value.ToString(),
                               SubEstado = Convert.ToInt32(Combinacion.Element("SubEstado").Value),
                               TipoCarga = Combinacion.Element("TipoCarga").Value.ToString()
                           };

            List<BECombinacion> Lista_Combinaciones = consulta.ToList<BECombinacion>();
            return Lista_Combinaciones;
        }
        
        public BECombinacion Seleccionar(string estado)
        {
            XDocument xmlDoc = XDocument.Load("C:\\Archivo_XML\\Combinaciones.xml");

            XElement Combinacion = xmlDoc.Descendants("Combinacion").FirstOrDefault(x => x.Element("Estado").Value == estado);

            BECombinacion oCombinacion = new BECombinacion();

            if(Combinacion != null)
            {
                oCombinacion.Estado = Combinacion.Element("Estado").Value;
                oCombinacion.SubEstado = Convert.ToInt32(Combinacion.Element("SubEstado").Value);
                oCombinacion.TipoCarga = Combinacion.Element("TipoCarga").Value;
            }
            else { oCombinacion = null; }

            return oCombinacion;
        }

        public void Establecer_Todo_Desactivado()
        {
            XDocument xmlDoc = XDocument.Load("C:\\Archivo_XML\\Combinaciones.xml");
            List<XElement> Combinacion = xmlDoc.Descendants("Combinacion").ToList();

            foreach(XElement element in Combinacion)
            {
                element.Element("Estado").Value = "0";
                xmlDoc.Save("C:\\Archivo_XML\\Combinaciones.xml");
            }
        }
    
        public void Modificar(BECombinacion oBECombinacion)
        {
            XDocument xmlDoc = XDocument.Load("C:\\Archivo_XML\\Combinaciones.xml");
            XElement Combinacion = xmlDoc.Descendants("Combinacion").FirstOrDefault(x => x.Element("Estado").Value == oBECombinacion.Estado);
            if (Combinacion != null)
            {
                Combinacion.Element("SubEstado").Value = oBECombinacion.SubEstado.ToString();
                Combinacion.Element("TipoCarga").Value = oBECombinacion.TipoCarga.ToString();
                xmlDoc.Save("C:\\Archivo_XML\\Combinaciones.xml");
            }
        }
    
    }
}
