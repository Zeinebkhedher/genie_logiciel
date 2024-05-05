import java.util.ArrayList;
import java.util.List;

public class Quiz {
    private int idQuiz;
    private String titre;
    private String description;
    private List<Question> listeQuestions;
    private List<Reponse> listeReponsesUtilisateur;

    public Quiz() {
        this.listeQuestions = new ArrayList<>();
        this.listeReponsesUtilisateur = new ArrayList<>();
    }

    public int getIdQuiz() {
        return idQuiz;
    }

    public void setIdQuiz(int idQuiz) {
        this.idQuiz = idQuiz;
    }

    public String getTitre() {
        return titre;
    }

    public void setTitre(String titre) {
        this.titre = titre;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public int creerQuiz(String titre, String description) {
        this.titre = titre;
        this.description = description;
        // Code pour générer un identifiant unique pour le quiz
        this.idQuiz = generateUniqueId();
        return this.idQuiz;
    }

    public void ajouterQuestion(Question question) {
        listeQuestions.add(question);
    }

    public void supprimerQuestion(Question question) {
        listeQuestions.remove(question);
    }

    public void passerQuiz(Utilisateur utilisateur) {
        // Logique pour passer le quiz pour un utilisateur donné
    }

    public double calculerScore(List<Reponse> reponses) {
        // Logique pour calculer le score du quiz en fonction des réponses
        return 0.0; // Placeholder, à remplacer par la logique appropriée
    }

    public List<Question> getQuestions() {
        return listeQuestions;
    }

    public List<Reponse> getReponsesUtilisateur() {
        return listeReponsesUtilisateur;
    }

    private int generateUniqueId() {
        // Logique pour générer un identifiant unique
        return 0; // Placeholder, à remplacer par la logique appropriée
    }
}
