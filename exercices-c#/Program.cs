// Exercice Brief :

// Exerciice 7: Le nombre mystère

/*Console.WriteLine("--- Trouver le nombre mystère ---");

// Initialiser une variable contenant la fonction Random()
Random aleatoire = new Random();

// Déclaration des variables nécessaires au jeu
int nbMystere = aleatoire.Next(1, 51); // Génère un rng entre 1 et 50
int nombre = 0; // Variable contenant l'entrée utilisateur
Console.WriteLine(nbMystere); // DEV : Vérifier si le programme fonctionne

// Tant que l'utilisateur n'a pas trouvé le nbMystère, on itère
while (nombre != nbMystere)
{
    // Demander à l'utilisateur de saisir un nombre
    Console.WriteLine("Veuillez saisir un nombre");

    nombre = Convert.ToInt32(Console.ReadLine());
    // Si le nombre de l'utilisateur est inférieur au nbMystère
    if (nombre < nbMystere)
    {
        // Afficher une erreur en rouge "le nbMystère est plus grand"
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("le nombre mystère est plus grand");
        Console.ResetColor();

    }
    // Si l'entrée utilisateur est > au nbMystère
    else if (nombre > nbMystere)
    {
        // Ecrire une erreur en rouge "le nbMystère est plus petit"
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Le nombre mystère est plus petit");
        Console.ResetColor();

    }
    // Sinon, cela veut dire que l'entrée utilisateur est égale au nbMystère
    else
    {
        // On félicite l'utilisateur et à la fin de l'itération, la boucle sera false
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bravo !!!! Vous avez trouver la bonne réponse");
        Console.ReadLine();
        Console.ResetColor();
    }
}*/

// exercice 8 : Quelle taile dois-je prendre ?

/*Console.WriteLine("--- Quelle taille dois-je prendre ?");

int taille;
int poids;

Console.Write("Entrez votre taille (en cm) : ");
taille = Convert.ToInt32(Console.ReadLine());

Console.Write("Entrez votre poids (en kg) : ");
poids = Convert.ToInt32(Console.ReadLine());

if ((taille >= 145 && taille <= 169 && poids >= 43 && poids <= 47) ||
    (taille >= 145 && taille <= 166 && poids >= 48 && poids <= 53) ||
    (taille >= 145 && taille <= 163 && poids >= 54 && poids <= 59) ||
    (taille >= 145 && taille <= 160 && poids >= 60 && poids <= 65))
{
    Console.WriteLine("Prennez la taille 1.");
}
else if ((taille >= 169 && taille <= 178 && poids >= 48 && poids <= 53) ||
         (taille >= 166 && taille <= 175 && poids >= 54 && poids <= 59) ||
         (taille >= 163 && taille <= 172 && poids >= 60 && poids <= 65) ||
         (taille >= 160 && taille <= 169 && poids >= 66 && poids <= 71))
{
    Console.WriteLine("Prennez la taile 2");
}
else if ((taille >= 172 && taille <= 183 && poids >= 54 && poids <= 59) ||
         (taille >= 175 && taille <= 183 && poids >= 60 && poids <= 65) ||
         (taille >= 172 && taille <= 183 && poids >= 66 && poids <= 71) ||
         (taille >= 163 && taille <= 183 && poids >= 72 && poids <= 77))
{
    Console.WriteLine("Prennez la taile 3");
}
else
{
    Console.WriteLine("Aucune taille ne vous correspond");
}
*/
// Exercice 9 : Gestion des notes partie 2

