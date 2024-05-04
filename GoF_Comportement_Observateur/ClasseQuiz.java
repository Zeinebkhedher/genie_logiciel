import java.util.ArrayList;
import java.util.List;

class Quiz {
    private int id;
    private String title;
    private String description;
    private List<Question> questions;
    private List<Response> responses;
    private List<Observer> subscribers;

    public Quiz(int id, String title, String description) {
        this.id = id;
        this.title = title;
        this.description = description;
        this.questions = new ArrayList<>();
        this.responses = new ArrayList<>();
        this.subscribers = new ArrayList<>();
    }

    public void subscribe(Observer subscriber) {
        subscribers.add(subscriber);
    }

    public void unsubscribe(Observer subscriber) {
        subscribers.remove(subscriber);
    }

    public void notifySubscribers() {
        for (Observer subscriber : subscribers) {
            subscriber.update(this);
        }
    }

    public void addQuestion(Question question) {
        questions.add(question);
        notifySubscribers();
    }

    public void removeQuestion(Question question) {
        questions.remove(question);
        notifySubscribers();
    }

    public void addResponse(Response response) {
        responses.add(response);
        notifySubscribers();
    }

    public void removeResponse(Response response) {
        responses.remove(response);
        notifySubscribers();
    }
}
