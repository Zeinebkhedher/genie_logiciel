import java.util.List;

public class Question {
    private int idQuestion;
    private String enonce;
    private List<Reponse> listeReponsesPossibles;
    private int reponseCorrecte;

    public int getIdQuestion() {
        return idQuestion;
    }

    public void setIdQuestion(int idQuestion) {
        this.idQuestion = idQuestion;
    }

    public String getEnonce() {
        return enonce;
    }

    public void setEnonce(String enonce) {
        this.enonce = enonce;
    }

    public List<Reponse> getReponsesPossibles() {
        return listeReponsesPossibles;
    }

    public void setReponsesPossibles(List<Reponse> listeReponsesPossibles) {
        this.listeReponsesPossibles = listeReponsesPossibles;
    }

    public int getReponseCorrecte() {
        return reponseCorrecte;
    }

    public void setReponseCorrecte(int reponseCorrecte) {
        this.reponseCorrecte = reponseCorrecte;
    }
}
