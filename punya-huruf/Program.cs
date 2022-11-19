using System;

namespace punya_huruf
{
    class Program
    {
        static Boolean punyaHuruf(String kataPertama, String kataKedua) {
         Boolean res = true;
         foreach(Char i in kataPertama) {
          if(kataKedua.ToLower().Contains(i)) {
            continue;
          } else {
            res = false;
            break;
          }
         }
          return res;
        }
        static void Main(string[] args)
        {
          Boolean result1 = punyaHuruf("cat", "antarctica");
          Boolean result2 = punyaHuruf("cat", "australia");
          Boolean result3 = punyaHuruf("cat", "ANTARCTICA");
          Console.WriteLine(result1);
          Console.WriteLine(result2);
          Console.WriteLine(result3);
        }
    }
}
