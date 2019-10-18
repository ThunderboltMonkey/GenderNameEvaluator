using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Evaluación de Nombres";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-----------------------INTRODUCCION-----------------------");
            Console.WriteLine("");
            Console.WriteLine("El siguiente programa tomará un nombre introducido por \nteclado y evaluara si el nombre es femenino o masculino");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-----------------------INSTRUCCIONES-----------------------");
            Console.WriteLine("");
            Console.WriteLine("1) Introducir nombre en minusculas");
            Console.WriteLine("2) Introducir nombre sin acentos");
            Console.WriteLine("3) Introducir un nombre a la vez");
            Console.WriteLine("4) Para salir del programa escribir la palabra salir");
            Console.WriteLine("");
            Console.WriteLine("");

            string cadena = null;
            string evalua = null;
            Regex noPermitidos = new Regex(@"[0-9\\\-\.\,\;\:\{\[\´\¨\+\*\}\]\¿\¡\'\?\=\)\(\/\&\%\$\#\|\!\°\¬\~\^\\_\>\<\`\@\|]");
            string otra = null;

            Console.WriteLine("¿Desea ingresar un nombre? 0 = Si, 1 = No");
            otra = Console.ReadLine();

            if(otra == "0")
            {
                while (otra != "1")
                {
                    try
                    {
                        Console.WriteLine("Ingresa un nombre y se determinará si es nombre de hombre o mujer: ");
                        cadena = Console.ReadLine();
                        cadena = cadena.ToLowerInvariant();
                        cadena = cadena.Replace(" ", "");
                        cadena = cadena.Replace("á", "a");
                        cadena = cadena.Replace("é", "e");
                        cadena = cadena.Replace("í", "i");
                        cadena = cadena.Replace("ó", "o");
                        cadena = cadena.Replace("ú", "u");
                        cadena = cadena.Replace("à", "a");
                        cadena = cadena.Replace("è", "e");
                        cadena = cadena.Replace("ì", "i");
                        cadena = cadena.Replace("ò", "o");
                        cadena = cadena.Replace("ù", "u");
                        
                        if (cadena == "Salir")
                        {
                            Console.WriteLine("Saliendo del programa... (Presione una tecla para continuar)");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else if (noPermitidos.IsMatch(cadena))
                        {
                            Console.WriteLine("Solo se aceptan letras");
                        }
                        else if (cadena.Length >= 14)
                        {
                            Console.WriteLine("Ingrese un nombre de longitud valida");
                        }
                        else if (cadena.Length == 1)
                        {
                            Console.WriteLine("Ingrese un nombre de longitud valida");
                        }
                        else if (cadena.Length == 2)
                        {
                            Console.WriteLine("Ingrese un nombre de longitud valida");
                        }
                        else if (cadena == "SALIR")
                        {
                            Console.WriteLine("Saliendo del programa... (Presione una tecla para continuar)");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else if (cadena == "salir")
                        {
                            Console.WriteLine("Saliendo del programa... (Presione una tecla para continuar)");
                            Console.ReadKey();
                            Environment.Exit(0);
                        }
                        else if (cadena == "ivan")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "")
                        {
                            Console.WriteLine("Introduzca un nombre por favor");
                        }
                        else if (cadena == "mario")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "fabian")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "emanuel")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "raul")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "isauro")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "eva")
                        {
                            Console.WriteLine("Es mujer");
                        }
                        else if (cadena == "ana")
                        {
                            Console.WriteLine("Es mujer");
                        }
                        else if (cadena == "ema")
                        {
                            Console.WriteLine("Es mujer");
                        }
                        else if (cadena == "ian")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "noe")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "ray")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "rey")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "leo")
                        {
                            Console.WriteLine("Es hombre");
                        }
                        else if (cadena == "etc")
                        {
                            Console.WriteLine("Introduzca un nombre por favor");
                        }
                        else
                        {
                            evalua = cadena.Substring(cadena.Length - 4, 4);
                            if (evalua.Length == 4)
                            {
                            switch (evalua)
                            {
                                case "acas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dgar":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "omeo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "milo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "sael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "anco":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "miro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "sefo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "undo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "vico":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "uben":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "acio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "filo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "aldo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "runo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "fren":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "mero":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "niel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ateo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lugo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ucas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rilo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rwin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dwin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "hugo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "arin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "alon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lino":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "bner":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dras":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rain":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lvin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ordi":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ordy":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ecas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ocas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "icas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "amin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "spar":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dson":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "erto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rgio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "leno":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "meno":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rnan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rlan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "aias":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "sias":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "tias":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "esus":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "vani":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "figo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rigo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "anni":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "anny":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "vany":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ntin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "afin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "fino":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "tino":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "edro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "oteo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "bian":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "mian":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "maro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "naro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "muel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nuel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "guel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "avid":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "iego":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "vier":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rcos":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "anio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "onio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ermo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "chor":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "malo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "cido":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "erio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ving":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "orge":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "iver":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rick":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "eric":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "iker":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "stor":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "gael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "uiel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "riel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ziel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ardo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "aron":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ises":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "mses":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "raul":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "aham":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "adan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "bran":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ulfo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "olfo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "oldo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "evin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ndon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "jose":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "luis":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "exis":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "redo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "osio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dres":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ores":
                                    Console.WriteLine("Es mujer");
                                    break;
                                case "onso":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "onzo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ando":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "emoc":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "doro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "son":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "liel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ablo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rlos":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rtin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "saul":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ique":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "bino":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "tian":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "stan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "icio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ucio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "esar":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "aian":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ryan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rian":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ayan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lome":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "elio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "leto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ctor":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "zalo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "idel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "azar":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "varo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "omar":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ndro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "stin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rman":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "joel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lipe":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "elmo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ador":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ncio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "amon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "vino":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "paul":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "scal":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "cual":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "aulo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "chel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "scar":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "olas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "enzo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lian":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "mado":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "quin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "tavo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "mael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "usto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "juan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "enio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rmin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "avio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "abio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "irio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rene":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ciel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "arco":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "auro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "alan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "fael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "yael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "jael":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "alex":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "yvan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ivan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lias":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ileo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nico":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "iano":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "idro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lton":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lson":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "colm":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lcom":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "than":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "osue":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "into":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ildo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "esto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ente":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ahir":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nimo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lain":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "isco":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "elos":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lvio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "oman":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "leon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ntos":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "stre":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "olan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "imon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "tiuh":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "omas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ilio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "erdo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "pito":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "adir":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rico":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ebio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "olio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "iago":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "turo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ngel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lupe":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ndio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ibio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "isio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dino":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "adeo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ibal":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "obal":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "isto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "asio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "axel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ista":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "icto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nabe":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "elso":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "elto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "udio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "emon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nato":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ston":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rson":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "maso":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nilo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "trio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ario":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "imas":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "eloy":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "clio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "inio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ecio":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "cobo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "airo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ohan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ixto":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "taro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "zaro":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ximo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "igor":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "smar":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "aolo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "endo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "fano":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "bias":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "vito":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "slao":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "rias":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dhir":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "said":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "tzin":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "tzal":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "noch":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ilco":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "huel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "htli":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "zuma":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "asmo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "eban":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "dair":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "arlo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ingo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "shue":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "onel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "saac":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "nito":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "meon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "zaid":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "siel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "polo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "ayam":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "abel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "avel":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "cain":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "imir":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "omon":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lmer":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "lver":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "eber":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "gelo":
                                    Console.WriteLine("Es hombre");
                                    break;
                                case "joan":
                                    Console.WriteLine("Es hombre");
                                    break;
                                default:
                                    Console.WriteLine("Es mujer");
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: {0} ", ex);
                    }
                }
            }
            else if(otra == "1")
            {
                Console.WriteLine("Saliendo del programa");
            }
            else
            {
                Console.WriteLine("Error... saliendo del programa");
            }
            Console.ReadKey();
          }
        }
    }