/*int choix;
double[] notes = new double[100];
int nombreNotes = 0;
double somme = 0;
double grandeNote = 0;
double petiteNote = 20;
bool notesExistent = false;

do
{
    Console.Clear(); // Ajout pour nettoyer l'écran
    Console.WriteLine("---   GESTION DES NOTES AVEC MENU   ---");
    Console.WriteLine("1--- Saisir les notes");
    Console.WriteLine("2--- Afficher la plus grande note");
    Console.WriteLine("3--- Afficher la plus petite note");
    Console.WriteLine("4--- Afficher la moyennes des notes");
    Console.WriteLine("0--- Quitter le programme");
    Console.Write("Faites votre choix : ");

    choix = Convert.ToInt32(Console.ReadLine());

    switch (choix)
    {
        case 1:
            Console.WriteLine("=== SAISIE DES NOTES ===");
            Console.Write("Combien de notes voulez-vous saisir ? ");
            nombreNotes = Convert.ToInt32(Console.ReadLine());

            somme = 0;
            grandeNote = 0;
            petiteNote = 20;

            int compteur = 0;
            do
            {
                Console.Write($"Saisissez la note {compteur + 1} : ");
                notes[compteur] = Convert.ToDouble(Console.ReadLine()); // Correction: Double au lieu de Int32

                somme = somme + notes[compteur];

                if (notes[compteur] > grandeNote)
                {
                    grandeNote = notes[compteur];
                }

                if (notes[compteur] < petiteNote)
                {
                    petiteNote = notes[compteur];
                }

                compteur++;

            } while (compteur < nombreNotes);

            notesExistent = true;
            Console.WriteLine("\nNotes saisies avec succès !");
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
            break;

        case 2:
            Console.WriteLine("===   La plus grande note  ===");

            if (notesExistent && nombreNotes > 0) // Correction: vérifier si notes existent
            {
                Console.WriteLine($"La plus grande note est : {grandeNote:F2}");
            }
            else
            {
                Console.WriteLine("Aucune note n'a été saisie.");
                Console.WriteLine("Veuillez d'abord saisir des notes (option 1).");
            }

            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("===   La plus petite note  ===");

            if (notesExistent && nombreNotes > 0) // Correction: vérifier si notes existent
            {
                Console.WriteLine($"La plus petite note est : {petiteNote:F2}");
            }
            else
            {
                Console.WriteLine("Aucune note n'a été saisie.");
                Console.WriteLine("Veuillez d'abord saisir des notes (option 1).");
            }

            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
            break;

        case 4:
            Console.WriteLine("===   La Moyenne des notes   ===");

            if (notesExistent && nombreNotes > 0)
            {
                double moyenne = somme / nombreNotes;
                Console.WriteLine($"Moyenne des notes : {moyenne:F2}");
            }
            else
            {
                Console.WriteLine("Aucune note n'a été saisie.");
                Console.WriteLine("Veuillez d'abord saisir des notes (option 1).");
            }

            Console.WriteLine("\nAppuyez sur une touche pour continuer...");
            Console.ReadKey();
            break;

        case 0:
            Console.Clear();
            Console.WriteLine("Au revoir !");
            Environment.Exit(0);
            break;

        default:
            Console.Clear();
            Console.WriteLine("Choix invalide ! Veuillez saisir 1, 2, 3, 4 ou 0.");
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
            break;
    }

} while (choix != 0);

*/

// 1.Conditions simples


// exercice 1 :  Écrire un programme qui vérifie si un nombre donné est supérieur à 10.

//Console.WriteLine("Saisissez un nombre : ");
//int nombre = Convert.ToInt32(Console.ReadLine());

//if (nombre < 10)
//{
//    Console.WriteLine("Le nombre est inférieur à 10");
//}

//else
//{
//    Console.WriteLine("a est supérieur à 10");
//}



// exercicie 2 :  Vérifier si un nombre donné est positif, négatif ou nul.



//Console.WriteLine("Saisissez un nombre : ");
//int nombre = Convert.ToInt32(Console.ReadLine());

//if (nombre < 0)
//{
//    Console.WriteLine("Le nombre est négatif");
//}
//else if (nombre > 0)
//{
//    Console.WriteLine("Le nombre est positif");
//}
//else
//{
//    Console.WriteLine("Le nombre est nul");
//}


//exercice 3. Créer un programme qui affiche "Vous êtes mineur" si l’âge est inférieur à 18.

//Console.WriteLine("Saisissez votre age :");
//int nombre = Convert.ToInt32(Console.ReadLine());

//if (nombre < 18)
//{
//    Console.WriteLine("Vous êtes mineur");
//}
//else
//{
//    Console.WriteLine("Vous êtes majeur");
//}

//exercice 4. Écrire un programme qui vérifie si une chaîne de caractères est vide ou non.

