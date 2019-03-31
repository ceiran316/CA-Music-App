package com.example.trial;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.TextView;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;
import com.squareup.picasso.Picasso;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.List;
import android.widget.ArrayAdapter;

import androidx.appcompat.app.AppCompatActivity;

import static android.app.PendingIntent.getActivity;

public class MainActivity extends AppCompatActivity {
    private String SERVICE_URI = "https://catunes.azurewebsites.net/api/tunes/all";
    private String TOPCHART_URI = "https://catunes.azurewebsites.net/api/tunes/top20";
    private String GENRE_URI = "https://catunes.azurewebsites.net/api/tunes/Genre/Rock";
    private String STATS_URI = "https://catunes.azurewebsites.net/api/tunes/cheapest";
    private String TAG = "trial";

     ListView mListView;
     ListView zListView;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        mListView = (ListView) findViewById(R.id.listView);
        zListView = (ListView) findViewById(R.id.listView2);


        //View mTextViewResult = findViewById(R.id.all);
        Button homeBtn = findViewById(R.id.home);
        Button genreBtn = findViewById(R.id.genre);
        Button statsBtn = findViewById(R.id.stats);

        String helloTrans = getResources().getString(R.string.app_name);
        String homeTrans = getResources().getString(R.string.home);
        String genreTrans = getResources().getString(R.string.genre);
        String statsTrans = getResources().getString(R.string.stats);




        homeBtn.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                homeService(view);
            }
        });

        genreBtn.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                buyService(view);
            }
        });

       /* stats.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                statsService(view);
            }
        }); */




        homeService(mListView);
        //buyService(zListView);



    }



    public void homeService(View v) {

        zListView.setVisibility(View.INVISIBLE);
        mListView.setVisibility(View.VISIBLE);


        final ImageView imgurl = findViewById(R.id.img);
        final TextView text = findViewById(R.id.txt);
        final AutoCompleteTextView autoCompleteTextView = findViewById(R.id.autoCompleteTextView);

        RequestQueue queue = Volley.newRequestQueue(this);
        StringRequest strObjRequest = new StringRequest(Request.Method.GET, TOPCHART_URI,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        String input = response;
                        Gson gson = new Gson();

                        Type TuneListType = new TypeToken<ArrayList<Tunes>>(){}.getType();
                        List<Tunes> tunesList = gson.fromJson(input, TuneListType);


                        // Tunes one = new Tunes("hi", "ff", "FFF", "https://upload.wikimedia.org/wikipedia/en/thumb/0/08/Madonna_-_Like_a_Prayer_album.png/220px-Madonna_-_Like_a_Prayer_album.png");
                        //Tunes two = new Tunes("hi", "ff", "FFF", "https://upload.wikimedia.org/wikipedia/en/thumb/0/08/Madonna_-_Like_a_Prayer_album.png/220px-Madonna_-_Like_a_Prayer_album.png");
                        //Tunes three = new Tunes(tunesList.get(2).getArtist(), tunesList.get(2).getTitle(), tunesList.get(2).getAlbum(),tunesList.get(2).getAlbumCoverLink());

                        ArrayList<Tunes> tunesMad = new ArrayList<>();
                        Tunes storage;
                        for(int i=0; i < tunesList.size(); i++) {
                            storage = new Tunes(tunesList.get(i).getArtist(), tunesList.get(i).getTitle(), tunesList.get(i).getGenre(),tunesList.get(i).getAlbumCoverLink());
                            tunesMad.add(storage);
                        }



                        TunesListAdapter adapter = new TunesListAdapter(MainActivity.this, tunesMad);
                        mListView.setAdapter(adapter);





                        ArrayList<String> albumArt = new ArrayList<>();

                        for(int i = 0; i < tunesList.size(); i++) {
                            albumArt.add(i,tunesList.get(i).getAlbumCoverLink());
                        }


                        //String imageUri = "https://upload.wikimedia.org/wikipedia/en/thumb/0/08/Madonna_-_Like_a_Prayer_album.png/220px-Madonna_-_Like_a_Prayer_album.png";
                        //Picasso.with(MainActivity.this).load(imageUri).into(imgurl);




                        ArrayList<String> tuneTitles = new ArrayList<String>();

                        for(int i=0; i < tunesList.size(); i++) {
                            tuneTitles.add(i,tunesList.get(i).getTitle());
                        }

                        ArrayAdapter<String> arrayAdapter = new ArrayAdapter<String>(MainActivity.this, android.R.layout.simple_list_item_1,tuneTitles);

                        autoCompleteTextView.setAdapter(arrayAdapter);
                        autoCompleteTextView.setThreshold(1);

                        for(int i = 0; i < tunesList.size(); i++) {
                            Picasso.with(MainActivity.this).load(albumArt.get(i)).into(imgurl);
                            text.setText(tuneTitles.get(i));
                        }






                    }
                },
                new Response.ErrorListener() {
                    @Override
                    public void onErrorResponse(VolleyError error) {
                        //outputTextView.setText(error.toString());
                        Log.d(TAG, "Error" + error.toString());
                    }
                });
        queue.add(strObjRequest);
    }




    public void buyService(View v) {

        mListView.setVisibility(View.INVISIBLE);
        zListView.setVisibility(View.VISIBLE);


        RequestQueue queue = Volley.newRequestQueue(this);
        StringRequest strObjRequest = new StringRequest(Request.Method.GET, SERVICE_URI,
                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        String input = response;
                        Gson gson = new Gson();

                        Type TuneListType = new TypeToken<ArrayList<Tunes>>() {
                        }.getType();
                        List<Tunes> tunesList = gson.fromJson(input, TuneListType);


                        ArrayList<BuyAlbums> purchaseTunes = new ArrayList<>();
                        BuyAlbums storage;
                        for (int i = 0; i < tunesList.size(); i++) {
                            storage = new BuyAlbums(tunesList.get(i).getArtist(), tunesList.get(i).getAlbum(), tunesList.get(i).getAlbumCoverLink(), tunesList.get(i).getBuyLink());
                            purchaseTunes.add(storage);
                        }


                        PurchaseAdapter adapter = new PurchaseAdapter(MainActivity.this, purchaseTunes);
                        zListView.setAdapter(adapter);
                    }

    },
            new Response.ErrorListener() {
        @Override
        public void onErrorResponse(VolleyError error) {
            //outputTextView.setText(error.toString());
            Log.d(TAG, "Error" + error.toString());
        }
    });
        queue.add(strObjRequest);
}





    }





