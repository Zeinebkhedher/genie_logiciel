import java.util.ArrayList;
import java.util.List;

class User implements Observer {
    private int id;
    private String name;
    private List<Quiz> subscribedQuizzes;

    public User(int id, String name) {
        this.id = id;
        this.name = name;
        this.subscribedQuizzes = new ArrayList<>();
    }

    @Override
    public void update(Quiz quiz) {
        // Met à jour l'interface utilisateur de l'utilisateur en fonction des informations du quiz
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