//string mot = " ";

//if (mot == "")
//{
//    Console.WriteLine("chaine de caractère vide");
//} else
//{
//    Console.WriteLine("chaine de caractère non vide");
//}


// exercice 5. Vérifier si un nombre est pair ou impair.


/*Console.WriteLine("Saisissez un nombre");
int nombre = Convert.ToInt32(Console.ReadLine());

if (nombre % 2 == 0)
{
    Console.WriteLine("Le nombre est pair");
}
else
{
    Console.WriteLine("Le nombre est impair");
};*/

/* exercice 6. Écrire un programme qui compare deux nombres et affiche le plus grand.

Console.WriteLine("Saisissez le nombre 1");
int nombre1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Saisissez le nombre 2"); 
int nombre2 = Convert.ToInt32(Console.ReadLine());

if (nombre1 > nombre2)
{
    Console.WriteLine("Le nombre 1 est supérieur au nombre 2");
}
else
{
    Console.WriteLine("Le nombre 2 est supérieur au nombre 1");
};
*/

//exercice 7 : Vérifier si un nombre est divisible par 3 ou par 5.

/*Console.WriteLine("Saisissez un nombre");
int nombre = Convert.ToInt32(Console.ReadLine());

if (nombre % 3 == 0)
{
    Console.WriteLine("Le nombre est divisible par 3 ou 5");

} else if ( nombre % 5 == 0)
{
    Console.WriteLine("Le nombre est divisible par 5");
}
else
{
    Console.WriteLine("Le nombre n'est pas divisible par 3 ou 5");
};
*/

//exercice 8. Demander à l'utilisateur un mot de passe et vérifier s'il correspond à "admin".
/*
string mdp = "admin";
Console.WriteLine("Saisissez le mot de passe");
string saisi = Console.ReadLine();

if (mdp != saisi)
{
    Console.WriteLine("Le mot de passe est incorrect");

}
else
{
    Console.WriteLine("Le mot de passe est correct");
}
;*/

// exercice 9 : Créer un programme qui vérifie si une lettre est une voyelle ou une consonne.

/*string lettre;
Console.WriteLine("Saisissez une lettre");
lettre = Console.ReadLine();

switch (lettre)
{
    case "a":
    case "A":
    case "e":
    case "E":
    case "i":
    case "I":
    case "o":
    case "O":
    case "u":
    case "U":
        Console.WriteLine("C'est une voyelle");
        break;
    default:
        Console.WriteLine("C'est une consonne");
        break;
};
*/

// 2. Condition imbriquées : 

// 11.Écrire un programme qui vérifie si un nombre est compris entre 10 et 20.

/*Console.WriteLine("Saisissez un nombre :");
int nombre = Convert.ToInt32(Console.ReadLine());

if (nombre >= 10 && nombre <= 20)
{
    Console.WriteLine("Le nombre est compris entre 10 et 20");
}
else
{
    Console.WriteLine("Le nombre n'est pas compris entre 10 et 20");
}*/


// Exercice 12. Demander à l'utilisateur un âge et afficher s'il est un enfant (moins de 12 ans), un adolescent (entre 12 et 18 ans) ou un adulte (plus de 18 ans).


/*Console.WriteLine("Saisissez votre age :");
int age = Convert.ToInt32(Console.ReadLine());

if (age <= 12)
{
    Console.WriteLine("Vous êtes un enfant");
} else if (age < 18)
{
    Console.WriteLine("Vous êtes un adolescent");
} else
{
    Console.WriteLine("Vous êtes un adulte");
};*/


// Exercice 13. Créer un programme qui vérifie si une année est bissextile ou non.

/*int annee;
Console.WriteLine("Saisissez une année :");
annee = int.Parse(Console.ReadLine());

if (annee % 4 == 0 && annee % 100 != 0 || annee % 400 == 0)
{
    Console.WriteLine("L'année est bissextile");
}
else
{
    Console.WriteLine("L'année n'est pas bissextile");
}*/

// Exercice 14. Vérifier si un nombre est positif et multiple de 5.

