/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/

/* exercice 1 :  Écrire un programme qui vérifie si un nombre donné est supérieur à 10.



Console.WriteLine("Saisissez un nombre : ");
int nombre = Convert.ToInt32(Console.ReadLine());


if (nombre < 10)
{
    Console.WriteLine("Le nombre est inférieur à 10");
}

else
{
    Console.WriteLine("a est supérieur à 10");
}

*/

// exercicie 2 :  Vérifier si un nombre donné est positif, négatif ou nul.



Console.WriteLine("Saisissez un nombre : ");
int nombre = Convert.ToInt32(Console.ReadLine());

if (nombre < 0)
{
    Console.WriteLine("Le nombre est négatif");
}
else if (nombre > 0)
{
    Console.WriteLine("Le nombre est positif");
}
else
{
    Console.WriteLine("Le nombre est nul");
}








