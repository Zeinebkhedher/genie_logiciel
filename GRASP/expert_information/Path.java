package GRASP.expert_information;

import java.util.ArrayList;
import java.util.List;

import GOF.patron_structure.composite.Node;

public class Path {

    private String id;
    private String label;
    private String description;
    private String contentLink;
    private String assetsLink;
    private String coverPictureLink;
    private List<String> tags;
    private List<Node> nodes; // List of nodes in the path
    private int requiredScore;
    private int status; // 1: Active, 2: Inactive

    public Path(String id, String label, String description, String contentLink, String assetsLink,
            String coverPictureLink, List<String> tags, int requiredScore) {
        this.id = id;
        this.label = label;
        this.description = description;
        this.contentLink = contentLink;
        this.assetsLink = assetsLink;
        this.coverPictureLink = coverPictureLink;
        this.tags = tags;
        this.nodes = new ArrayList<>();
        this.requiredScore = requiredScore;
        this.status = 1; // Active by default
    }

    // Getters and setters for all attributes
    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getLabel() {
        return label;
    }

    public void setLabel(String label) {
        this.label = label;
    }

    public String getDescription() {
        return description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getContentLink() {
        return contentLink;
    }

    public void setContentLink(String contentLink) {
        this.contentLink = contentLink;
    }

    public String getAssetsLink() {
        return assetsLink;
    }

    public void setAssetsLink(String assetsLink) {
        this.assetsLink = assetsLink;
    }

    public String getCoverPictureLink() {
        return coverPictureLink;
    }

    public void setCoverPictureLink(String coverPictureLink) {
        this.coverPictureLink = coverPictureLink;
    }

    public List<String> getTags() {
        return tags;
    }

    public void setTags(List<String> tags) {
        this.tags = tags;
    }

    public List<Node> getNodes() {
        return nodes;
    }

    public void addNode(Node node) {
        this.nodes.add(node);
    }

    public int getRequiredScore() {
        return requiredScore;
    }

    public void setRequiredScore(int requiredScore) {
        this.requiredScore = requiredScore;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        if (status == 1 || status == 2) {
            this.status = status;
        } else {
            throw new IllegalArgumentException("Invalid status value. Must be 1 (Active) or 2 (Inactive).");
        }
    }

    // Methods for managing nodes and calculating the path's score
    public void addNodeAt(Node node, int index) {
        if (index >= 0 && index <= nodes.size()) {
            nodes.add(index, node);
        } else {
            throw new IndexOutOfBoundsException("Invalid index for adding node to path.");
        }
    }

    public void removeNode(Node node) {
        nodes.remove(node);
    }

    public int calculateScore() {
        int totalScore = 0;
        for (Node node : nodes) {
            totalScore += node.getScore();
        }
        return totalScore;
    }
}