/*int nombre;
Console.WriteLine("Saisissez un nombre :");
nombre = int.Parse(Console.ReadLine());

if (nombre % 5 == 0 && nombre > 0)
{
    Console.WriteLine("Le nombre est positif et multiple de 5");
} else
{
    Console.WriteLine("le nombre n'est ni positifi ni un multiple de 5");
};*/

// exercice 15. Écrire un programme qui vérifie si une chaîne de caractères contient la lettre 'a'.

/*string texte;
Console.WriteLine("Saisissez un mot ou une phrase :");
texte = Console.ReadLine();

if (texte.Contains("a"))
{
    Console.WriteLine("Le texte contient la lettre 'a'");
}
else
{
    Console.WriteLine("Le texte ne contient pas la lettre 'a'");
}*/


// exercice 16. Vérifier si un nombre est divisible à la fois par 2 et par 3, mais pas par 9.

/*int nombre;
Console.WriteLine("Saisissez un nombre :");
nombre = int.Parse(Console.ReadLine());

if (nombre % 2 == 0 && nombre % 3 == 0 && nombre % 9 != 0)
{
    Console.WriteLine("le nombre est divisible à la fois par 2 et par 3, mais pas par 9");
} else
{
    Console.WriteLine("le nombre saisi ne rempli pas les conditions");
};
*/

// Exercice 17.  Demander à l'utilisateur un nom d'utilisateur et un mot de passe, et vérifier si les deux sont corrects.
/*String username = "admin";
string password = "1234";

Console.WriteLine("Saisissez votre identifiant");
string saisieUsername = Console.ReadLine();
Console.WriteLine("Saisissez votre mot de passe");
string saisiePassword = Console.ReadLine();

if (saisieUsername == username && saisiePassword == password)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Connexion réussie");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Identifiant ou mot de passe incorrect");
}
Console.ResetColor();*/

// Exercice 18. Écrire un programme qui affiche "Excellent" si la note est supérieure à 85,
// "Bien" si elle est entre 70 et 85,sinon afficher "Peut mieux faire".

// Exercice 19. Créer un programme qui vérifie si une chaîne de caractères est un palindrome.

/*string texte;
Console.WriteLine("Saisissez un mot :");
texte = Console.ReadLine();

char[] caracteres = texte.ToCharArray();
Array.Reverse(caracteres);
string texteInverse = new string(caracteres);

if (texte == texteInverse)
{
    Console.WriteLine($"'{texte}' est un palindrome");
}
else
{
    Console.WriteLine($"'{texte}' n'est pas un palindrome");
};*/

// Exercicie 20. Écrire un programme qui vérifie si un nombre est à la fois positif,
// pair et supérieur à 100.

/*int nombre;
Console.WriteLine("Saisissez un nombre :");
nombre = int.Parse(Console.ReadLine());

if (nombre >= 0)
{
    Console.WriteLine("Le nombre est positif");

    if (nombre % 2 == 0)
    {
        Console.WriteLine("Le nombre est pair");
    }
    else
    {
        Console.WriteLine("Le nombre est impair");
    }

    if (nombre > 100)
    {
        Console.WriteLine("Le nombre est superieur à 100");
    }
    else
    {
        Console.WriteLine("Le nombre est inferieur ou égale à 100");

    }
    ;
};
*/

//exercice 21.  Afficher les nombres de 1 à 10 avec une boucle `for`

/*int nombre;
Console.WriteLine("Saisissez un nombre");
nombre = int.Parse(Console.ReadLine());

for (int i = 1; i <= nombre; i++)
{
    Console.WriteLine(i);
};
*/

//exercice 22. Afficher les nombres pairs entre 1 et 20.

/*int nombre;
Console.WriteLine("Saisissez un nombre");
nombre = int.Parse(Console.ReadLine());

for (int i = 1; i <= nombre; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    };
};*/

// Exercice 23 : Utiliser une boucle pour afficher chaque élément d'un tableau.

/*int[] tableau = new int[] { 1, 2, 3, 4 };

foreach (int n in tableau)
{
    Console.WriteLine(n);
}*/

// Exercice 24 : Demander à l'utilisateur un nombre de 1 à 10 et afficher la table de multiplication

