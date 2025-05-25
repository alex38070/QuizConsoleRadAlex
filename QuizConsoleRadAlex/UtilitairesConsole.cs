namespace QuizConsoleRadAlex;

internal class UtilitairesConsole
{
    public static string PoserChoix(string libelle, IEnumerable<string> choix)
    {
        Console.WriteLine(libelle);

        int index = 0;
        foreach (string option in choix)
            Console.WriteLine($"{++index}. {option}");

        int reponseUtilisateur = PoserEntier(1, choix.Count());

        return choix.ElementAt(reponseUtilisateur - 1);
    }

    private static int PoserEntier(int min, int max)
    {
        while (true)
        {
            Console.Write($"Veuillez entrer un nombre entre {min} et {max} : ");
            string saisie = Console.ReadLine() ?? string.Empty;

            // Il faut que la saisie soit un chiffre comprit entre min et max!
            bool estValide = (int.TryParse(saisie, out int choix) && choix >= min && choix <= max);

            if(estValide)
                return choix;
        }
    }
}