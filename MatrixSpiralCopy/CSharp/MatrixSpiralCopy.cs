using System;
using System.Collections.Generic;
class Solution
{
    public static int[] SpiralCopy(int[,] inputMatrix)
    {
    
        // your code goes here
        if (inputMatrix.GetLength(0) < 1 || inputMatrix.GetLength(0) > 100) {
           return null;
        }
        if (inputMatrix.GetLength(1) <1 || inputMatrix.GetLength(1) > 100) {
           return null;
        }

        if (inputMatrix.GetLength(0) == 1 && inputMatrix.GetLength(1) == 1 ) {
          return new int[]{inputMatrix[0,0]};
        }

        List<int> result = new List<int>();
        
        var rightCol = inputMatrix.GetLength(1) -1;
        var btmRow = inputMatrix.GetLength(0) - 1;

        var leftCol = 0;
        var topRow = 0;
  // First
  
        //while

        while (topRow <= btmRow && leftCol <= rightCol) {
          for (int i = leftCol; i <= rightCol; i++) {
             result.Add(inputMatrix[topRow, i]);
          } 
          topRow++;

          for (int j = topRow; j <= btmRow; j++) {
             result.Add(inputMatrix[j, rightCol]);
          }  
          rightCol--; 

          if (topRow <= btmRow) {
            for (int i = rightCol; i >=  leftCol; i--) {
               result.Add(inputMatrix[btmRow, i]);
            }
            btmRow--;

          }

          if (leftCol <= rightCol) {
            for (int j = btmRow ; j >= topRow; j--) {
               result.Add(inputMatrix[j, leftCol]);
            }  
            leftCol ++;
          }
        }

        return result.ToArray();
    }

    static void Main(string[] args)
    {

    }
}
