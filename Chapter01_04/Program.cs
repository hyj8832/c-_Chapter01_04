using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object c = 123456789L; //long형으로 8바이트당! 한 바이트 당 8 bit
            object w = "abcde";
            Console.WriteLine("a:{0}",a);
            Console.WriteLine("c:{0}", c);
            Console.WriteLine("w:{0}", w);

            Console.WriteLine(a.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(w.GetType());

            if (a.GetType() == System.Type.GetType("System.Int32"))
            {
                Console.WriteLine("a is Int32");
            }

            float d = 1.2345f;
            int e = (int)d;
            int f = 12345;
            float g = 3.1415f;

            Console.WriteLine(e); //다 자르는거임 소수점 이하 
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine("{0:D8}", f); //8자리 채우기 위해 0!
            Console.WriteLine(f.ToString("D8")); //위 코드와 같은 거
            Console.WriteLine(String.Format("{0:D8}", f));//얘도 같은거 
            Console.WriteLine(g.ToString("F2"));//float를 2자리로(얘 반올림해)


            string h = "123456";
            string m = "1.23456";
            int o = int.Parse(h);
            float p = float.Parse(m);
            Console.WriteLine(o);
            Console.WriteLine(p);

            //const int g = 567;

            EFruit tmpEF = EFruit.EF_Banana;
            Console.WriteLine(tmpEF);
            if (tmpEF == EFruit.EF_Apple)
            {
                Console.WriteLine("Apple");
            }
            switch (tmpEF)
            {
                case EFruit.EF_Apple:
                    Console.WriteLine("EF_Apple");
                    break;
                case EFruit.EF_Banana:
                    Console.WriteLine("EF_Banana");
                    break;
                case EFruit.EF_Lemon:
                    Console.WriteLine("EF_Lemon");
                    break;
            }

            int[] tmpPoints = new int[(int)EFruit.EF_Count];
            int i;
            for (i = 0; i < (int)EFruit.EF_Count; i++)
            {
                tmpPoints[i] = i + 1;
            }
            for (i = 0; i < (int)EFruit.EF_Count; i++)
            {
                Console.Write(tmpPoints[i]);
                Console.Write(" : ");
                Console.WriteLine((EFruit)i);
            }

            int? r = null; //?붙이면 null을 int에 넣을 수 있다.
            Console.WriteLine(r.HasValue);
            if (r.HasValue == true)
            {
                Console.WriteLine(r.Value);
            }

            r = 234;
            Console.WriteLine(r.HasValue);
            if (r.HasValue == true)
            {
                Console.WriteLine(r.Value);//값이 뭐든지간에 들어있으니 트루~~
            }

            int _a = 111;
            int _b = _a + 50;
            int _c = 5 * 7;
            int _d = 123 / 5;
            double _e = _d * 5.0;
            
            //이거 두 개 헷갈림
            int _f = _a++;//110
            int _g = _f--;//111
      
            string _h = "123" + "456";
            string _j = (_c == 35) ? "AAA" : "BBB";
            int _k = 1 << 4;
            int _l = 1 << 3;
            int _m = (_k | _l);
            int _n = (_k | _l) & (1 << 3);
            _c *= 3;

            Console.WriteLine("a:" + _a);
            Console.WriteLine(_b);
            Console.WriteLine(_c);
            Console.WriteLine(_d);
            Console.WriteLine(_e);
            Console.WriteLine("F:{0}",_f);
            Console.WriteLine("G:{0}",_g);
            Console.WriteLine(_h);
            Console.WriteLine(_j);
            Console.WriteLine(_k);
            Console.WriteLine(_l);
            Console.WriteLine(_m.ToString("X8"));
            Console.WriteLine(_n.ToString("X8"));






            Console.ReadKey();    
        }
        enum EFruit
        {
            EF_Apple,
            EF_Banana,
            EF_Lemon,
            EF_Count
        }
    
    }
}
