package GRASP.expert_information;

import java.util.ArrayList;
import java.util.List;

public class Instructor extends User {

    private String idInstructeur; // Unique identifier for the instructor
    private List<Path> parcoursAffecte; // List of assigned courses
    private List<Evaluation> evaluations; // List of evaluations created

    public Instructor(String nom, String prenom, String email, String idInstructeur) {
        super(); // Call parent constructor
        this.idInstructeur = idInstructeur;
        this.parcoursAffecte = new ArrayList<>();
        this.evaluations = new ArrayList<>();
    }

    // Getters and setters for instructor-specific attributes
    public String getIdInstructeur() {
        return idInstructeur;
    }

    public void setIdInstructeur(String idInstructeur) {
        this.idInstructeur = idInstructeur;
    }

    public List<Path> getParcoursAffecte() {
        return parcoursAffecte;
    }

    public void addParcoursAffecte(Path parcours) {
        parcoursAffecte.add(parcours);
    }

    public void removeParcoursAffecte(Path parcours) {
        parcoursAffecte.remove(parcours);
    }

    public List<Evaluation> getEvaluations() {
        return evaluations;
    }

    public void addEvaluation(Evaluation evaluation) {
        evaluations.add(evaluation);
    }

    // Method to create an evaluation for a student in a specific course
    public Evaluation creerEvaluation(String idEtudiant, Path parcours) {
        Evaluation evaluation = new Evaluation();
        evaluations.add(evaluation);
        return evaluation;
    }

    // Method to get an evaluation for a specific student in a course
    public Evaluation getEvaluation(String idEtudiant, Path parcours) {
        for (Evaluation evaluation : evaluations) {
            if (evaluation.getIdEtudiant().equals(idEtudiant) && evaluation.getParcours().equals(parcours)) {
                return evaluation;
            }
        }
        return null; // Evaluation not found
    }

    public void affecterParcours(Path parcours) {
        // TODO Auto-generated method stub
        throw new UnsupportedOperationException("Unimplemented method 'affecterParcours'");
    }

    public String getId() {
        // TODO Auto-generated method stub
        throw new UnsupportedOperationException("Unimplemented method 'getId'");
    }

}
