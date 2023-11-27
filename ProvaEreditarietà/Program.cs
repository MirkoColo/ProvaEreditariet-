using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaEreditarietà
{
    class Quadrato
    {
        protected double _lato { get; set; }
        public Quadrato(double _lato)
        {
            this._lato = _lato;
        }

        public void CalcoloArea()
        {
            double area = _lato * _lato;
            Console.WriteLine("L'area del quadrato è " + area);
        }
        public void CalcoloPerimetro()
        {
            double p = _lato * 4;
            Console.WriteLine("Il perimetro del quadrato è " + p);
        }
    }
    class Cubo : Quadrato
    {
        public Cubo(double _lato) : base(_lato) 
        {

        }
        public void CalcoloAreaCubo()
        {
            double a = _lato * _lato * 6;
            Console.WriteLine("L'area del cubo è " + a);
        }
        public void CalcoloVolumeCubo()
        {
            double vol = _lato * _lato * _lato;
            Console.WriteLine("Il volume del cubo è " + vol);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Quadrato q = new Quadrato(10);
            q.CalcoloArea();
            q.CalcoloPerimetro();
            Cubo c = new Cubo(10);
            c.CalcoloAreaCubo();
            c.CalcoloVolumeCubo();
        }
    }
}
