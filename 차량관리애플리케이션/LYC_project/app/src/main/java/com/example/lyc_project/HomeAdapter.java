package com.example.lyc_project;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class HomeAdapter extends RecyclerView.Adapter<HomeAdapter.MyViewHolder> {
    private ArrayList<Home_item> item_list;

    public class MyViewHolder extends RecyclerView.ViewHolder{
    TextView date, text, home_obj_name;
    LinearLayout home_layout;
        public MyViewHolder(final View itemView){
            super(itemView);
            date = itemView.findViewById(R.id.home_date);
            text = itemView.findViewById(R.id.home_title);
            home_obj_name = itemView.findViewById(R.id.home_obj_name);
            home_layout = itemView.findViewById(R.id.home_layout);
        }
    }

    public HomeAdapter(ArrayList<Home_item> item_list) {
       this.item_list = item_list;
    }

    @Override
    public HomeAdapter.MyViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        Context context = parent.getContext();
        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View view = inflater.inflate(R.layout.view_home_schedule, parent, false );
        HomeAdapter.MyViewHolder vh = new HomeAdapter.MyViewHolder(view);
        return vh;
    }

    @Override
    public void onBindViewHolder(HomeAdapter.MyViewHolder holder, int position) {
        holder.date.setText(item_list.get(position).date);
        holder.text.setText(item_list.get(position).text);
        holder.home_obj_name.setText(item_list.get(position).home_obj_name);
    }

    @Override
    public int getItemCount() {
        return item_list.size();
    }
}
