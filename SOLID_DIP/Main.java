import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        IPath path = new Path("1", "Path Label", "Path Description");
        IChallenge challenge = new Challenge("1", "Challenge Description", "http://content.link", "http://assets.link", "http://cover.picture.link", Arrays.asList("tag1", "tag2"), 100);
        
        ContentCreator contentCreator = new ContentCreator(path, challenge);
        contentCreator.manageContent();
        
        // Example of creating and updating a path
        Path newPath = path.createPath(new Path("2", "New Path", "New Description"));
        Path updatedPath = path.updatePath("2");
        
        // Accessing challenge details
        String challengeId = challenge.getId();
        String challengeDescription = challenge.getDescription();
    }
}