/*int nombre;

Console.WriteLine("Saisissez un nombre entre 1 et 10 : ");
while (!int.TryParse(Console.ReadLine(), out nombre) || nombre < 1 || nombre > 10)
{
    Console.WriteLine("Entrée invalide. Saisissez un nombre entre 1 et 10 :");
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"{i} x {nombre} = {i * nombre}");
}*/


// Exercice 31 . Utiliser une boucle `while` pour afficher les nombres de 1 à 10.

/*int i = 1;
int nombre;
Console.WriteLine("Saisissez un nombre :");
nombre = int.Parse(Console.ReadLine());

while (i <= nombre)
{
    
    Console.WriteLine(i);
    i++; 

};*/


// Exercice 32. Utiliser une boucle `while` pour calculer la somme des nombres de 1 à 100.

/*int i = 1;
int nombre;
Console.WriteLine("Saisissez un nombre :");
nombre = int.Parse(Console.ReadLine());

while (i <= nombre)
{
    int somme = i + i++;
    Console.WriteLine(somme);
};*/

// Exercice 33. Demander à l'utilisateur un nombre et continuer à demander tant que ce nombre est négatif.

/*int nombre;
Console.WriteLine("Saisissez un nombre :");
nombre = int.Parse(Console.ReadLine());

while( nombre < 0)
{

    Console.WriteLine("Saisissez un nombre :");
    nombre = int.Parse(Console.ReadLine());

}
;*/

// Exercice 7 : Jour de la semaine 

/*Console.WriteLine("Entrez un nombre entre 1 et 7");

int jour;
jour = int.Parse(Console.ReadLine());

switch (jour)
{
    case 1: Console.WriteLine("Lundi"); break;
    case 2: Console.WriteLine("Mardi"); break;
    case 3: Console.WriteLine("Mercredi"); break;
    case 4: Console.WriteLine("Jeudi"); break;
    case 5: Console.WriteLine("Vendredi"); break;
    case 6: Console.WriteLine("Samedi"); break;
    case 7: Console.WriteLine("Dimanche"); break;
    default: Console.WriteLine("Jour inconnu"); break;

}
;*/

// Exercice 51. Écrire un programme qui affiche la table de multiplication de 1 à 10 avec des boucles imbriquées.

/*double multiplication;

for (int nombre = 0; nombre <= 10; nombre++)
{
    Console.WriteLine($"Table de {nombre} :");

    for (int i = 0; i <= 9; i++)
    {
        multiplication = nombre * i;

        Console.WriteLine($"{i} x {nombre} = {i * nombre}");

    }
}*/


// Exercice 52. Créer un programme qui affiche un rectangle de caractères "X" de taille donnée par l'utilisateur. Exemple, 4 donne : XXXX XXXX XXXX XXXX

/*int taille;
Console.Write("Saisissez la taille du rectangle : ");
int.TryParse(Console.ReadLine(), out taille);

for (int i = 1; i <= taille; i++)
{
    Console.WriteLine();

    for ( i = 1; i <= taille; i++)
    {
        Console.WriteLine(new String('X', taille));
    }
}
*/

// Exercice 53. Utiliser des boucles imbriquées pour afficher une pyramide de nombres.

string line = "";
string pyramide = "";
int number = 1;
string userInput = "";
int userInputInInt = 0;

do
{
    Console.Write("Saisisser la taille de la pyramide : ");
    userInput = Console.ReadLine();
} while (!int.TryParse(userInput, out userInputInInt));

for (int i = 0; i < userInputInInt; i++)
{
    for (int j = 0; j < i; j++)
    {
        line += $"{number} ";
        number++;
    }
    pyramide += $"{line}\n";
    line = "";
}

Console.WriteLine(pyramide);



// Exercice cours  Les Collections en C# : 

// Execice 1 : tableau

/*using System.ComponentModel.Design;

int[] notes = {  };
double somme = 0;

if (notes.Length > 0)
{

    for (int i = 0; i < notes.Length; i++)
    {
        somme = somme + notes[i];
        Console.WriteLine(somme);
        double moyenne = somme / notes.Length;
        Console.WriteLine(moyenne);

    }
} else
{

    Console.WriteLine("Erreur le tabeau des notes est vide ! Veuillez siaisr des notes");
}
*/



