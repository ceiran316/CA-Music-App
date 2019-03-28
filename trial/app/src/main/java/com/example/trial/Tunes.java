package com.example.trial;

import com.google.gson.annotations.SerializedName;

public class Tunes {
    @SerializedName("id")
    public int ID;
    @SerializedName("irishChart")
    public int IrishChart;
    @SerializedName("title")
    public String Title;
    @SerializedName("artist")
    public String Artist;
    @SerializedName("album")
    public String Album;
    @SerializedName("genre")
    public String Genre;
    @SerializedName("albumCoverLink")
    public String AlbumCoverLink;
    @SerializedName("price")
    public double Price;
    @SerializedName("buyLink")
    public String BuyLink;
    @SerializedName("realsed")
    public String Realsed;
    @SerializedName("duration")
    public String Duration;

    public int getID() {
        return ID;
    }

    public String getArtist() {
        return Artist;
    }

    public String getTitle() {
        return Title;
    }

    public String getAlbum() {
        return Album;
    }

    public String getGenre() {
        return Genre;
    }


    public String getDuration() {
        return Duration;
    }

    public String toString() {
        return Title;
    }

}

class Stats extends Tunes {
    public String toString() {
        return getDuration();
    }
}

class GenreInfo extends Tunes {
    public String toString() {
        return  "\n" + getArtist() + "\t" + getTitle() + "\t" + getGenre() ;
    }
}


