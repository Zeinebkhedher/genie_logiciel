ProjectCreator projectCreator = new ProjectCreatorImpl();
Project project = projectCreator.createProject("My Project", "Description of my project", new User("John Doe"));

ChallengeCreator challengeCreator = new ChallengeCreatorImpl();
Challenge challenge = challengeCreator.createChallenge("Coding Challenge", "Solve this coding problem", 100);