// exercice 2 : 

/*int[] notes = { 10, 20 };

Console.WriteLine($"la valeur maximale : {notes.Max()}\n" +
                  $"la valeur minimal : {notes.Min()}\n" +
                  $"la moyenne : {notes.Average()}\n" );*/



// exercice 3 : 


/*List<string> prenom = new List<string>();

Console.Write("Saisissez le nombre de prénom : ");
int nPrenom = Convert.ToInt32(Console.Read());

Console.WriteLine("Saisissez les prénoms :");
for (int i = 0; i < nPrenom; i++)
{
    prenom.Add(Console.ReadLine());
}
*/

//exercice 4 :

/*int choix;
string pays;
string capitale;
string paysSaisie;
Dictionary<string, string> paysCapitales = new Dictionary<string, string>();

do
{
    Console.Clear();
    Console.WriteLine("---   DICTIONNAIRE COUPLE PAYS / CAPITAL   ---");
    Console.WriteLine("1. Saisir les coupe Pays / Capitale");
    Console.WriteLine("2. Rechercher une Capitale");
    Console.WriteLine("3. Quitter le programme");
    Console.Write("Faites votre choix : ");

    if (!int.TryParse(Console.ReadLine(), out choix))
    {
        Console.WriteLine("Choix invalide ! Veuillez saisir un chiffre entre 1 et 4");
        Console.ReadKey();
        continue;
    }


    switch (choix)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("1. Saisir les couples Pays / Capitale");
            do
            {
                Console.WriteLine("Saisissez le nom du Pays : ");
                pays = Console.ReadLine();

                Console.WriteLine("Saisissez le nom de la capitale : ");
                capitale = Console.ReadLine();

                paysCapitales.Add(pays, capitale);
                Console.WriteLine($"Ajouté : {pays} => {capitale}");

            } while (pays != "fin");

            break;


        case 2:
            Console.Clear();
            Console.WriteLine("2. Rechercher une Capitale");
            paysSaisie = Console.ReadLine();

            if (paysCapitales.ContainsKey(paysSaisie))
            {
                Console.WriteLine($" La capital de {paysSaisie} est : {paysCapitales[paysSaisie]}");
            }
            Console.ReadKey();

            break;


        case 3:
            Console.Clear();
            Console.WriteLine("Au revoir !");
            Environment.Exit(0);
            break;




        default:
            Console.Clear();
            Console.WriteLine("Choix invalide ! Veuillez saisir ent 1 et  3");
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();

            break;
    }

} while (choix != 0);*/


// Exercice 5 : Parcours de collections variées

/*using System.Text;

int[] nombres = new int[5];
int compteurElement = 0;
List<string> prenoms = new List<string> { "Bob", "Cedric", "Lucas", "Loic" };
Dictionary<string, string> paysCapitales = new Dictionary<string, string>
{
    ["France"] = "Paris",
    ["Espagne"] = "Madrid",
    ["Belgique"] = "Bruxelles"
};

foreach (int n in nombres)
{
    compteurElement++;
    Console.Write($" {n}");
}
;

Console.WriteLine();

int compteurPrenom = 0;
foreach (string prenom in prenoms)
{
    compteurElement++;
    compteurPrenom++;
    Console.WriteLine($"{compteurPrenom} : {prenom}");
}
;

Console.WriteLine();

foreach (var pair in paysCapitales)
{
    compteurElement++;
    Console.WriteLine($"{pair.Key} : {pair.Value}");

}
;

Console.WriteLine();
Console.WriteLine($"Le nombre total d’éléments parcourus : {compteurElement}");
*/


// exercicie 1 : Fonction 
/*void AfficherSeparateur()
{
    Console.WriteLine(new String ('-', 30));
}

AfficherSeparateur();
*/

// Exericice 2 : Fonction avec paramètres et retour

//1.
/*int Additionner(int a, int b)
{
    int somme = a + b;
    return somme ; 
}

Console.WriteLine(Additionner(5, 5));*/

//2.

