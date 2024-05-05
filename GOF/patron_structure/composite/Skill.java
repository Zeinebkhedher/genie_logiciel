package GOF.patron_structure.composite;

import java.util.List;

public class Skill implements ElementParcours {

    private String id;
    private String label;
    private String description;
    private String contentLink;
    private String assetsLink;
    private String coverPictureLink;
    private List<String> tags;
    private int requiredScore;

    // Constructeur
    public Skill(String id, String label, String description, String contentLink, String assetsLink,
            String coverPictureLink, List<String> tags, int requiredScore) {
        this.id = id;
        this.label = label;
        this.description = description;
        this.contentLink = contentLink;
        this.assetsLink = assetsLink;
        this.coverPictureLink = coverPictureLink;
        this.tags = tags;
        this.requiredScore = requiredScore;
    }

    // Getters et setters pour les attributs
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

    public int getRequiredScore() {
        return requiredScore;
    }

    public void setRequiredScore(int requiredScore) {
        this.requiredScore = requiredScore;
    }

    // Implémentation des méthodes de l'interface ElementParcours
    @Override
    public int getPosx() {
        // Implémenter la logique pour récupérer la position horizontale de la
        // compétence
        return 0;
    }

    @Override
    public void setPosx(int posx) {
        // Implémenter la logique pour définir la position horizontale de la compétence
        // ...
    }

    @Override
    public int getPosy() {
        // Implémenter la logique pour récupérer la position verticale de la compétence
        return 0;
    }

    @Override
    public void setPosy(int posy) {
        // Implémenter la logique pour définir la position verticale de la compétence
        // ...
    }

    @Override
    public int getScore() {
        // Implémenter la logique pour récupérer le score de la compétence
        return 0;
    }

    @Override
    public void setScore(int score) {
        // Implémenter la logique pour définir le score de la compétence
        // ...
    }
}
