package SOLID;

import GRASP.expert_information.Etudiant;
import GRASP.expert_information.Path;

public class ResultatEvaluationEtudiant {

    private Etudiant etudiant;
    private Path parcours;
    private int scoreObtenu;
    private String dateEvaluation;

    public ResultatEvaluationEtudiant(Etudiant etudiant, Parcours parcours, int scoreObtenu, String dateEvaluation) {
        this.etudiant = etudiant;
        this.parcours = parcours;
        this.scoreObtenu = scoreObtenu;
        this.dateEvaluation = dateEvaluation;
    }

    public Etudiant getEtudiant() {
        return etudiant;
    }

    public Path getParcours() {
        return parcours;
    }

    public int getScoreObtenu() {
        return scoreObtenu;
    }

    public String getDateEvaluation() {
        return dateEvaluation;
    }
}
