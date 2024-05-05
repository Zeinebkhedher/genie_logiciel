package GOF.patron_structure.composite;

import java.util.ArrayList;
import java.util.List;

public class Node extends Skill implements ElementParcours {

    private List<Node> children; // List of child nodes

    public Node(String id, String label, String description, String contentLink, String assetsLink,
            String coverPictureLink, List<String> tags, int requiredScore) {
        super(id, label, description, contentLink, assetsLink, coverPictureLink, tags, requiredScore); // Call parent
                                                                                                       // constructor
        this.children = new ArrayList<>();
    }

    // Getters and setters for the children list
    public List<Node> getChildren() {
        return children;
    }

    public void addChild(Node child) {
        this.children.add(child);
    }

    // Override ElementParcours methods (implement logic specific to Node)
    @Override
    public int getPosx() {
        // Implement logic to retrieve horizontal position of the node
        return 0;
    }

    @Override
    public void setPosx(int posx) {
        // Implement logic to set horizontal position of the node
        // ...
    }

    @Override
    public int getPosy() {
        // Implement logic to retrieve vertical position of the node
        return 0;
    }

    @Override
    public void setPosy(int posy) {
        // Implement logic to set vertical position of the node
        // ...
    }

    @Override
    public int getScore() {
        // Implement logic to retrieve score of the node (consider child scores)
        int totalScore = 0;
        for (Node child : children) {
            totalScore += child.getScore();
        }
        return totalScore;
    }

    @Override
    public void setScore(int score) {
        // Setting score directly on a Node might not be relevant
        throw new UnsupportedOperationException(
                "Setting score directly on a Node is not supported. Consider setting scores on child Competences.");
    }
}
