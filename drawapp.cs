using System;
using System.Collections.Generic;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }
    }

    /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    
    class Brush : Draw
    {
        //StartDraw() method implementation
        public override void StartDraw()
        {
            Console.WriteLine("Using brush");
        }
    }

    //Draw class inheritance
    class Spray : Draw
    {
        //StartDraw() method implementation
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }
    }
}
