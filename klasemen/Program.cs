using System;
using System.Collections.Generic;
using System.Linq;

namespace klasemen
{
    class Klasemen {
      public IDictionary<string, int> teams = new Dictionary<string, int>();
      public Klasemen(string[] arr) {
        foreach(string e in arr) {
          teams.Add(e, 0);
        }
      }

      public void catatPermainan(string klubKandang, string klubTandang, string skor) {
        int[] score = Array.ConvertAll(skor.Split(":"), int.Parse);
        if(score[0]==score[1]) {
          teams[klubKandang] = teams[klubKandang]+1;
          teams[klubTandang] = teams[klubTandang]+1;
        } else if(score[0]>score[1]) {
          teams[klubKandang] = teams[klubKandang]+3;
        } else {
          teams[klubTandang] = teams[klubTandang]+3;
        }
      }
      public void cetakKlasemen() {
          List<KeyValuePair<string, int>> list = teams.ToList();

          for(int i=0; i<list.Count()-1; i++) {
            for(int j=0; j<list.Count()-i-1; j++) {
              if(list[j].Value<list[j+1].Value) {
                KeyValuePair<string, int> temp = list[j];
                list[j] = list[j+1];
                list[j+1] = temp;
              }
            }
          }
          foreach (KeyValuePair<string, int> item in list) {
            Console.WriteLine(item);
          }
      }
      public string ambilPeringkat(int nomorPeringkat) {
        List<KeyValuePair<string, int>> list = teams.ToList();
        for(int i=0; i<list.Count()-1; i++) {
          for(int j=0; j<list.Count()-i-1; j++) {
            if(list[j].Value<list[j+1].Value) {
              KeyValuePair<string, int> temp = list[j];
              list[j] = list[j+1];
              list[j+1] = temp;
            }
          }
        }
        return list[nomorPeringkat-1].Key;
      }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Klasemen PL = new Klasemen(new string[]{"Liverpool", "Chelsea", "Arsenal"});
            PL.catatPermainan("Arsenal", "Liverpool", "2:1");
            PL.catatPermainan("Arsenal", "Chelsea", "1:1");
            PL.catatPermainan("Chelsea", "Arsenal", "0:3");
            PL.catatPermainan("Chelsea", "Liverpool", "3:2");
            PL.catatPermainan("Liverpool", "Arsenal", "2:2");
            PL.catatPermainan("Liverpool", "Chelsea", "0:0");
            PL.cetakKlasemen();
            Console.WriteLine(PL.ambilPeringkat(2));
        }
    }
}
