namespace QuizConsoleRadAlex;

public class Theme(string nom, IEnumerable<Question> questions)
{
    public string Nom { get; set; } = nom;
    public IEnumerable<Question> Questions { get; set; } = questions;

    public static Theme DemanderAUtilisateur()
    {
        string choixUtilisateur = UtilitairesConsole.PoserChoix("Veuillez choisir un thème", _themes.Select(t => t.Nom));

        return _themes.First(t => t.Nom == choixUtilisateur);
    }

    private static readonly IEnumerable<Theme> _themes = [
        new Theme("Mécanique automobile", [
            new Question("Quel est le rôle exact du volant moteur dans un moteur thermique ?",
                [
                    "Il permet de faire varier la puissance envoyée aux roues",
                    "Il sert à démarrer le moteur en lançant le vilebrequin",
                    "Il stocke de l’énergie cinétique pour réguler les variations de régime moteur"
                ],
                "Il stocke de l’énergie cinétique pour réguler les variations de régime moteur"),

            new Question("Lors d’une vidange, pourquoi change-t-on également le filtre à huile ?",
                [
                    "Parce qu’il empêche l’huile de devenir trop visqueuse",
                    "Parce qu’il retient les impuretés qui pourraient circuler avec la nouvelle huile",
                    "Parce qu’il améliore la combustion dans les cylindres"
                ],
                "Parce qu’il retient les impuretés qui pourraient circuler avec la nouvelle huile"),

            new Question("Quelle anomalie pourrait entraîner une surconsommation de carburant ?",
                [
                    "Une courroie d’accessoire trop tendue",
                    "Un filtre à air légèrement encrassé",
                    "Un liquide de refroidissement trop ancien"
                ],
                "Un filtre à air légèrement encrassé"),

            new Question("Quelle est la particularité d’un moteur à injection directe par rapport à un moteur à injection indirecte ?",
                [
                    "L’injection se fait dans le collecteur d’admission",
                    "L’injection se fait directement dans la chambre de combustion",
                    "L’injection est contrôlée mécaniquement"
                ],
                "L’injection se fait directement dans la chambre de combustion"),

            //new Question("Un disque de frein voilé provoquera principalement :",
            //    [
            //        "Une perte totale de freinage",
            //        "Une usure prématurée des pneus",
            //        "Des vibrations lors des freinages"
            //    ],
            //    "Des vibrations lors des freinages"),

            //new Question("Pourquoi le calage de distribution est-il crucial ?",
            //    [
            //        "Parce qu’il synchronise l’ouverture des soupapes et la position des pistons",
            //        "Parce qu’il régule la pression dans le système de freinage",
            //        "Parce qu’il équilibre les masses en rotation dans le moteur"
            //    ],
            //    "Parce qu’il synchronise l’ouverture des soupapes et la position des pistons"),

            //new Question("Un cliquetis métallique dans le moteur peut indiquer :",
            //    [
            //        "Une huile trop fluide ou un manque de lubrification",
            //        "Une bougie de préchauffage défaillante",
            //        "Un turbo en surpression"
            //    ],
            //    "Une huile trop fluide ou un manque de lubrification"),

            //new Question("Quel est l’impact principal d’un mauvais parallélisme ?",
            //    [
            //        "Une perte de puissance moteur",
            //        "Une usure irrégulière des pneus",
            //        "Une surchauffe du liquide de frein"
            //    ],
            //    "Une usure irrégulière des pneus"),

            //new Question("Une sonde lambda défaillante peut engendrer :",
            //    [
            //        "Une panne de direction assistée",
            //        "Une mauvaise régulation du mélange air/carburant",
            //        "Un grincement à l’arrière du véhicule"
            //    ],
            //    "Une mauvaise régulation du mélange air/carburant"),

            new Question("Que mesure un débitmètre d’air (MAF) ?",
                [
                    "La quantité d’air entrant dans le moteur",
                    "La température des gaz d’échappement",
                    "La pression dans les cylindres"
                ],
                "La quantité d’air entrant dans le moteur")
        ]),

        new Theme("Langage C#", [
            new Question("À quoi sert 'abstract' ?",
                [
                    "Il définit une classe abstraite.",
                    "Il définit une interface.",
                    "Il gère le garbage collector."
                ],
                "Il définit une classe abstraite."),

            new Question("À quoi sert 'async' ?",
                [
                    "Il permet de déclarer une méthode asynchrone.",
                    "Il définit une interface.",
                    "Il gère le garbage collector."
                ],
                "Il permet de déclarer une méthode asynchrone."),

            new Question("Quelle est l'utilisation de 'await' ?",
                [
                    "Il contrôle la mémoire.",
                    "Il attend la fin d'une tâche asynchrone.",
                    "Il fait une conversion implicite."
                ],
                "Il attend la fin d'une tâche asynchrone."),

            new Question("Que fait 'sealed' en C# ?",
                [
                    "Il crée un objet.",
                    "Il empêche l'héritage d'une classe.",
                    "Il surcharge un opérateur."
                ],
                "Il empêche l'héritage d'une classe."),

            //new Question("Que fait 'override' en C# ?",
            //    [
            //        "Il crée un objet.",
            //        "Il redéfinit une méthode virtuelle.",
            //        "Il surcharge un opérateur."
            //    ],
            //    "Il redéfinit une méthode virtuelle."),

            //new Question("À quoi sert 'interface' ?",
            //    [
            //        "Il déclare un contrat sans implémentation.",
            //        "Il définit une interface.",
            //        "Il gère le garbage collector."
            //    ],
            //    "Il déclare un contrat sans implémentation."),

            //new Question("À quoi sert 'static' ?",
            //    [
            //        "Il définit un membre qui appartient à la classe.",
            //        "Il définit une interface.",
            //        "Il gère le garbage collector."
            //    ],
            //    "Il définit un membre qui appartient à la classe."),

            //new Question("Que fait 'readonly' en C# ?",
            //    [
            //        "Il crée un objet.",
            //        "Il empêche la réassignation après initialisation.",
            //        "Il surcharge un opérateur."
            //    ],
            //    "Il empêche la réassignation après initialisation."),

            //new Question("Que fait 'const' en C# ?",
            //    [
            //        "Il crée un objet.",
            //        "Il déclare une constante.",
            //        "Il surcharge un opérateur."
            //    ],
            //    "Il déclare une constante."),

            new Question("Quelle est l'utilisation de 'delegate' ?",
                [
                    "Il contrôle la mémoire.",
                    "Il représente une méthode.",
                    "Il fait une conversion implicite."
                ],
                "Il représente une méthode.")
        ]),

        new Theme("Grands brûlés (infirmière)", [
            new Question("Quelle formule est la plus utilisée pour estimer la surface corporelle brûlée chez un adulte ?",
                [
                    "La règle de Wallace (ou règle des 9)",
                    "L'indice de Silverman",
                    "Le score de Glasgow"
                ],
                "La règle de Wallace (ou règle des 9)"),

            new Question("Quelle est la priorité absolue dans la prise en charge initiale d’un grand brûlé ?",
                [
                    "L’administration d’antibiotiques à large spectre",
                    "L’évaluation de la douleur",
                    "Le maintien de la perméabilité des voies respiratoires"
                ],
                "Le maintien de la perméabilité des voies respiratoires"),

            new Question("Quel signe clinique évoque une inhalation de fumées chez un brûlé ?",
                [
                    "Érythème cutané localisé",
                    "Présence de suie au niveau des narines ou de la bouche",
                    "Tachycardie légère isolée"
                ],
                "Présence de suie au niveau des narines ou de la bouche"),

            new Question("Quelle solution est recommandée pour la réanimation liquidienne des grands brûlés ?",
                [
                    "Solution hypertonique à 7,5%",
                    "Sérum physiologique uniquement",
                    "Formule de Parkland avec du Ringer Lactate"
                ],
                "Formule de Parkland avec du Ringer Lactate"),

            new Question("Quel est le principal risque infectieux au stade secondaire chez un grand brûlé ?",
                [
                    "Septicémie par translocation bactérienne",
                    "Infection urinaire",
                    "Otite moyenne aiguë"
                ],
                "Septicémie par translocation bactérienne")
        ]),

        new Theme("Cardiologie (infirmière)", [
            new Question("Quel est le principal risque d’une fibrillation auriculaire non contrôlée ?",
                [
                    "Embolie pulmonaire",
                    "Thrombose artérielle cérébrale (AVC)",
                    "Hypertension portale"
                ],
                "Thrombose artérielle cérébrale (AVC)"),

            new Question("Quelle est la valeur seuil pour considérer une hypertension artérielle sévère ?",
                [
                    "160/100 mmHg",
                    "140/90 mmHg",
                    "180/110 mmHg"
                ],
                "180/110 mmHg"),

            new Question("Quel est le signe clinique typique d’un œdème aigu du poumon ?",
                [
                    "Polypnée avec râles crépitants bilatéraux",
                    "Fièvre avec douleur thoracique",
                    "Hypotension avec bradycardie"
                ],
                "Polypnée avec râles crépitants bilatéraux"),

            new Question("Pourquoi surveille-t-on strictement la kaliémie chez un patient sous diurétique de l'anse ?",
                [
                    "Pour détecter un risque de bradycardie",
                    "Pour prévenir les troubles du rythme cardiaque",
                    "Pour éviter une hypernatrémie"
                ],
                "Pour prévenir les troubles du rythme cardiaque"),

            new Question("Quel ECG est caractéristique d’un infarctus du myocarde ST+ ?",
                [
                    "Élévation persistante du segment ST",
                    "Onde T inversée isolée",
                    "Allongement de l’espace PR"
                ],
                "Élévation persistante du segment ST")
        ]),

        new Theme("Médecine générale (médecin)", [
            new Question("Quel examen est prioritaire en cas de suspicion de phlébite profonde d’un membre inférieur ?",
                [
                    "Radiographie standard",
                    "Échographie Doppler veineux",
                    "Dosage de la troponine"
                ],
                "Échographie Doppler veineux"),

            new Question("Quelle est la cause la plus fréquente d'hypercalcémie chronique en population générale ?",
                [
                    "Cancer des os",
                    "Hyperparathyroïdie primaire",
                    "Excès de vitamine D"
                ],
                "Hyperparathyroïdie primaire"),

            new Question("Quel antibiotique est contre-indiqué chez la femme enceinte au 1er trimestre ?",
                [
                    "Amoxicilline",
                    "Tétracycline",
                    "Céfixime"
                ],
                "Tétracycline"),

            new Question("Quel test est recommandé en première intention pour une suspicion de diabète de type 2 ?",
                [
                    "Hémoglobine glyquée (HbA1c)",
                    "Insulinémie à jeun",
                    "Glycosurie isolée"
                ],
                "Hémoglobine glyquée (HbA1c)"),

            new Question("Quel est le traitement de première intention pour une hypertension artérielle essentielle chez un adulte de moins de 65 ans ?",
                [
                    "Bêtabloquant",
                    "Inhibiteur de l’enzyme de conversion (IEC)",
                    "Anticoagulant direct oral"
                ],
                "Inhibiteur de l’enzyme de conversion (IEC)")
        ])
    ];
}
