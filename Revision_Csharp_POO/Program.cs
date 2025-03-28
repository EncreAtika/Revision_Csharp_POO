﻿using System; // Le dossier system vient du Framework .net --- La fonction using permet d'utiliser le dossier ou le namespace system.


namespace Revision_Csharp_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Afficher un chaine de caractères. Avec Retour à la ligne :
            Console.WriteLine("Hello, World!");

            // Pas de retour à la ligne :
            Console.Write("Bonjour. ");            
            
            Console.Write("J'apprends le C#)");

            // Permets de récupérer une phrase entière de l'utilisateur et de la valider en appuyant sur - entrée -
            Console.ReadLine();                 

            Console.WriteLine("Comment tu t'appelles");
            // on assigne a la variable - response - la saisie qui sera faite par l'utilisateur :
            var response = Console.ReadLine();
            // Le programme sattend à ce que l'utilisateur renseigne son nom 
            //LA DIFFERENCE ENTRE READLINE ET READKEY c'est que - ReadLine - permet la saisie d'une phrase entière.
            Console.ReadLine();                
            
            Console.WriteLine("Bienvenue ");

            // Le programme sera continué par la console qui affichera le mot saisi par
            // l'utilisateur qui correspond à la varible - response -
            Console.Write(response);
            
            
            // réaliser une addition :
            int one = 1;
            int two = 2;
            int result = one + 5;
            Console.WriteLine(result);

            // on peut additionner en mettant le nom de la variable int;
            int newResult = one + one;
            Console.WriteLine(newResult);

            int reNewResult = one + two;
            Console.WriteLine(reNewResult);

            // realiser une division :
            int ten = 10;
            int division = ten / two;
            Console.WriteLine(division);

            // le Modulo, représenté par le symbole pourcentage. Le Modulo est le reste de la dision euclidienne ici ce sera - 1 - :
            // le Modulo est peu utilisé.
            int onze = 11;
            int modulo = onze % 2;
            Console.WriteLine(modulo);


            // LA CALCULATRICE :

            // Renseigner un premier nombre :
            Console.WriteLine("Tapez un nombre : ");

            // Creation d'une variable nommée - firstNumber" ici on utilise le terme - var- plutôt que - int - pour nommer cette variable.
            var firstNumber = Console.ReadLine();

            //Puis renseigner un second nombre :
            Console.WriteLine("Tapez un deuxième nombre : ");
            var secondNumber = Console.ReadLine();
            
            // Faire l'addition :
            var resultat = firstNumber + secondNumber;
            
            // Afficher le résultat :
            Console.WriteLine(resultat);

            // LE PROGRAMME VA AFFICHER LES DEUX CHIFFRES SAISIS L'UN APRèS L'AUTRE
            // CAR IL Y A UN PROBLEME DANS LA MANIERE DONT LE COMPILATEUR VA REAGIR.
            // LE COMPILATEUR ADDITIONNE EN FAIT deux CHAINE DE CARACTèRE ( - firstNumber - et - secondNumber -) 
            // QUI APPARAISSENT L'UNE APRèS L'AUTRE.
            // 






            Console.ReadKey(); // Mettre le programme en pause et Récupérer l'Input d'un utilisateur
        }
    }
}

