using System;
using System.Range;
using RGBColor;

namespace TercerExamenParcial
{
    partial class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1) Menu();
            else{
                Console.ForegroundColor = ConsoleColor.Blue;
                switch(int.Parse(args[0])){
                    case 1: SoloLect(); break;
                    case 2: ExpSwitch(); break;
                    case 3: PatProp(); break;
                    case 4: PatTupla(); break;
                    case 5: PatPosi(); break;
                    case 6: DecUsing(); break;
                    case 7: FunLocEst(); break;
                    case 8: IndicRang(); break;
                    default: Console.WriteLine("Opcion invalida..."); break;
                }
                Console.ForegroundColor = ConsoleColor.Black;
            }


        }

        static void Menu(){
            //menu de opciones de red
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Características nuevas en C#8 ......");
            Console.WriteLine("[ 1 ] Miembros de solo lectura .....");
            Console.WriteLine("[ 2 ] Expresiones switch............");
            Console.WriteLine("[ 3 ] Patrones de propiedades ......");
            Console.WriteLine("[ 4 ] Patrones de tupla ............");
            Console.WriteLine("[ 5 ] Patrones posicionales ........");
            Console.WriteLine("[ 6 ] Declaraciones Using ..........");
            Console.WriteLine("[ 7 ] Funciones locales estáticas ..");
            Console.WriteLine("[ 8 ] Indices y rangos .............");
        }


        static void SoloLect() {
            Console.Clear();
            object p = new SamplePoint();
           Console.WriteLine($"{p}");
            }

        static void ExpSwitch(){
            public enum Rainbow{
                Red,
                Orange,
                Yellow,
                Green,
                Blue,
                Indigo,
                Violet
            }
            
            public static RGBColor FromRainbow(Rainbow colorBand) =>
            colorBand switch{
                Rainbow.Red    => new RGBColor(0xFF, 0x00, 0x00),
                Rainbow.Orange => new RGBColor(0xFF, 0x7F, 0x00),
                Rainbow.Yellow => new RGBColor(0xFF, 0xFF, 0x00),
                Rainbow.Green  => new RGBColor(0x00, 0xFF, 0x00),
                Rainbow.Blue   => new RGBColor(0x00, 0x00, 0xFF),
                Rainbow.Indigo => new RGBColor(0x4B, 0x00, 0x82),
                Rainbow.Violet => new RGBColor(0x94, 0x00, 0xD3),
                _              => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),
    };
                Console.WriteLine("Vacio");
        }

        static void PatProp(){
            //calcular el precio segun la zona
            int precio=75;
            
        Console.WriteLine($"El precio en la zona centro es de ={precio * 1.08}");
        Console.WriteLine($"El precio en la zona norte es de ={precio * 1.05}");
        Console.WriteLine($"El precio en la zona sur es de ={precio * 1.03}");

        }
        
        static void PatTupla(){
            public static string RockPaperScissors(string first, string second)
                => (first, second) switch
                {
                    ("rock", "paper") => "rock is covered by paper. Paper wins.",
                    ("rock", "scissors") => "rock breaks scissors. Rock wins.",
                    ("paper", "rock") => "paper covers rock. Paper wins.",
                    ("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
                    ("scissors", "rock") => "scissors is broken by rock. Rock wins.",
                    ("scissors", "paper") => "scissors cuts paper. Scissors wins.",
                    (_, _) => "tie"
                };
            Console.WriteLine("Vacio");

        }
        
        static void PatPosi(){

            public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y) => (X, Y) = (x, y);

    public void Deconstruct(out int x, out int y) =>
        (x, y) = (X, Y);
}

            public enum Quadrant
{
    Unknown,
    Origin,
    One,
    Two,
    Three,
    Four,
    OnBorder
}

            static Quadrant GetQuadrant(Point point) => point switch
{
    (0, 0) => Quadrant.Origin,
    var (x, y) when x > 0 && y > 0 => Quadrant.One,
    var (x, y) when x < 0 && y > 0 => Quadrant.Two,
    var (x, y) when x < 0 && y < 0 => Quadrant.Three,
    var (x, y) when x > 0 && y < 0 => Quadrant.Four,
    var (_, _) => Quadrant.OnBorder,
    _ => Quadrant.Unknown
};
            Console.WriteLine("Vacio");               
        }
        
        static void DecUsing(){
            static int WriteLinesToFile(IEnumerable<string> lines)
{
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
            Console.WriteLine("Vacio");

        }
        
        static void FunLocEst(){
            int M()
{
    int y = 5;
    int x = 7;
    return Add(x, y);

    static int Add(int left, int right) => left + right;
}
            Console.WriteLine("Vacio");
                        
        }

        static void IndicRang(){

            var words = new string[]
{
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
};              // 9 (or words.Length) ^0

            var allWords = words[..]; // contains "The" through "dog".
var firstPhrase = words[..4]; // contains "The" through "fox"
var lastPhrase = words[6..]; // contains "the", "lazy" and "dog"

            Console.WriteLine("Vacio");
                    
        }

    }
            
}
