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

    public String toString() {
        return Artist + " " + Title;
    }
}


