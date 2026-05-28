using System;
using System.Drawing;

namespace Figuras
{
    public class Figura
    {
        public Color ColorFigura { get; set; }

        public virtual void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {
        }
    }

    public class Rectangulo : Figura
    {
        protected int alto;
        protected int ancho;

        public Rectangulo(int ancho, int alto, Color color)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.ColorFigura = color;
        }

        public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {
            pen.Color = this.ColorFigura;
            Point[] points = new Point[4]
            {
                new Point(x, y),
                new Point(x + ancho, y),
                new Point(x + ancho, y + alto),
                new Point(x, y + alto)
            };
            graphics.DrawPolygon(pen, points);
        }
    }

    public class Cuadrado : Rectangulo
    {
        public Cuadrado(int lado, Color color) : base(lado, lado, color)
        {
        }
    }

    public class Circulo : Figura
    {
        private int radio;

        public Circulo(int radio, Color color)
        {
            this.radio = radio;
            this.ColorFigura = color;
        }

        public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
        {
            pen.Color = this.ColorFigura;
            graphics.DrawEllipse(pen, x, y, radio, radio);
        }
    }
}
