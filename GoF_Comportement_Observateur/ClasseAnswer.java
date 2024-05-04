class Answer {
    private int id;
    private String text;
    private boolean isCorrect; // Indique si la réponse est correcte ou non (pour les questions à choix unique)

    public Answer(int id, String text) {
        this.id = id;
        this.text = text;
    }

    public void markAsCorrect() {
        isCorrect = true;
    }

    public void unmarkAsCorrect() {
        isCorrect = false;
    }
}
