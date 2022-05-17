package com.example.lyc_project;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.graphics.BitmapFactory;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class HistoryAdapter extends RecyclerView.Adapter<HistoryAdapter.MyViewHolder> {
    private final Activity activity;
    private ArrayList<History> history_list;

    public class MyViewHolder extends RecyclerView.ViewHolder{
        private TextView date, text, file;
        private LinearLayout history_layout;

        public MyViewHolder(final View itemView){
            super(itemView);
            date = itemView.findViewById(R.id.history_date);
            text = itemView.findViewById(R.id.history_text);
            file = itemView.findViewById(R.id.history_file);
            history_layout = itemView.findViewById(R.id.history_layout);
            history_layout.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    int pos = getAdapterPosition();
                    if(pos != RecyclerView.NO_POSITION){
                        View historyView = (View)View.inflate(activity, R.layout.view_history_popup,null);
                        AlertDialog.Builder dlg = new AlertDialog.Builder(activity);
                        TextView history_popup_date = (TextView)historyView.findViewById(R.id.history_popup_date);
                        TextView history_popup_text = (TextView)historyView.findViewById(R.id.history_popup_text);
                        ImageView history_popup_file = (ImageView)historyView.findViewById(R.id.history_popup_file);
                        history_popup_date.setText(history_list.get(pos).date);
                        history_popup_text.setText(history_list.get(pos).text);
                        history_popup_file.setImageBitmap(BitmapFactory.decodeFile(activity.getCacheDir() + "/" + history_list.get(pos).file));
                        dlg.setTitle("상세보기");
                        dlg.setView(historyView);
                        dlg.setNegativeButton("닫기",null);
                        dlg.show();
                    }
                }
            });
        }
    }

    public HistoryAdapter(ArrayList<History> history_list, Activity activity) {
        this.history_list = history_list;
        this.activity = activity;
    }

    @Override
    public HistoryAdapter.MyViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        Context context = parent.getContext();
        LayoutInflater inflater = (LayoutInflater)context.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
        View view = inflater.inflate(R.layout.view_history_view, parent, false );
        MyViewHolder vh = new MyViewHolder(view);
        return vh;
    }

    @Override
    public void onBindViewHolder(MyViewHolder holder, int position) {
        holder.date.setText(history_list.get(position).date);
        holder.text.setText(history_list.get(position).text);
        holder.file.setText((history_list.get(position).file != null) ? "등록됨" : "미등록");
    }

    @Override
    public int getItemCount() {
        return history_list.size();
    }


}
