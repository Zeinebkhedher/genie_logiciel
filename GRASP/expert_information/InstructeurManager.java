package GRASP.expert_information;

import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class InstructeurManager {

    private Map<String, Instructor> instructeurs; // Map of instructors by their ID

    public InstructeurManager() {
        this.instructeurs = new HashMap<>();
    }

    public Instructor getInstructeur(String id) {
        return instructeurs.get(id);
    }

    public void addInstructeur(Instructor instructeur) {
        instructeurs.put(instructeur.getId(), instructeur);
    }

    public void updateInstructeur(Instructor instructeur) {
        instructeurs.put(instructeur.getId(), instructeur);
    }

    public void removeInstructeur(String id) {
        instructeurs.remove(id);
    }

    public List<Path> getParcoursAffecteInstructeur(String id) {
        Instructor instructeur = getInstructeur(id);
        if (instructeur != null) {
            return instructeur.getParcoursAffecte();
        } else {
            throw new IllegalArgumentException("Instructeur with ID " + id + " not found.");
        }
    }

    public void affecterParcoursInstructeur(String id, Path parcours) {
        Instructor instructeur = getInstructeur(id);
        if (instructeur != null) {
            instructeur.affecterParcours(parcours);
        } else {
            throw new IllegalArgumentException("Instructeur with ID " + id + " not found.");
        }
    }

    public Evaluation getEvaluationInstructeur(String id, String idEtudiant, Path parcours) {
        Instructor instructeur = getInstructeur(id);
        if (instructeur != null) {
            return instructeur.getEvaluation(idEtudiant, parcours);
        } else {
            throw new IllegalArgumentException("Instructeur with ID " + id + " not found.");
        }
    }

    /*
     * public void affecterParcoursInstructeur(String id, Path parcours) {
     * Instructor instructeur = getInstructeur(id);
     * if (instructeur != null) {
     * instructeur.addParcoursAffecte(parcours); // Use addParcoursAffecte instead
     * of affecterParcours
     * } else {
     * throw new IllegalArgumentException("Instructeur with ID " + id +
     * " not found.");
     * }
     * }
     */

    /*
     * public Evaluation getEvaluationInstructeur(String id, String idEtudiant, Path
     * parcours) {
     * Instructor instructeur = getInstructeur(id);
     * if (instructeur != null) {
     * return instructeur.getEvaluation(idEtudiant, parcours);
     * } else {
     * throw new IllegalArgumentException("Instructeur with ID " + id +
     * " not found.");
     * }
     * }
     */
}
