﻿// 1.Conditions simples


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

// Exercice 22.  Utiliser une boucle pour afficher chaque élément d'un tableau.

/*int [];

for (i = 0; i  */


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











