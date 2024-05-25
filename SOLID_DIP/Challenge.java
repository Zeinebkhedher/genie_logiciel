import java.util.List;

public class Challenge implements IChallenge {
    private String id;
    private String description;
    private String contentLink;
    private String assetsLink;
    private String coverPictureLink;
    private List<String> tags;
    private int requiredScore;

    // Constructor
    public Challenge(String id, String description, String contentLink, String assetsLink, String coverPictureLink, List<String> tags, int requiredScore) {
        this.id = id;
        this.description = description;
        this.contentLink = contentLink;
        this.assetsLink = assetsLink;
        this.coverPictureLink = coverPictureLink;
        this.tags = tags;
        this.requiredScore = requiredScore;
    }

    // Getters
    @Override
    public String getId() {
        return id;
    }

    @Override
    public String getDescription() {
        return description;
    }

    @Override
    public String getContentLink() {
        return contentLink;
    }

    @Override
    public String getAssetsLink() {
        return assetsLink;
    }

    @Override
    public String getCoverPictureLink() {
        return coverPictureLink;
    }

    @Override
    public List<String> getTags() {
        return tags;
    }

    @Override
    public int getRequiredScore() {
        return requiredScore;
    }
}