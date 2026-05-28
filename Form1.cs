using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figuras
{
    public partial class Form1 : Form
    {
        private Figura[] figuras;

        public Form1()
	{
    		InitializeComponent();
    		Random rnd = new Random();

    		int tamBase = 40;

		figuras = new Figura[5]
		{
		    new Circulo(tamBase * 1,                          GenerarColorConContraste(rnd)),
		    new Rectangulo(tamBase, tamBase * 2,          GenerarColorConContraste(rnd)),
		    new Cuadrado(tamBase * 3,                         GenerarColorConContraste(rnd)),
		    new TrianguloEquilatero(tamBase * 2,              GenerarColorConContraste(rnd)),
		    new TrianguloIsosceles(tamBase * 2, tamBase * 3,  GenerarColorConContraste(rnd)),
		};
}

        private Color GenerarColorConContraste(Random rnd)
        {
            Color color;
            double luminosidad;
            do
            {
                int r = rnd.Next(0, 256);
                int g = rnd.Next(0, 256);
                int b = rnd.Next(0, 256);
                color = Color.FromArgb(r, g, b);
                luminosidad = 0.299 * r + 0.587 * g + 0.114 * b;
            }
            while (luminosidad > 200);

            return color;
        }

        private void button1_Click(object sender, EventArgs e)
	{
	    Graphics gr = pictureBox1.CreateGraphics();
	    Pen pen = new Pen(Color.Black);

	    int offsetX = 10;
	    for (int i = 0; i < figuras.Length; i++)
	    {
		figuras[i].Dibujar(pen, gr, offsetX, 20);
		offsetX += 40 * (i + 2);
    		}
	}
    }
}
