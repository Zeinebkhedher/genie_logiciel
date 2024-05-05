package GRASP.expert_information;

import java.util.HashMap;
import java.util.Map;

public class EtudiantManager {

    private Map<String, Etudiant> etudiants; // Map of students by their ID

    public EtudiantManager() {
        this.etudiants = new HashMap<>();
    }

    public Etudiant getEtudiant(String id) {
        return etudiants.get(id);
    }

    public void addEtudiant(Etudiant etudiant) {
        etudiants.put(etudiant.getId(), etudiant);
    }

    public void updateEtudiant(Etudiant etudiant) {
        etudiants.put(etudiant.getId(), etudiant);
    }

    public void removeEtudiant(String id) {
        etudiants.remove(id);
    }

    public int getProgressionEtudiant(String id, Parcours parcours) {
        Etudiant etudiant = getEtudiant(id);
        if (etudiant != null) {
            return etudiant.getProgression(parcours);
        } else {
            throw new IllegalArgumentException("Etudiant with ID " + id + " not found.");
        }
    }

    public void updateProgressionEtudiant(String id, Parcours parcours, int niveauProgression) {
        Etudiant etudiant = getEtudiant(id);
        if (etudiant != null) {
            etudiant.mettreAJourProgression(parcours, niveauProgression);
        } else {
            throw new IllegalArgumentException("Etudiant with ID " + id + " not found.");
        }
    }

    public ResultatEvaluationEtudiant getResultatEvaluationEtudiant(String id, Evaluation evaluation) {
        Etudiant etudiant = getEtudiant(id);
        if (etudiant != null) {
            return etudiant.getResultatEvaluation(evaluation);
        } else {
            throw new IllegalArgumentException("Etudiant with ID " + id + " not found.");
        }
    }

    public void addResultatEvaluationEtudiant(String id, Evaluation evaluation, ResultatEvaluation resultat) {
        Etudiant etudiant = getEtudiant(id);
        if (etudiant != null) {
            etudiant.ajouterResultatEvaluation(evaluation, resultat);
        } else {
            throw new IllegalArgumentException("Etudiant with ID " + id + " not found.");
        }
    }
}
