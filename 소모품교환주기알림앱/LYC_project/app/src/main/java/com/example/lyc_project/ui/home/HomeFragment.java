package com.example.lyc_project.ui.home;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.lifecycle.ViewModelProviders;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.lyc_project.HomeAdapter;
import com.example.lyc_project.Home_item;
import com.example.lyc_project.MainActivity;
import com.example.lyc_project.Object;
import com.example.lyc_project.R;
import com.example.lyc_project.ui.dashboard.DashboardViewModel;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class HomeFragment extends Fragment {
    private DashboardViewModel model;
    RecyclerView recyclerView;
    RecyclerView.Adapter mAdapter;
    RecyclerView.LayoutManager layoutManager;


    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_home, container, false);
        recyclerView = (RecyclerView)view.findViewById(R.id.home_RecyclerView);

        loadItemSchedule();
        return view;
    }

    public void onResume() {
        super.onResume();
        FragmentActivity activity = getActivity();
        if (activity != null) {
            ((MainActivity) activity).setActionBarTitle("Home");
        }
    }

    public void loadItemSchedule(){
        ArrayList<Home_item> item_list = new ArrayList<Home_item>();
        model = ViewModelProviders.of(getActivity()).get(DashboardViewModel.class);
        SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");

        for(int i = 0; i < 6; i++){//초기화
            if(((MainActivity)getActivity()).loadobj("obj"+(i+1)) == false) continue;
            Object object = model.getObject();
            if(object.icon == 0) continue;//미등록일경우 0, 스킵함
            for (int j = 1; j < 4; j++) {
                if (object.item_list[j] == null) continue;
                if (object.type.compareTo("km") == 0) {//km단위라면 300km미만이면 출력
                    int odd = 0, item = 0;
                    odd = Integer.parseInt(object.item_list[0].criteria);
                    item = Integer.parseInt(object.item_list[j].get_Item_next());
                    if (item - odd < 300)
                        item_list.add(new Home_item("잔여 : "+(item - odd)+ "km", ""+object.item_list[j].item_name, ""+object.name));
                }
                else {//month단위라면 동월일때 출력
                    try {
                        Date today_date = dateFormat.parse(((MainActivity) getActivity()).getDate());
                        Date item_date = dateFormat.parse(object.item_list[j].get_Item_next());
                        if (today_date.getMonth() == item_date.getMonth())
                            item_list.add(new Home_item(object.item_list[j].get_Item_next(), object.item_list[j].item_name, ""+object.name));
                    }
                    catch (ParseException e) {
                        e.printStackTrace();
                    }
                }
            }
        }
        layoutManager = new LinearLayoutManager(getContext());
        recyclerView.setLayoutManager(layoutManager);
        mAdapter = new HomeAdapter(item_list);
        recyclerView.setAdapter(mAdapter);

    }

}
