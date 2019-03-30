package com.example.trial;

import android.content.Context;
import android.content.Intent;
import android.net.Uri;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import com.squareup.picasso.Picasso;

import java.util.ArrayList;

import static androidx.core.content.ContextCompat.startActivity;

public class PurchaseAdapter extends ArrayAdapter<BuyAlbums> {

    private static final String TAG = "PurchaseAdapter";

    private Context mContext;
    private int lastPosition = -1;


    private static class ViewHolder {
        TextView artist;
        TextView album;
        Button buy;
        ImageView image;
    }



    public PurchaseAdapter(Context context, ArrayList<BuyAlbums> objects) {
        super(context, R.layout.purchase_view_layout, objects);
        mContext = context;
    }

    public View getView(int position, View convertView, ViewGroup parent) {


        String artist = getItem(position).getArtist();
        String album = getItem(position).getAlbum();
        final String buy = getItem(position).getBuyLink();
        String imgUrl = getItem(position).getAlbumCoverLink();



        //ViewHolder object
        PurchaseAdapter.ViewHolder holder;

        final View result;


        if(convertView == null){
            LayoutInflater inflater = LayoutInflater.from(mContext);
            convertView = inflater.inflate(R.layout.purchase_view_layout, parent, false);
            holder= new  PurchaseAdapter.ViewHolder();
            holder.artist = (TextView) convertView.findViewById(R.id.TextViewArtist);
            holder.buy = (Button) convertView.findViewById(R.id.buttonLink);
            holder.album = (TextView) convertView.findViewById(R.id.TextViewAlbum);
            holder.image = (ImageView) convertView.findViewById(R.id.imageArt);

            result=convertView;
            convertView.setTag(holder);
        }
        else{
            holder = (PurchaseAdapter.ViewHolder) convertView.getTag();
            result=convertView;
        }

        Animation animation = AnimationUtils.loadAnimation(mContext, (position > lastPosition) ? R.anim.up_from_bottom : R.anim.down_from_top);
        result.startAnimation(animation);
        lastPosition = position;

        holder.artist.setText(artist);
        holder.album.setText(album);


        Picasso.with(mContext).load(imgUrl).into(holder.image);


        holder.buy.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent browserOpen = new Intent(Intent.ACTION_VIEW, Uri.parse(buy));
                mContext.startActivity(browserOpen);
            }
        });




        return convertView;
    }



}
