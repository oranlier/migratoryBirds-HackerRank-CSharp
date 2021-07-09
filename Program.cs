using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int [] migbirdType = new int[6];

        foreach (int item in arr)
        {
            switch (item)
            {
                case 1:
                    migbirdType[1] += 1;
                    break;
                case 2:
                    migbirdType[2] += 1;
                    break;
                case 3:
                    migbirdType[3] += 1;
                    break;
                case 4:
                    migbirdType[4] += 1;
                    break;
                case 5:
                    migbirdType[5] += 1;
                    break;
            }
        }

        int encokbulunansayi = 1;
        int encokbulunadet = migbirdType[1];

        for (int i = 1; i < 6; i++)
        {
            if (i != encokbulunansayi){
                if (migbirdType[i] > encokbulunadet)
                    {
                        encokbulunansayi = i;
                        encokbulunadet = migbirdType[i];
                    }
                else if(migbirdType[i] == encokbulunadet)
                    {
                        if(i<encokbulunansayi){
                            encokbulunansayi = i;
                        }
                    }
            }
        }

        return encokbulunansayi;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);
        Console.WriteLine(result);

    }
}
