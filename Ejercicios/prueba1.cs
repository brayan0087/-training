using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



class MainClass
{

    //Haga que la función FindIntersection(strArr ) lea la matriz de cadenas almacenadas en strArr que contendrá 
    //2 elementos: el primer elemento representará una lista de números separados por comas ordenados en orden ascendente, 
    //el segundo elemento representará una segunda lista de números separados por comas números(también ordenados). 
    //Su objetivo es devolver una cadena separada por comas que contenga los números que aparecen en los 
    //elementos de strArr en orden.Si no hay intersección, devuelve la cadena false .


    //public static string FindIntersection(string[] strArr)
    //{
    //    List<int> output = new List<int>();

    //    int[] l1 = strArr[0].Split(",").Select(x => Convert.ToInt32(x)).ToArray();
    //    int[] l2 = strArr[1].Split(",").Select(x => Convert.ToInt32(x)).ToArray();

    //    for (int i = 0; i < l1.Length; i++)
    //    {
    //        if (l2.Contains(l1[i]))
    //        {
    //            output.Add(l1[i]);

    //        }
    //        else
    //        {
    //            return "false";
    //        }
    //    }

    //    return string.Join(",", output.ToArray());

    //    // code goes here  


    //}






    static void Main()
    {

        //ejerci1 obj = new ejerci1();
        //string[] strArr = new string[] { "1,2,3,4,5,6", "5,1,3,4" };
        //Console.WriteLine(obj.FindIntersection(strArr));

        //ejerci1 obj = new ejerci1();
        //string s = "acc ? 7 ?? sss ? 3rr1 ?????? 5";
        //Console.WriteLine (obj.QuestionsMarks(s));

        //ejerci1 obj = new ejerci1();


        //string s = "5??aaaaaaaaaaaaaaaaaaa?5?5";


        //string s = "u__hello_world123_";
        //ejerci1 obj = new ejerci1();

        //Console.WriteLine(obj.validate_user(s));



        ejerci1 obj = new ejerci1();

        string s = "funnnn&!! time";

        Console.WriteLine(obj.LongestWord(s));





    }





}


