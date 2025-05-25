namespace QuizConsoleRadAlex;

internal class Jeu
{
    public void Jouer()
    {
        do
        {
            LancerSession();
        } while (UtilitairesConsole.PoserChoix("Souhaitez-vous rejouer ?", ["Oui", "Non"]) == "Oui");
    }

    private void LancerSession()
    {
        Theme themeChoisi = Theme.DemanderAUtilisateur();

        int score = 0;
        int numerodeQuestion = 1;

        foreach (Question question in themeChoisi.Questions)
        {
            Console.WriteLine($"Question n°{numerodeQuestion++}");

            if (question.PoserAUtilisateur())
            {
                Console.WriteLine("Bonne réponse !");
                score++;
            }
            else
            {
                Console.WriteLine($"Mauvaise réponse ! La bonne réponse était : {question.BonneReponse}");
            }

            Console.WriteLine();
        }
        Console.WriteLine($"Votre score final : {score}");
    }
}
