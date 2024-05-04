class ProjectCreatorImpl implements ProjectCreator {

    @Override
    public Project createProject(String title, String description, User creator) {
        Project project = new Project();
        project.setTitle(title);
        project.setDescription(description);
        project.setCreator(creator);
        return project;
    }
}

class ChallengeCreatorImpl implements ChallengeCreator {

    @Override
    public Challenge createChallenge(String name, String description, int points) {
        Challenge challenge = new Challenge();
        challenge.setName(name);
        challenge.setDescription(description);
        challenge.setPoints(points);
        return challenge;
    }
}
