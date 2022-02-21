using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appratica_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese sexo");
            char sexo = char.Parse(Console.ReadLine());
            if (sexo == 'm')
            {
                Console.WriteLine("masculino");
            }
            else if (sexo == 'f')
            {
                Console.WriteLine("femenino");
            }
            else
            {
                Console.WriteLine("error!!");
            }
            Console.WriteLine("ingrese sexo");
            char Sexo = char.Parse(Console.ReadLine());
            switch (Sexo)
            {
                case 'm':
                    Console.WriteLine("masculino");
                    break;
                case 'f':
                    Console.WriteLine("femenino");
                    break;
                default:
                    Console.WriteLine("error!!");
                    break;
            }
            Console.WriteLine("ingrese 1-7");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("lunes");
                    break;
                case 2:
                    Console.WriteLine("martes");
                    break;
                case 3:
                    Console.WriteLine("miercoles");
                    break;
                case 4:
                    Console.WriteLine("jueves");
                    break;
                case 5:
                    Console.WriteLine("viernes");
                    break;
                case 6:
                    Console.WriteLine("sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("error!!");
                    break;
            }
            string curso1 = null, curso2 = null, curso3 = null;
            string prof1 = null, prof2 = null, prof3;
            Console.WriteLine("ingrese numero");
            string dia = Console.ReadLine();
            switch (dia)
            {
                case "lunes":
                    curso1 = "matematicas";
                    prof1 = "Gladiz";
                    curso2 = "lenguaje";
                    prof2 = "marilu";
                    break;
                case "martes":
                    curso1 = "ADS";
                    prof1 = "rodolfo";
                    curso2 = "modelodo";
                    prof2 = "perci";
                    curso3 = "base de datos ";
                    prof3 = "darwin ";
                    break;
                    Console.Write("prof1: " + prof1 + "curso 1: " + curso1);
                    Console.Write("prof2: " + prof2 + "curso 2: " + curso2);
                    Console.Write("prof3: " + prof3 + "curso 3: " + curso3);
                default:
                    break;
            }
            Console.WriteLine("ingrese mes de nacimento ");
            string mes = Console.ReadLine();
            Console.WriteLine("ingrese mes dia de nacimeinto");
            int dias = int.Parse(Console.ReadLine());
            switch (mes)
            {
                case "marzo":

                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("PISCIS");
                    else if (dias >= 21 && dias <= 31)

                        Console.WriteLine("ARIES");

                    break;
                case "abril":

                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("ARIES");
                    else if (dias >= 21 && dias <= 30)
                        Console.WriteLine("TAURO");
                    break;
                case "mayo":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("TAURO");
                    else if (dias >= 21 && dias <= 31)
                        Console.WriteLine("GEMNIS");
                    break:
                case "junio":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("GEMNIS");
                    else if (dias >= 22 && dias <= 30)
                        Console.WriteLine("CANCER");
                    break;
                case "julio":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("CANCER");
                    else if (dias >= 23 && dias <= 30)
                        Console.WriteLine("LEO");
                    break;
                case "agosto":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("leo");
                    else if (dias >= 23 && dias <= 31)
                        Console.WriteLine("virgo");
                    break;
                case "setiembre":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("vrigo");
                    else if (dias >= 23 && dias <= 30)
                        Console.WriteLine("libra");
                    break;
                case "octubre":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("libra");
                    else if (dias >= 23 && dias <= 31)
                        Console.WriteLine("escorpio");
                    break;
                case "noviembre":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("escorpio");
                    else if (dias >= 23 && dias <= 30)
                        Console.WriteLine("sagitario");
                    break;
                case "diciembre":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("sagitario");
                    else if (dias >= 23 && dias <= 31)
                        Console.WriteLine("capricornio");
                    break;
                case "enero":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("Capricornio");
                    else if (dias >= 23 && dias <= 31)
                        Console.WriteLine("acuario");
                    break;
                case "febrero":
                    if (dias >= 1 && dias <= 20)
                        Console.WriteLine("acurio");
                    else if (dias >= 23 && dias <= 28)
                        Console.WriteLine("pisis");
                    break;
                default:
                    Console.WriteLine("error");
                    break;

            }
            Console.Read();
        }
    }
}
