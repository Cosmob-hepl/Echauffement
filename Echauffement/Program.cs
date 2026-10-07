using System.Diagnostics;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */
        
        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Bonjour, je m'appelle Langue Corentin et mon jeu préféré est Kenshi");
        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Comment t'appelles tu?");
        string FirstName = Console.ReadLine();
        Console.WriteLine("Quel age as tu?");
        int Age = Convert.ToInt32(Console.ReadLine());
        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        bool isUnderage = Age < 18;
        if (Age >= 18)
        {
            Console.WriteLine("Tu es majeur");
        } else
        {
            Console.WriteLine("Tu es mineur");
        }
        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euros as tu sur toi ?");
        float Money = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("portefeuille: " + Money);
        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("Maintenant, choisis une arme parmis les 4 suivantes.");
        Console.Write("1. une dague(25)");
        Console.WriteLine("2.une épée longue(60)");
        Console.WriteLine("3.un marteau(30)");
        Console.WriteLine("4.un sabre laser(400)");
        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Choisis une arme à acheter? (1,2,3,4)");
        int weaponChoice = Convert.ToInt32(Console.ReadLine());
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (weaponChoice == 1)
        {
            float price = 25.0f;
            if (Money < price || isUnderage)
            {
                Console.WriteLine("Désolé, tu n'as pas assez d'argent");
            }
            else
            {
                Money = Money - 25;
                Console.WriteLine("Félicitation, tu as acheté la dague");
            }
        }
        else if (weaponChoice == 2)
        {
            if (Money < 60.0f || isUnderage)
            {
                Console.WriteLine("Désolé, tu n'as pas assez d'argent");
            }
            else
            {
                Money = Money - 60;
                Console.WriteLine("Félicitation, tu as acheté l'épée longue");
            }
        }
        else if (weaponChoice == 3)
        {
            if (Money < 30.0f || isUnderage)
            {
                Console.WriteLine("Désolé, tu n'as pas assez d'argent");
            } else
            {
                Money = Money - 30;
                Console.WriteLine("Félicitation, tu as acheté le marteau");
            }
        }
        else if (weaponChoice == 4 || isUnderage)
        {
            if (Money < 400.0f)
            {
                Console.WriteLine("Désolé, tu n'as pas assez d'argent");
            } else
            {
                Console.WriteLine("Félicitation, tu as acheté le sabre laser");
            }
        }
        else
        {
            Console.WriteLine("Désolé, ce choix d'arme est invalide");
        }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}