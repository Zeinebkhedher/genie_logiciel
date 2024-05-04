// Interface représentant le contenu textuel
interface TextContent {
    void setText(String text);
    String getText();
}

// Interface représentant le contenu multimédia
interface MultimediaContent {
    void setMedia(Media media);
    void playMedia();
    void pauseMedia();
}

// Interface pour créer du contenu
interface ContentCreator {
    TextContent createTextContent();
    MultimediaContent createMultimediaContent();
}

// Interface pour le directeur
interface Director {
    void setTextContentCreator(TextContentCreator textContentCreator);
    void setMultimediaContentCreator(MultimediaContentCreator multimediaContentCreator);
    TextContent createTextContent();
    MultimediaContent createMultimediaContent();
}

// Classe représentant un document texte
class TextDocument implements TextContent {
    private String text;

    @Override
    public void setText(String text) {
        this.text = text;
    }

    @Override
    public String getText() {
        return text;
    }
}

// Classe représentant une vidéo
class Video implements MultimediaContent {
    private Media media;

    @Override
    public void setMedia(Media media) {
        this.media = media;
    }

    @Override
    public void playMedia() {
        // Code pour jouer la vidéo
    }

    @Override
    public void pauseMedia() {
        // Code pour mettre en pause la vidéo
    }
}

// Classe représentant un média
class Media {
    // Propriétés et méthodes de la classe Media
    // (à compléter selon les besoins)
}