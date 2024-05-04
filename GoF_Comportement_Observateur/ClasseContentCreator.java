import java.util.ArrayList;
import java.util.List;

class ContentCreator implements Observer {
    private int id;
    private String name;
    private List<Quiz> createdQuizzes;
    private List<Quiz> subscribedQuizzes;

    public ContentCreator(int id, String name) {
        this.id = id;
        this.name = name;
        this.createdQuizzes = new ArrayList<>();
        this.subscribedQuizzes = new ArrayList<>();
    }

    @Override
    public void update(Quiz quiz) {
        // Met à jour l'interface utilisateur du créateur de contenu en fonction des informations du quiz
    }

    public void addQuiz(Quiz quiz) {
        createdQuizzes.add(quiz);
    }

    public void subscribe(Quiz quiz) {
        quiz.subscribe(this);
        subscribedQuizzes.add(quiz);
    }

    public void unsubscribe(Quiz quiz) {
        quiz.unsubscribe(this);
        subscribedQuizzes.remove(quiz);
    }
}
