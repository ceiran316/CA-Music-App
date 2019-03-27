package com.example.trial;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.List;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {
    private String SERVICE_URI = "https://catunes.azurewebsites.net/api/tunes/all";
    private String TAG = "trial";


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //View mTextViewResult = findViewById(R.id.all);
        Button bt = findViewById(R.id.button);

        bt.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View view)
            {
                callService(view);
            }
        });
    }


    public void callService(View v) {
        // get TextView for displaying result
        final TextView outputTextView = findViewById(R.id.all);

        try {
            // make a string request (JSON request an alternative)
            RequestQueue queue = Volley.newRequestQueue(this);
            Log.d(TAG, "Making request");
            try {
                StringRequest strObjRequest = new StringRequest(Request.Method.GET, SERVICE_URI,
                        new Response.Listener<String>() {
                            @Override
                            public void onResponse(String response) {

                                String input = response;
                                Gson gson = new Gson();

                                Type TuneListType = new TypeToken<ArrayList<Tunes>>(){}.getType();
                                List<Tunes> tunesList = gson.fromJson(input, TuneListType);

                                outputTextView.setText(tunesList.toString());
                            }
                        },
                        new Response.ErrorListener() {
                            @Override
                            public void onErrorResponse(VolleyError error) {
                                outputTextView.setText(error.toString());
                                Log.d(TAG, "Error" + error.toString());
                            }
                        });
                queue.add(strObjRequest);           // can have multiple in a queue, and can cancel
            } catch (Exception e1) {
                Log.d(TAG, e1.toString());
                outputTextView.setText(e1.toString());
            }
        } catch (Exception e2) {
            Log.d(TAG, e2.toString());
            outputTextView.setText(e2.toString());
        }
    }
}