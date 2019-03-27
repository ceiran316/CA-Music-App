package com.example.trial;

import com.google.gson.annotations.SerializedName;

public class SuggestedTunes {

    @SerializedName("id")
    public int Id;
    @SerializedName("count")
    public int Count;
    @SerializedName("title")
    public String Title;
    @SerializedName("artist")
    public String Artist;
    @SerializedName("genre")
    public String Genre;

    public String toString() {
        return Artist + " " + Title + " " + Count + " " + Genre;
    }

}
