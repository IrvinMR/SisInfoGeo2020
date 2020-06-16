using System;

namespace TercerParcial{
    class Program{
        public class Point2{
    public int X { get; }
    public int Y { get; }

    public Point2(int x, int y) => (X, Y) = (x, y);

    public void Deconstruct(out int x, out int y) =>
        (x, y) = (X, Y);
}
    }
}