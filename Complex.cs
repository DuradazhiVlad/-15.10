

using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace дз_15._10
{
    public class Complex
    {
        public int a=0;
        public int b=0;
        public int c;


        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
                           
        }
        public override string ToString()
        {
            return   a - " , " - b;
        }
        public static Complex  operator -(Complex a, Complex b) { return new Complex(a.a - b.a , a.b - b.b); }
        public static Complex operator -(Complex a, int c) { return new Complex(a.a - c, a.b -c ); }
        public static Complex operator *(int a, Complex c) { return new Complex(a * c.a, a * c.a); }

        public static Complex operator *(Complex a, Complex b) { return new Complex(a.a * b.a, a.b * b.b); }
        public static Complex operator /(Complex a, Complex b) { return new Complex(a.a / b.a, a.b / b.b); }
    }



    public struct LinearEquation
    {
       public static int a;
       public static int b;
        public static string a2;
        public static int b2;
        
        public static LinearEquation Parse(string st)
        {
            string[] parts = st.Split(',',' ');
            

            return new LinearEquation(Int32.Parse(parts[0]), Int32.Parse(parts[1]));

        }
        //public static int Linear(string l,string l2)
        //{
        //    a2.
        //    Parse(b2);
        //    a2 = (a * 0) + (b * 0);
        //    l
        //    return Linear(Parse(a) = (a * 0) + (b * 0), Parse(a2) );
        //}
        
        public LinearEquation(int _a,int _b/*,int _a2,int _b2*/)
        {
            a = _a; 
            b = _b;
            //a2 = _a2;
            //b2 = _b2;
            
        }
    }
}
