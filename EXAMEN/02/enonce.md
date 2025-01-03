# Système de Journalisation Centralisée

Une entreprise développe un système de journalisation pour suivre les événements critiques de son infrastructure. Ce système doit :

- Garantir que tous les logs sont écrits dans le même fichier
- Éviter les conflits d'accès concurrent
- Maintenir une seule connexion à la base de données
- Fournir un point d'accès global à tous les composants

Voici l'implémentation actuelle qui pose problème :

```c#

public class SystemLogger
{
    private string connectionString;
    private StreamWriter logFile;

    public SystemLogger()
    {
        connectionString = "Server=localhost;Database=Logs;";
        logFile = new StreamWriter("system_logs.txt", true);
    }

    public void Log(string message)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        logFile.WriteLine($"[{timestamp}] {message}");
        logFile.Flush();
    }

    public void LogToDatabase(string message)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            // Code pour logger dans la base de données
        }
    }
}

// Exemple d'utilisation
public class UserService
{
    private SystemLogger logger;

    public UserService()
    {
        logger = new SystemLogger();
    }

    public void CreateUser(string username)
    {
        // Création utilisateur
        logger.Log($"Nouvel utilisateur créé : {username}");
    }
}

public class SecurityService
{
    private SystemLogger logger;

    public SecurityService()
    {
        logger = new SystemLogger();
    }

    public void DetectIntrusion(string ip)
    {
        logger.Log($"Intrusion détectée depuis : {ip}");
        logger.LogToDatabase($"ALERT: Intrusion depuis {ip}");
    }
}
```
