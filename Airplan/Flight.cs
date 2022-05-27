using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplan
{
    public static class Flight
    {
        public static int Calculate(string[] inputs, bool includeAim)
        {
            var position = 0;
            var depth = 0;
            var aim = 0;

            foreach (var input in inputs)
            {
                if (input.StartsWith("forward"))//4
                {
                    var value = int.Parse(input[7..].Trim());
                    position += value;
                    if (includeAim)
                    {
                        depth += aim * value;
                    }
                }
                else if (input.StartsWith("up"))
                {
                    if (includeAim)
                    {
                        aim -= int.Parse(input[2..].Trim());
                    }
                    else
                    {
                        depth -= int.Parse(input[2..].Trim());
                    }
                }
                else if (input.StartsWith("down"))
                {
                    if (includeAim)
                    {
                        aim += int.Parse(input[4..].Trim());
                    }
                    else
                    {
                        depth += int.Parse(input[4..].Trim());
                    }
                }
            }

            return Math.Abs(position * depth);
        }
    }
}
