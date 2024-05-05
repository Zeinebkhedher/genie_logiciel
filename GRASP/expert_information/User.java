package GRASP.expert_information;

import java.util.List;

public class User {

    private String id;
    private String email;
    private String password; // This should be hashed in a real application
    private String firstName;
    private String lastName;
    private String birthDate;
    private boolean verified;
    private String status;
    private String profilePicture;

    // Associations
    // private List<QuizResponse> quizResponses;
    private List<Path> pathsCreated;
    private List<Path> pathsManaged;
    // private List<SpecialQuiz> specialQuizzesManaged;

    // Constructors
    // Getters and Setters
    // Methods related to associations (e.g., addQuizResponse, removePath, etc.)

}
