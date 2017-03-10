using System;
using System.Drawing;

namespace Fractals
{
	internal static class DragonFractalTask
	{
		public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
		{
            double x = 1, y = 0, ang, dx;
            var random = new Random(seed);
            pixels.SetPixel(x, y);
            while (iterationsCount-- > 0)
            {
                var rand = random.Next(2);
                    ang = Math.PI / 4 + Math.PI / 2 * rand;
                    dx = (x * Math.Cos(ang) - y * Math.Sin(ang))
                        / Math.Sqrt(2.0) + rand;
                    y = (x * Math.Sin(ang) + y * Math.Cos(ang))
                        / Math.Sqrt(2.0);
                x = dx;
                pixels.SetPixel(x, y);
            }
		}
	}
}