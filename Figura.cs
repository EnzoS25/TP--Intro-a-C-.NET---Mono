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
    
    public class TrianguloEquilatero : Figura
{
    protected int lado;

    public TrianguloEquilatero(int lado, Color color)
    {
        this.lado = lado;
        this.ColorFigura = color;
    }

    public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
    {
        pen.Color = this.ColorFigura;

        int h = (int)(lado * Math.Sqrt(3) / 2);

        Point[] points = new Point[3]
        {
            new Point(x + lado / 2, y),      // vértice superior
            new Point(x + lado,     y + h),  // vértice inferior derecho
            new Point(x,            y + h),  // vértice inferior izquierdo
        };

        graphics.DrawPolygon(pen, points);
    }
}

	public class TrianguloIsosceles : Figura
	{
	    protected int base_;
	    protected int altura;

	    public TrianguloIsosceles(int base_, int altura, Color color)
	    {
		this.base_ = base_;
		this.altura = altura;
		this.ColorFigura = color;
	    }

	    public override void Dibujar(Pen pen, Graphics graphics, int x, int y)
	    {
		pen.Color = this.ColorFigura;

		Point[] points = new Point[3]
		{
		    new Point(x + base_ / 2, y),           // vértice superior
		    new Point(x + base_,     y + altura),  // vértice inferior derecho
		    new Point(x,             y + altura),  // vértice inferior izquierdo
		};

		graphics.DrawPolygon(pen, points);
	    }
	}
    
}
