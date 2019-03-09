using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var4
{
        class Output
        {
            public Cube Read()
            {
                string[] s;
                int x, y, z;
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    s = sr.ReadLine().Split(new char[] { ' ' });
                    if (!(int.TryParse(s[0], out x)) || !(int.TryParse(s[1], out y)) || !(int.TryParse(s[2], out z)))
                    {
                        throw new ArgumentException("Invalid data type!");
                    }
                }

                Point center = new Point(x, y, z);
                return new Cube(center);
            }
            public void Write(Round a)
            {
                using (StreamWriter ws = new StreamWriter("Output.txt"))
                {
                    ws.WriteLine("Center:({0},{1}), R:{2}", a.Center.x, a.Center.y, a.R);
                    ws.WriteLine("Circumference = {0}", a.Circumference);
                    ws.Write("Square = {0}", a.Square);
                    ws.Flush();
                }
            }
        }
    }
}