/*bool  EstPair(int nombre)
{
    if (nombre % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
};

Console.WriteLine(EstPair(8));*/

//3.
/*double CalculerPrixTTC(double prixHT, double tauxTVA = 0.20)
{
   double prixTTC = prixHT + (tauxTVA * prixHT);
   return prixTTC;

}
Console.WriteLine(CalculerPrixTTC(10));*/

//Exericice 3 : Utiliser la surcharge de fonctions
/*class Program
{
    static int Multiplier(int a, int b)
    {
        return a * b;
    }

    static int Multiplier(int a, int b, int c)
    {
        return a * b * c;
    }

    static int Multiplier(int[] tableau)
    {
        int resultat = 1; 

        foreach(int n in tableau)
        {
            resultat = n * resultat;
        }

        return resultat;
    }

    static void Main(string[] args)
    {

        Console.WriteLine(Multiplier(5, 5));
        Console.WriteLine(Multiplier(2, 3, 4));
        int[] tableau = new int[] { 2, 3, 4, 5 };
        Console.WriteLine(Multiplier(tableau));

    }
}*/

// Exercice 5 : Static ou instance ?

/*class Program
{
    static void BonjourGlobal()
    {
        Console.WriteLine ("Bonjour tout le monde");
    }

    void BonjourPersonnalise(string prenom)
    {
        Console.WriteLine($"Bonjour {prenom}");
    }


    static void Main(string[] args)
    {
        BonjourGlobal();
        Program program = new Program();
        program.BonjourPersonnalise("Abdell") ;

    }
}*/


// Exercice 6 : Fonctions locales en pratique

/*class Program
{
    static void AnalyseNombre(int[] tableau)
    {
        bool EstPair(int x)
        {
            return x % 2 == 0;
         
        }

        foreach (int n in tableau)
        {
            if (EstPair(n))
            {
                Console.WriteLine($"{n} est pair");
            } else
            {
                Console.WriteLine($"{n} est impair");
            }
        }

    }
    static void Main(string[] args)
    {
        int[] tableauOriginal = new int[] { 2, 3, 4, 5 };
       AnalyseNombre(tableauOriginal);
    }
}
*/

// Exercice 7 : Découverte des lambdas

// 1.
/*class Program
{
    static void Main(string[] args)
    {
        Func<int, int> triple = x => x * 3;
        Console.WriteLine(triple(10));
    }


}*/

//2. 
/*class Program
{
    static void Main(string[] args)
    {

        List<int> nombre = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        nombre.RemoveAll(x => x % 2 != 0);

        Console.WriteLine(string.Join(", ", nombre));


    }


}*/

//Exercice 9.2 : Exercice pratique de synthèse

/*class NotesUtil
{
    static double CalculerMoyenne(double totalPoints, int nombreNotes)
    {
        return totalPoints / nombreNotes;
    }

    static double CalculerMoyenne(int[] notes)
    {
        double total = 0;
        foreach (int n in notes)
        {
            total += n;
        }

        return total / notes.Length;
    }

    string AfficherStats(int[] notes)
    {

        Console.WriteLine("\n--- Statistiques ---");
        return ($"Valeur Max: {notes.Max()}\n" +
                $"Valeur Min: {notes.Min()}\n" +
                $"Valeur Moy: {notes.Average()}\n");
    }

    static void Main(string[] args)
    {
        *//*int[] notes = new int[] { 10, 20 };
        double moyenne = CalculerMoyenne(notes);
        Console.WriteLine($"Moyenne : {moyenne}");*//*

        int nombre;
        Console.WriteLine("Saisissez le nombre notes : ");
        nombre = int.Parse(Console.ReadLine());
        int[] notesSaisies = new int[nombre];

        for (int i = 0; i < nombre; i++)
        {
            Console.WriteLine($"Saisissez la note {i + 1}: ");
            notesSaisies[i] = int.Parse(Console.ReadLine());

        }
        double moyenne = CalculerMoyenne(notesSaisies);
        Console.WriteLine($"Moyenne : {moyenne:F2}");

        NotesUtil statistiques = new NotesUtil();
        Console.WriteLine(statistiques.AfficherStats(notesSaisies));

    }

}*/

