package GRASP.expert_information;

public class Etudiant {

    private String nom;
    private String dateNaissance;

    // ... autres attributs et méthodes liés à l'étudiant

    public Etudiant(String nom, String dateNaissance) {
        this.nom = nom;
        this.dateNaissance = dateNaissance;
    }

    public String getNom() {
        return nom;
    }

    public String getDateNaissance() {
        return dateNaissance;
    }

    // ... autres méthodes liées à l'étudiant
}
