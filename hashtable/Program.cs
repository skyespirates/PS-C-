using System;
using System.Collections;

namespace hashtable
{
    class Klasemen {
      Hashtable teams = new Hashtable();
      public Klasemen(String[] arr) {
        foreach(String e in arr) {
          teams.Add(e, 0);
        }
      }
      public void showTeam() {
        foreach(DictionaryEntry de in teams) {
          Console.WriteLine($"{de.Key}: {de.Value}");
        }
      }
      public void showScore() {
        foreach(DictionaryEntry e in teams) {
          Console.WriteLine(e.Key);
        }
      }

      // CATAT PERMAINAN
      public void catatPermainan(String klubKandang, String klubTandang, string skor) {
        int[] score = Array.ConvertAll(skor.Split(":"), int.Parse);
        if(score[0]==score[1]) {
          teams[klubKandang] = (int) teams[klubKandang] + 1;
          teams[klubTandang] = (int) teams[klubTandang] + 1;
        } else if(score[0]>score[1]) {
          teams[klubKandang] = (int) teams[klubKandang] + 3;
        } else {
          teams[klubTandang] = (int) teams[klubTandang] + 3;
        }
      }

      public void addScore(String key) {
        teams[key] = (int)teams[key]+2;
      }
    }
    class Program
    {
        static void Main(string[] args)
        {
          String[] team = {"Liverpool", "Chelsea", "Arsenal"};
          Klasemen PL = new Klasemen(team);
          PL.catatPermainan("Arsenal", "Liverpool", "2:1");
          PL.catatPermainan("Arsenal", "Chelsea", "1:1");
          PL.catatPermainan("Chelsea", "Arsenal", "0:3");
          PL.catatPermainan("Chelsea", "Liverpool", "3:2");
          PL.catatPermainan("Liverpool", "Arsenal", "2:2");
          PL.catatPermainan("Liverpool", "Chelsea", "0:0");
          PL.showTeam();
        }
    }
}
