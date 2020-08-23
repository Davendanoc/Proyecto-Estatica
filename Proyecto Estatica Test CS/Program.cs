using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;



namespace Proyecto_Estatica_Test_CS
{

    class Program
    {

        static StreamWriter escribir;
        static StreamReader leer;

        static void Main(string[] args)
        {

            Console.Title = "Armaduras Estatica, Metodo de Nudos";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Usando el programa, la armadura a resolver es la que esta adjunta en el PDF");
            Console.WriteLine();
            Console.WriteLine("A continuacion insertar los valores de las cargas aplicadas");
            Console.WriteLine("a la armadura como se le solicita");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Las unidades a introducir son KN");
            Console.WriteLine("Introducir el valor numerico y despues presione ENTER");
            Console.WriteLine();

            double altura = 0;
            double longitud = 0;

            double Bx, Cx, Dx, Ex, Fx;
            double By, Cy, Dy, Ey, Fy;

            Console.WriteLine("Se introduciran los valores de las magnitudes en sus dos componentes");
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadKey();


            Console.Clear();
            Console.ResetColor();
            //MAGNITUDES EN EL EJE X

            Console.WriteLine("Introducir las Magnitudes en X");

            Console.WriteLine("Digitar la Magnitud de la carga Bx");
            Bx = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Cx");
            Cx = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Dx");
            Dx = double.Parse(Console.ReadLine()); 
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Ex");
            Ex = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Fx");
            Fx = double.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Los valores de las cargas ingresados en KN son de:");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Bx es de: " + Bx + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Cx es de: " + Cx + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Dx es de: " + Dx + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Ex es de: " + Ex + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Fx es de: " + Fx + " KN");
            Console.WriteLine();
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadKey();

            //MAGNITUDES EN EL EJE Y

            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Introducir las Magnitudes en Y");

            Console.WriteLine("Digitar la Magnitud de la carga By");
            By = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Cy");
            Cy = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Dy");
            Dy = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Ey");
            Ey = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digitar la Magnitud de la carga Fy");
            Fy = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Los valores de las cargas ingresados en KN son de:");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("La magnitud de la carga Bx es de: " + By + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Cx es de: " + Cy + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Dx es de: " + Dy + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Ex es de: " + Ey + " KN");
            Console.WriteLine();
            Console.WriteLine("La magnitud de la carga Fx es de: " + Fy + " KN");
            Console.WriteLine();
            Console.WriteLine();

            Console.ResetColor();


            Console.WriteLine("Presione ENTER para continuar");
            Console.ReadKey();

