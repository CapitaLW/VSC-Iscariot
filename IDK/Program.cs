Console.Clear();


double A = 0, B = 0, i, j;
        double[] z = new double[1760];
        char[] b = new char[1760];
        Console.CursorVisible = false;
        Console.SetWindowSize(80, 50);

        for (;;)
        {
            for (int k = 0; k < 1760; k++)
            {
                b[k] = k % 80 == 79 ? '\n' : ' ';
                z[k] = 0;
            }
            for (j = 0; 6.28 > j; j += 0.07)
                for (i = 0; 6.28 > i; i += 0.02)
                {
                    double c = Math.Sin(i),
                           d = Math.Cos(j),
                           e = Math.Sin(A),
                           f = Math.Sin(j),
                           g = Math.Cos(A),
                           h = d + 2,
                           D = 1 / (c * h * e + f * g + 5),
                           l = Math.Cos(i),
                           m = Math.Cos(B),
                           n = Math.Sin(B),
                           t = c * h * g - f * e;
                    int x = (int)(40 + 30 * D * (l * h * m - t * n)),
                        y = (int)(12 + 15 * D * (l * h * n + t * m)),
                        o = x + 80 * y,
                        N = (int)(8 * ((f * e - c * d * g) * m - c * d * e - f * g - l * d * n));
                    if (22 > y && y > 0 && x > 0 && 80 > x && D > z[o])
                    {
                        z[o] = D;
                        b[o] = ".,-~:;=!*#$@"[N > 0 ? N : 0];
                    }
                }
            Console.SetCursorPosition(0, 0);
            Console.Write(b);
            A += 0.04;
            B += 0.01;
        }