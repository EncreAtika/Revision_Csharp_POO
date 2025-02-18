namespace Revision_Csharp_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");  // Afficher un chaine de caractères. Avec Retour à la ligne.
            Console.Write("Bonjour. ");            // Pas de retour à la ligne.
            Console.Write("J'apprends le C#)");
            Console.ReadKey();                  //Récupérer l'Input d'un utilisateur.
            Console.ReadLine();                 // Permets de récupérer une phrase entière de l'utilisateur et de la valider en appuyant sur - entrée -

            Console.WriteLine("Comment tu t'appelles");
            var response = Console.ReadLine(); // on assigne a la variable - response - la saisie qui sera faite par l'utilisateur.
            Console.ReadLine();                 // Le programme sattend à ce que l'utilisateur renseigne son nom.
            Console.WriteLine("Bienvenue ");
            Console.Write(response);            // Le programme sera continué par la console qui affichera le mot saisi par
                                                // l'utilisateur qui correspond à la varible - response -

            // 
        }
    }
}

