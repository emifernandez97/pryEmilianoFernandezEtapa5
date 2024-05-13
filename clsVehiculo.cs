using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEmilianoFernandezEtapa2
{
    internal class clsVehiculo
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Image Imagen { get; set; }

        //Constructor
        /*public clsVehiculo(string nombre, string tipo, Image imagen)
        {
            Nombre = nombre;
            Tipo = tipo;
            Imagen = imagen;
        }*/

        //Metodos

        public void crearVehiculo(PictureBox Vehiculo) //pct del formulario
        {
            PictureBox ImagenVehiculo = new PictureBox(); //instancio en memora imagen

            Random rnd = new Random(); //creo random

            // Generar una posición aleatoria dentro del PictureBox contenedor
            int posX = rnd.Next(0, Vehiculo.Width - 50);
            int posY = rnd.Next(0, Vehiculo.Height - 100);

            switch (rnd.Next(1,4))  //para cada caso un random
            {
                case 1:
                    Imagen = pryEmilianoFernandezEtapa5.Properties.Resources.Rayo_Mckuin;
                    break;
                case 2:
                    Imagen = pryEmilianoFernandezEtapa5.Properties.Resources.CAPTAIN_removebg_preview;
                    break;
                case 3:
                    Imagen = pryEmilianoFernandezEtapa5.Properties.Resources.jay_jay_removebg_preview;
                    break;
            }

            ImagenVehiculo.Image = Imagen;
            ImagenVehiculo.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagenVehiculo.Location = new Point (posX,posY);
            ImagenVehiculo.Size = new Size(100 , 100);
            ImagenVehiculo.BackColor = Color.White;
            Vehiculo.Controls.Add(ImagenVehiculo);

            ImagenVehiculo.BringToFront();          
        }
    }
}
