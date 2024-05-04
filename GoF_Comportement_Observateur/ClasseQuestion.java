import java.util.ArrayList;
import java.util.List;

class Question {
    private int id;
    private String text;
    private String type;
    private List<Answer> answers;
    private String correctAnswer; // Identifiant de la réponse correcte (pour les questions à choix unique)

    public Question(int id, String text, String type) {
        this.id = id;
        this.text = text;
        this.type = type;
        this.answers = new ArrayList<>();
    }

    public void addAnswer(Answer answer) {
        answers.add(answer);
    }

    public void removeAnswer(Answer answer) {
        answers.remove(answer);
    }

    public String getCorrectAnswer() {
        return correctAnswer;
    }

    public void markAnswerAsCorrect(String answerId) {
        correctAnswer = answerId;
    }

    public void unmarkAnswerAsCorrect() {
        correctAnswer = null;
    }
}
