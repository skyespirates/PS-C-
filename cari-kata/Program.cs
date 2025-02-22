﻿using System;
using System.Collections.Generic;

namespace cari_kata
{
    class PuzzleKata {

        private string[,] papan = {
          {"J","Y","B","Y","Q","V","W","G","B","Q","F","D","D","U","L","H","M"},
          {"D","G","O","C","G","V","N","K","Z","C","R","U","B","A","O","I","K"},
          {"U","G","E","U","H","E","W","J","W","T","O","Y","N","U","M","N","V"},
          {"N","H","U","R","D","B","R","J","I","V","U","I","T","P","G","H","W"},
          {"I","H","H","O","O","I","E","M","Z","W","T","J","M","D","T","S","V"},
          {"T","M","V","O","I","P","O","U","A","N","B","E","D","X","T","W","X"},
          {"E","Z","H","B","B","Q","A","U","E","N","W","C","W","C","B","O","N"},
          {"D","L","U","S","A","D","F","G","N","R","Y","Y","G","W","W","S","R"},
          {"K","H","Y","I","I","R","R","M","N","I","P","H","A","B","R","W","P"},
          {"I","T","Q","M","S","A","H","I","M","I","R","U","N","Z","Y","H","S"},
          {"N","E","T","H","E","R","L","A","N","D","S","H","U","N","K","E","Z"},
          {"G","F","K","L","N","L","A","G","U","T","R","O","P","B","I","U","E"},
          {"D","C","P","G","O","G","G","A","R","U","P","U","E","O","P","K","M"},
          {"O","J","B","T","D","N","T","A","X","O","B","X","Z","M","J","C","C"},
          {"M","J","F","P","N","S","L","L","X","B","V","C","Y","W","T","K","E"},
          {"R","X","I","S","I","I","Z","W","A","M","K","S","L","N","H","V","S"},
          {"A","O","J","O","A","E","G","T","X","M","C","Z","P","C","I","O","U"}
        };
        private bool isValidPoint(int r, int c)  {
          return r>=0 && r<16 && c>=0 && c<=16 ? true : false;
        }
        private void traverse(int n, int r, int c, int modR, int modC, string word) {
          bool result = true;
          while(isValidPoint(r,c)&&result) {
            if(word.Contains(papan[r,c])) {
              Console.WriteLine($"({r},{c})-{papan[r,c]}");
              r+=modR;
              c+=modC;
            } else {
              result = false;
              break;
            }
          }
          
        }
        public void cariKata(string kataDicari) {
          string kata = kataDicari.ToUpper();
          traverse(kata.Length, 1, 4, 1, 1, kata);
          /*
          for(int i=0; i<17; i++) {
            for(int j=0; j<17; j++) {
              if(papan[i,j]==kata[0]) {
              traverse(kata.Length, i, j, -1, 0, kata);
              traverse(kata.Length, i, j, -1, 1, kata);
              traverse(kata.Length, i, j, 0, 1, kata);
              traverse(kata.Length, i, j, 1, 1, kata);
              traverse(kata.Length, i, j, 1, 0, kata);
              traverse(kata.Length, i, j, 1, -1, kata);
              traverse(kata.Length, i, j, 0, -1, kata);
              traverse(kata.Length, i, j, -1, -1, kata);
              }
            }
          }
          */
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            PuzzleKata puzzle = new PuzzleKata();
            puzzle.cariKata("germany");
              
        }
    }
}
