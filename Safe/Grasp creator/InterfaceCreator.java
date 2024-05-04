interface ProjectCreator {
    Project createProject(String title, String description, User creator);
}

interface ChallengeCreator {
    Challenge createChallenge(String name, String description, int points);
}

interface ContentCreator {
    Content createContent(String title, String body);
}

interface CheckpointCreator {
    Checkpoint createCheckpoint(String name, String description, Date deadline);
}

interface AssessmentCreator {
    Assessment createAssessment(String title, String description, List<Question> questions);
}