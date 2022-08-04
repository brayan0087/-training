using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class ejerci1
{
    public  string QuestionsMarks(string str)
    {
        string polished = Regex.Replace(str, @"[^\d\?]", string.Empty);//crea una variable string donde almacena la variable parametro remplazada por la expresion regular
        var matches = Regex.Matches(polished, @"([\d]{1}[\?]{3}[\d]{1})");//agrega a una variable los match que se encuentren de la expresion regular
        var results = new List<int>(); //crea una nueva lista de tipo int 

        foreach (Match m in matches)//recorre  matches 
        {
            int a = Convert.ToInt32(m.Value.First().ToString());//asigna a al primer valor y lo convierte en int
            int b = Convert.ToInt32(m.Value.Last().ToString());//asigna b al ultimo valor y lo convierte en int

            results.Add(a + b); //añade a la lista la suma de a + b
        }

        string result = results.Count != 0 && results.Any(r => r == 10) ? "true" : "false"; //si el resultado es diferente a  0 y cumple la condicion de igual a 10 devulve true o false

        return result; //retorna el resultado
    }




    // Haga que la función QuestionsMarks( str ) tome el parámetro de cadena str ,
    // que contendrá números de un solo dígito, letras y signos de interrogación, 
    // y verifique si hay exactamente 3 signos de interrogación entre cada par de dos números que suman 10. 
    // Si es así, entonces su programa debería devolver la cadena verdadera , de lo contrario debería devolver la cadena falsa. 
    // Si no hay dos números que sumen 10 en la cadena, entonces su programa también debería devolver falso .
    //Por ejemplo: si str es "arrb6???4xxbl5???eee5", entonces su programa debería devolver verdaderoporque hay
    //exactamente 3 signos de interrogación entre el 6 y el 4, y 3 signos de interrogación entre el 5 y el 5 al final de la cadena.


    public string Vetifi(string str)
    {

        string union = Regex.Replace(str, @"[^\d\?]", string.Empty);
        var match = Regex.Matches(union, @"([\d]{1}[\?]{3}[\d]{1})");//1???8

        var result = new List<int>();

        foreach (Match item in match)
        {
            int a = Convert.ToInt32(item.Value.First().ToString());
            int b = Convert.ToInt32(item.Value.Last().ToString());
            result.Add(a + b);
        }

        string results = result.Count != 0 && result.Any(x => x == 10) ? "True" : "False";

        return results;

    }


    // Haga que la función QuestionsMarks( str ) tome el parámetro de cadena str ,
    // que contendrá números de un solo dígito, letras y signos de interrogación, 
    // y verifique si hay exactamente 3 signos de interrogación entre cada par de dos números que suman 10. 
    // Si es así, entonces su programa debería devolver la cadena verdadera , de lo contrario debería devolver la cadena falsa. 
    // Si no hay dos números que sumen 10 en la cadena, entonces su programa también debería devolver falso .
    //Por ejemplo: si str es "arrb6???4xxbl5???eee5", entonces su programa debería devolver verdaderoporque hay
    //exactamente 3 signos de interrogación entre el 6 y el 4, y 3 signos de interrogación entre el 5 y el 5 al final de la cadena.



    public string verificar(string str)
    {
        string remplace = Regex.Replace(str, @"[^\d\?]",string.Empty);
        var check = Regex.Matches(remplace, @"([\d]{1}[\?]{3}[\d]{1})");
        var List = new List<int>();

        foreach (Match item in check)
        {
            int a = Convert.ToInt32(item.Value.First().ToString());
            int b = Convert.ToInt32(item.Value.Last().ToString());

            List.Add(a + b);
        }
        string result = List.Count != 0 && List.Any(x => x == 10) ? "True" : "False";


            return result;
 
    }



    //Haga que la función CodelandUsernameValidation( str ) tome el parámetro str que se está pasando y 
    //    determine si la cadena es un nombre de usuario válido de acuerdo con las siguientes reglas:

    //1.El nombre de usuario tiene entre 4 y 25 caracteres.
    //2. Debe comenzar con una letra.
    //3. Solo puede contener letras, números y el carácter de subrayado.
    //4. No puede terminar con un carácter de subrayado.

    //Si el nombre de usuario es válido, su programa debe devolver la cadena verdadera , de lo contrario, devolver la cadena falsa .



    public bool ValidateUser(string str)
    {

            bool isValidUser = false;

            //Checking all criteria for the username validation
            if (str.Length > 4 && str.Length < 25    //valida la lungitud de str que sea mayor a 4 y menor que 25
            


            && str.Substring(str.Length - 1, 1) != "_"  //primer parametro cuenta la longitud de str, segundo parametro toma la posicion -1 de length
                                                        //tercer parametro toma solo 1 caracter a partir de esa posicion y tiene que ser diferente a "_"


            && Regex.IsMatch(str, @"^[a-zA-Z0-9_]+$")  //busca matches segun la expresion regular  solo letras numeros y _




            && Regex.IsMatch(str.Substring(0, 1), @"^[a-zA-Z]+$")) //busca match haciendo substring a la primera posicion y solo un caracter 
                                                                    //segun la expresion regular que solo sea letras 
            {
                    isValidUser = true;    //si pasa todos los filtros es true;
            }

            return isValidUser;

      


    }



    //Haga que la función CodelandUsernameValidation( str ) tome el parámetro str que se está pasando y 
    //    determine si la cadena es un nombre de usuario válido de acuerdo con las siguientes reglas:

    //1.El nombre de usuario tiene entre 4 y 25 caracteres.
    //2. Debe comenzar con una letra.
    //3. Solo puede contener letras, números y el carácter de subrayado.
    //4. No puede terminar con un carácter de subrayado.

    //Si el nombre de usuario es válido, su programa debe devolver la cadena verdadera , de lo contrario, devolver la cadena falsa .


    public bool validate_user(string str)
    {
        bool user = false;

        if (str.Length > 4 && str.Length < 25 && Regex.IsMatch(str.Substring(0,1),@"^[a-zA-z]+$")&& Regex.IsMatch(str,@"[a-zA-z0-9_]")&& str.Substring(str.Length -1,1) != "_" )
        {
            user = true;
        }

        return user;

    }



    //Haga que la función FindIntersection(strArr ) lea la matriz de cadenas almacenadas en strArr que contendrá 
    //2 elementos: el primer elemento representará una lista de números separados por comas ordenados en orden ascendente, 
    //el segundo elemento representará una segunda lista de números separados por comas números(también ordenados). 
    //Su objetivo es devolver una cadena separada por comas que contenga los numeros que estan repetidos ordenados 


    public  string FindIntersection(string[] strArr)
    {
        string resultString = string.Join(",", strArr[0].Split(',').Select(x => x.Trim()).Except(strArr[1].Split(',').Select(x => x.Trim())));
        return string.IsNullOrEmpty(resultString) ? "false" : resultString;

    }


    //Distinct() obtiene todos los items unicos sin repetirse de una colecion 
    //Intersect() obtiene todos los items repetidos  de dos coleciones 
    //Union() obtiene todos los items unicos de  dos coleciones
    //Exept() obtiene los items del primer listado que no estan en el segundo
    //All() Todos cumplen la condicion dada en el lambda devuelve bolean
    //Any() Si al menos uno cumple la condicion dada en el lambda devuelve bolean
    //Contains() Devuelve un valor que indica si un carácter especificado aparece dentro de esta cadena. 


    //Haga que la función FindIntersection(strArr ) lea la matriz de cadenas almacenadas en strArr que contendrá 
    //2 elementos: el primer elemento representará una lista de números separados por comas ordenados en orden ascendente, 
    //el segundo elemento representará una segunda lista de números separados por comas números(también ordenados). 
    //Su objetivo es devolver una cadena separada por comas que contenga los numeros que estan repetidos ordenados


    public string devolver(string[] str)
    {
        string result = string.Join(",", str[0].Split(",").Select(x => x.Trim()).Intersect(str[1].Split(",").Select(x => x.Trim())));

        return string.IsNullOrEmpty(result) ? "false" : result;
        

    }



    //Haga que la función LongestWord(sen) tome el parámetro sen que se está pasando y devuelva la palabra más larga de la cadena.
    //Si hay dos o más palabras que tienen la misma longitud, devuelve la primera palabra de la cadena con esa longitud.Ignore 
    //la puntuación y suponga que sen no estará vacío.Las palabras también pueden contener números, por ejemplo, "Hola mundo123 567"     


    public  string LongestWord(string sen)
    {

        Regex rgx = new Regex(@"[^\w\s]");//toma palabras con espacios
        sen = rgx.Replace(sen, "");//remplaza sen por el patron rgx
        string[] words = sen.Split(' ');//crea un array tipo string y lo iguala a sen y lo divide en dos subcadenas con Split

        return words.OrderByDescending(x => x.Length).First(); //devuelve el primer elemento del  array ordenandolo de forma decendiente segun la longitud

    }
















}







