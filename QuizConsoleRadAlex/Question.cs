namespace QuizConsoleRadAlex;

public class Question(string enonce, IEnumerable<string> options, string bonneReponse)
{
    public string Enonce { get; set; } = enonce;
    public IEnumerable<string> Options { get; set; } = options;
    public string BonneReponse { get; set; } = bonneReponse;

    public bool PoserAUtilisateur()
    {
        string reponse = UtilitairesConsole.PoserChoix(Enonce, Options);
        return EstBonneReponse(reponse);
    }

    private bool EstBonneReponse(string reponse) 
    {
        //return BonneReponse == reponse; // mieux avec string.Equals()
        return string.Equals(reponse, BonneReponse, StringComparison.OrdinalIgnoreCase);
    }
}
