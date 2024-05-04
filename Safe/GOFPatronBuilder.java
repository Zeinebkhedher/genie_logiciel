// Interface Builder
interface QuizResponseBuilder {
    void buildUser(User user);
    void buildQuiz(Quiz quiz);
    void buildSpecialQuiz(SpecialQuiz specialQuiz);
    void buildContent(Content content);
    QuizResponse getQuizResponse();
}

// Classes Builder
class UserBuilder implements QuizResponseBuilder {
    // ... méthodes pour construire l'utilisateur

    @Override
    public QuizResponse getQuizResponse() {
        // Assembler les parties construites et créer l'objet QuizResponse
        return new QuizResponse(user, quiz, specialQuiz, content);
    }
}

class QuizBuilder implements QuizResponseBuilder {
    // ... méthodes pour construire le quiz
}

class SpecialQuizBuilder implements QuizResponseBuilder {
    // ... méthodes pour construire le quiz spécial
}

class ContentBuilder implements QuizResponseBuilder {
    // ... méthodes pour construire le contenu
}

// Classe Directeur (optionnel)
class QuizResponseDirector {
    private QuizResponseBuilder builder;

    public QuizResponseDirector(QuizResponseBuilder builder) {
        this.builder = builder;