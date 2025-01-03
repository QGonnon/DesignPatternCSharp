IRapport rapport = new RapportIncident(
    "Intrusion détectée",
    "John Doe"
);

// Appliquer les décorateurs
rapport = new RapportAnonyme(rapport);
rapport = new RapportChiffre(rapport);
rapport = new RapportJournalise(rapport);

Console.WriteLine($"Rapport par: {rapport.GetAuteur()}");
Console.WriteLine($"Contenu: {rapport.GetContenu()}");