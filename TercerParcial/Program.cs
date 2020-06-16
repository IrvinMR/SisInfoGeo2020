using System;

namespace TercerParcial{
    class Program{
        static void Main(string[] args){
            double x,y;
            if(args.Length < 1) Menu();
            else{
                Console.ForegroundColor = ConsoleColor.Blue;
                switch(int.Parse(args[0])){
                    case 1: SoloLect(); break;
                    case 2: ExpSwitch(); break;
                    case 3: PatProp(); break;
                    case 4: PatTupla(); break;
                    case 5: PatPosi(); break;
                    case 6: DecUsin(); break;
                    case 7: FunLocEst(); break;
                    case 8: IndicRang(); break;
                    default: Console.WriteLine("Opcion invalida..."); break;
                }
            }
        }

        static void Menu(){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("......Características nuevas en C#8 ......\n");
            Console.WriteLine("......[ 1 ] Miembros de solo lectura .....");
            Console.WriteLine("......[ 2 ] Expresiones switch............");
            Console.WriteLine("......[ 3 ] Patrones de propiedades ......");
            Console.WriteLine("......[ 4 ] Patrones de tupla ............");
            Console.WriteLine("......[ 5 ] Patrones posicionales ........");
            Console.WriteLine("......[ 6 ] Declaraciones Using ..........");
            Console.WriteLine("......[ 7 ] Funciones locales estáticas ..");
            Console.WriteLine("......[ 8 ] Indices y rangos .............\n");
        }

        static void SoloLect(){
            float b, a;
            Console.WriteLine("Dame un numero");
	        b=float.Parse(Console.ReadLine());

	        Console.WriteLine("Dame otro numero");
	        a=float.Parse(Console.ReadLine());

             Point();
        }

        static void ExpSwitch(){
            string col;
            Console.WriteLine("Ingrese un color en ingles");
            col=string.Parse(Console.ReadLine());
            public static RGBColor FromRainbow(Rainbow col) =>
            col switch{
                Rainbow.Red    => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                Rainbow.Green  => new RGBColor(0x00, 0xFF, 0x00),
                Rainbow.Blue   => new RGBColor(0x00, 0x00, 0xFF),
                Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _              => throw new ArgumentException(message: "valor no valido", paramName: nameof(colorBand)),
           };
        }

         public enum Rainbow{
                Red,
                Orange,
                Yellow,
                Green,
                Blue,
                Indigo,
                Violet
            }

        static void PatProp(){
            int precio=75;
            
            Console.WriteLine($"El precio en la zona centro es de ={precio * 1.08}");
            Console.WriteLine($"El precio en la zona norte es de ={precio * 1.05}");
            Console.WriteLine($"El precio en la zona sur es de ={precio * 1.03}");

        }
        static void PatTupla(){
            string first, second;
            Console.WriteLine("Seleccione uno y escribalo, -piedra- -papel* o *tijeras*");

            Console.WriteLine("Escribe el primero");
	        first=string.Parse(Console.ReadLine());

	        Console.WriteLine("escribe el segundo");
	        second=string.Parse(Console.ReadLine());

            public static string RockPaperScissors(string first, string second)
            => (first, second) switch{
                ("piedra", "papel") => "piedra es cubierta por papel. gana papel.",
                ("piedra", "tijeras") => "piedra quebra tijeras. gana piedra",
                ("papel", "piedra") => "piedra es cubierta por papel. gana papel",
                ("papel", "tijeras") => "tijeras corta papel. gana tijeras",
                ("tijeras", "piedra") => "piedra quebra tijeras. gana piedra.",
                ("tijeras", "papel") => "tijeras corta papel. gana tijeras",
                (_, _) => "empate"
            };
        }
        static void PatPosi(){
            int x,y;
            Console.WriteLine("calcular las cordenadas de 2 puntos");

            Console.WriteLine("punto 1");
	        x=int.Parse(Console.ReadLine());

	        Console.WriteLine("punto 2");
	        y=int.Parse(Console.ReadLine());
            point = new Point2(x,y);

            static Quadrant GetQuadrant(Point2 point) => point switch{
                (0, 0) => Quadrant.Origin,
                var (x, y) when x > 0 && y > 0 => Quadrant.One,
                var (x, y) when x < 0 && y > 0 => Quadrant.Two,
                var (x, y) when x < 0 && y < 0 => Quadrant.Three,
                var (x, y) when x > 0 && y < 0 => Quadrant.Four,
                var (_, _) => Quadrant.OnBorder,
                _ => Quadrant.Unknown
            };
        } 

        public enum Quadrant{
            Unknown,
            Origin,
            One,
            Two,
            Three,
            Four,
            OnBorder
        }



        static void DecUsin(){
            static int WriteLinesToFile(IEnumerable<string> lines){
                // We must declare the variable outside of the using block
                // so that it is in scope to be returned.
                int skippedLines = 0;
                using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
                {
                    foreach (string line in lines)
                    {
                        if (!line.Contains("Second"))
                        {
                            file.WriteLine(line);
                        }
                        else
                        {
                            skippedLines++;
                        }
                    }
                } // file is disposed here
                return skippedLines;
            }
        }

        static void FunLocEst(){
            Console.WriteLine("Suma de dos numeros con funciones locales estaticas");
            Console.WriteLine($"El resultado es: {M}");

            int M(){
                int y = 5;
                int x = 7;
                return Add(x, y);

                static int Add(int left, int right) => left + right;
            }
        }

        static void IndicRang(){
            var words = new string[]{
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };
            
            var allWords = words[..]; // contains "The" through "dog".
            var firstPhrase = words[..4]; // contains "The" through "fox"
            var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"
        }

    }
}