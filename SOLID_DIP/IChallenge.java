public interface IChallenge {
    String getId();
    String getDescription();
    String getContentLink();
    String getAssetsLink();
    String getCoverPictureLink();
    List<String> getTags();
    int getRequiredScore();
}