package com.example.trial;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;


import com.squareup.picasso.Picasso;

import java.util.ArrayList;

import androidx.annotation.NonNull;

public class TunesListAdapter extends ArrayAdapter<Tunes> {

    private static final String TAG = "TunesListAdapter";

    private Context mContext;
    private int lastPosition = -1;

    /**
     * Holds variables in a View
     */
    private static class ViewHolder {
        TextView artist;
        TextView title;
        //TextView album;
        TextView genre;
        ImageView image;
    }

    public TunesListAdapter(Context context, ArrayList<Tunes> objects) {
        super(context, R.layout.adapter_view_layout, objects);
        mContext = context;
    }

    @NonNull
    @Override
    public View getView(int position, View convertView, ViewGroup parent) {


        String artist = getItem(position).getArtist();
        String title = getItem(position).getTitle();
        //String album = getItem(position).getAlbum();
        String genre = getItem(position).getAlbum();
        String imgUrl = getItem(position).getAlbumCoverLink();



        //ViewHolder object
        ViewHolder holder;

        final View result;


        if(convertView == null){
            LayoutInflater inflater = LayoutInflater.from(mContext);
            convertView = inflater.inflate(R.layout.adapter_view_layout, parent, false);
            holder= new ViewHolder();
            holder.artist = (TextView) convertView.findViewById(R.id.textView1);
            holder.title = (TextView) convertView.findViewById(R.id.textView2);
            //holder.album = (TextView) convertView.findViewById(R.id.textView3);
            holder.genre = (TextView) convertView.findViewById(R.id.textView3);
            holder.image = (ImageView) convertView.findViewById(R.id.image);

            result=convertView;
            convertView.setTag(holder);
        }
        else{
            holder = (ViewHolder) convertView.getTag();
            result=convertView;
        }

        Animation animation = AnimationUtils.loadAnimation(mContext, (position > lastPosition) ? R.anim.up_from_bottom : R.anim.down_from_top);
        result.startAnimation(animation);
        lastPosition = position;

        holder.artist.setText(artist);
        //holder.album.setText(album);
        holder.genre.setText(genre);
        holder.title.setText(title);

        Picasso.with(mContext).load(imgUrl).into(holder.image);

        return convertView;
    }



}
