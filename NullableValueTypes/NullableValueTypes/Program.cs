using System;

namespace NullableValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing
            int? x = 10;
            object obj = x;

            // unboxing
            object objNull = null;
            int? int1 = (int?)objNull;
            Console.WriteLine($"int1={int1 ?? -1 }");

            int? int2 = (int?)obj;
            Console.WriteLine($"int2={int2 ?? -1 }");

            int int3 = (int)obj;
            Console.WriteLine($"Proof that boxing happens only on value={int3}");
        }

        private static void Nullable_Samples()
        {
            bool? flag1 = false;
            Console.WriteLine($"flag1={flag1}");
            Console.WriteLine($"flag1.HasValue={flag1.HasValue}");
            Console.WriteLine($"flag1.Value={flag1.Value}");
            Console.WriteLine($"flag1.GetValueOrDefault()={flag1.GetValueOrDefault()}");
            Console.WriteLine($"flag1.GetValueOrDefault(...)={flag1.GetValueOrDefault(false)}");
            Console.WriteLine($"flag1 (null coalesce)={flag1 ?? false}");

            int? int1 = null;
            Console.WriteLine($"int1={int1}");
            Console.WriteLine($"int1.HasValue={int1.HasValue}");
            // This throws InvalidOperationException
            //Console.WriteLine($"int1.Value={int1.Value}");
            Console.WriteLine($"int1.GetValueOrDefault()={int1.GetValueOrDefault()}");
            Console.WriteLine($"int1.GetValueOrDefault(...)={int1.GetValueOrDefault(-1)}");
            Console.WriteLine($"int1 (null coalesce) ={int1 ?? -2}");

            // Works because of operator elevation
            int? int2 = int1 + 20;
            Console.WriteLine($"int2={int2}");
        }

        private static void Boxing_And_Unboxing()
        {
            // boxing
            int? x = 10;
            object obj = x;

            // unboxing
            object objNull = null;
            int? int1 = (int?)objNull;
            Console.WriteLine($"int1={int1 ?? -1 }");

            int? int2 = (int?)obj;
            Console.WriteLine($"int2={int2 ?? -1 }");

            int int3 = (int)obj;
            Console.WriteLine($"Proof that boxing happens only on value={int3}");
        }
    }
}