            //MEDIDAS DE LA ARMADURA
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("Ahora procederemos a introducir las medidas de la Armadura");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Por favor introduzca su Altura en Metros");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Por favor introduzca la Longitud en Metros");
            longitud = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Los valores ingresados de sus dimensiones en Metros son:");

            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine();
            Console.WriteLine("Altura de la Armadura: " + altura + " m");
            Console.WriteLine();
            Console.WriteLine("Longitud de la Armadura: " + longitud + " m");
            Console.WriteLine();

            Console.WriteLine("Presionee ENTER para continuar con la solucion numerica.");
            Console.ReadKey();


            Console.Clear();

            Console.ResetColor();

            //FORMULAS DEL PROGRAMA

            //Calculos de Reacciones

            double Gy = (By + 2 * Cy + 3 * Dy + 4 * Ey + +5 * Fy) / (-6);

            double Ay = -By - Cy - Dy - Ey - Fy - Gy;

            double Ax = -Bx - Cx - Dx - Ex - Fx;

            //Calculos de la geometria

            double l = longitud / 6;

            double teta1 = Math.Atan(altura/2*l);

            double alpha1 = Math.Atan(altura/l);

            //Obtencion de Angulos en Grados

            //Teta y Alpha en Grados

            double teta = (teta1 * 180) / Math.PI;
            double alpha = (alpha1 * 180) / Math.PI;

            //Teta en Grados con Seno y Coseno
            double tetacosg = (Math.Cos(teta1)*180)/Math.PI;
            double tetaseng = (Math.Sin(teta1) * 180) / Math.PI;

            //Alpha en Grados con Seno y Coseno
            double alphacosg = (Math.Cos(alpha1) * 180) / Math.PI;
            double alphaseng = (Math.Sin(alpha1) * 180) / Math.PI;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("Calculo de las reacciones en los soportes:");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gy = " + Gy + " KN");
            Console.WriteLine("Ay = " + Ay + " KN");
            Console.WriteLine("Ax = " + Ax + " KN");

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Calculo de los Angulos Internos de la armadura");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(teta + " Grados");
            Console.WriteLine(alpha + " Grados");

            Console.WriteLine();


            //Calculos por Metodo de Nudos

            double Fgh, Ffg, Fhi, Ffh, Ffi, Fef, Fei, Fij, Fej;

            double Fde, Fdj, Fcd, Fcj, Fkj, Fck, Fbc, Fbk, Fkl;

            double Fbl, Fab, Fal;

            //Calculo de Fuerzas

            Fkl = 1;

            Fbl = 1;

            Fgh = -Gy / tetaseng;

            Ffg = -Fgh * tetacosg;

            Fhi = Fgh;

            Ffh = 0 + 0;

            Ffi = -Fy / alphaseng;

            Fef = Fx - Ffi * alphacosg + Ffg;

            Fei = -Ffi * alphaseng - Fhi * tetaseng;

            Fij = Ffi * alphacosg + Fhi * tetacosg;

            Fej = (-Ey - Fei) / alphaseng;

            Fde = Ex - Fej * alphacosg + Fef;

            Fdj = Dy;

            Fcd = Fde + Dx;

            Fcj = (-Fdj - Fej * alphaseng) / alphaseng;

            Fkj = Fij + Fej * alphacosg - Fcj * alphacosg;

            Fck = Cy - Fcj * alphaseng;

            Fbc = Cx + Fcd + Fcj * alphacosg;

            Fbk = (-Fck - Fkl * tetaseng) / alphaseng;

            Fkl = (-Fbl * alphacosg + Fkj) / tetacosg;

            Fbl = (-Fbk * alphaseng - By);

            Fab = Bx + Fbc + Fbk * alphacosg;

            Fal = Fkl;

            Fbl = 0;


            Console.ResetColor();


            Console.WriteLine("Las fuerzas obtenidas son: ");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Elemento GH = " + Fgh + "KN");
            Console.WriteLine("Elemento FG = " + Ffg + "KN");
            Console.WriteLine("Elemento HI = " + Fhi + "KN");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            Console.WriteLine("Elemento FH = " + Ffh + "KN");
            Console.WriteLine("Elemento HI = " + Ffi + "KN");
            Console.WriteLine("Elemento EF = " + Fef + "KN");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            Console.WriteLine("Elemento EI = " + Fei + "KN");
            Console.WriteLine("Elemento IJ = " + Fij + "KN");
            Console.WriteLine("Elemento EJ = " + Fej + "KN");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            Console.WriteLine("Elemento DE = " + Fde + "KN");
            Console.WriteLine("Elemento DJ = " + Fdj + "KN");
            Console.WriteLine("Elemento CD = " + Fcd + "KN");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();

            Console.WriteLine("Elemento CJ = " + Fcj + "KN");
            Console.WriteLine("Elemento KJ = " + Fkj + "KN");
            Console.WriteLine("Elemento CK = " + Fck + "KN");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            Console.WriteLine("Elemento BC = " + Fbc + "KN");
            Console.WriteLine("Elemento BK = " + Fbk + "KN");
            Console.WriteLine("Elemento KL = " + Fkl + "KN");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elemento BL = " + Fbl + "KN");
            Console.WriteLine("Elemento AB = " + Fab + "KN");
            Console.WriteLine("Elemento AL = " + Fal + "KN");

            Console.WriteLine();





            //Console.WriteLine(Math.Acos(0)); // Inverse cosine
            //Console.WriteLine(Math.Cos(2)); // Cosine


            //Console.WriteLine(Math.Asin(0.2)); // Inverse sine
            //Console.WriteLine(Math.Sin(2)); // Sine


            //Console.WriteLine(Math.Atan(-5)); // Inverse tangent
            //Console.WriteLine(Math.Tan(1)); // Tangent

            Console.ReadKey();
        }
    }
}
