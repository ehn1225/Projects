package com.example.lyc_project.ui.item;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TableLayout;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.lifecycle.ViewModelProviders;
import androidx.navigation.Navigation;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;
import com.example.lyc_project.HistoryAdapter;
import com.example.lyc_project.MainActivity;
import com.example.lyc_project.Object;
import com.example.lyc_project.R;
import com.example.lyc_project.ui.dashboard.DashboardViewModel;

public class ItemViewFragment extends Fragment {
    TextView append, title,next;
    Object obj;
    ImageView imageview, modify;
    DashboardViewModel model;
    TextView item1_title,item1_cycle, item2_title,item2_cycle, item3_title,item3_cycle, item4_title, item4_cycle, view_last, view_last_modify, view_before;
    RecyclerView recyclerView;
    RecyclerView.Adapter mAdapter;
    LinearLayoutManager layoutManager;

    //각 아이템별 잔여 날짜 계산, obj의 기준날짜는 매일 업데이트
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_item_view, container, false);
        modify = (ImageView)view.findViewById(R.id.view_modify);
        append = (TextView)view.findViewById(R.id.view_append);
        imageview = (ImageView)view.findViewById(R.id.view_imageview);
        title = (TextView)view.findViewById(R.id.view_title);
        next = (TextView)view.findViewById(R.id.view_next);
        item1_title = (TextView)view.findViewById(R.id.view_item1_title);
        item1_cycle = (TextView)view.findViewById(R.id.view_item1_value);
        item2_title = (TextView)view.findViewById(R.id.view_item2_title);
        item2_cycle = (TextView)view.findViewById(R.id.view_item2_value);
        item3_title = (TextView)view.findViewById(R.id.view_item3_title);
        item3_cycle = (TextView)view.findViewById(R.id.view_item3_value);
        item4_title = (TextView)view.findViewById(R.id.view_item4_title);
        item4_cycle = (TextView)view.findViewById(R.id.view_item4_value);
        view_last_modify = (TextView)view.findViewById(R.id.view_last_modify);
        view_last = (TextView)view.findViewById(R.id.view_last_modify);
        view_before = (TextView)view.findViewById(R.id.view_before);
        recyclerView = (RecyclerView)view.findViewById(R.id.view_RecyclerView);

        Initialize();
        onClick();
        return view;
    }

    public void onResume() {
        super.onResume();
        FragmentActivity activity = getActivity();
        if (activity != null) {
            ((MainActivity) activity).setActionBarTitle("Detail");
        }
    }

    private void Initialize() {
        TextView [] item_title = {item4_title, item1_title, item2_title, item3_title};
        TextView [] item_cycle = {item4_cycle, item1_cycle, item2_cycle, item3_cycle};

        model = ViewModelProviders.of(getActivity()).get(DashboardViewModel.class);
        obj = model.getObject();
        obj.Refresh();
        layoutManager = new LinearLayoutManager(getContext());
        layoutManager.setReverseLayout(true);
        layoutManager.setStackFromEnd(true);
        recyclerView.setLayoutManager(layoutManager);
        mAdapter = new HistoryAdapter(obj.history_list, ((MainActivity)getActivity()));
        recyclerView.setAdapter(mAdapter);
        imageview.setImageResource(obj.icon);
        title.setText(obj.name);
        for(int i = 0; i < 4; i++){
            if(obj.item_list[i] == null)
                continue;
            item_title[i].setText(obj.item_list[i].item_name);
            item_cycle[i].setText(obj.item_list[i].get_Item_next() + ((obj.type.compareTo("km")==0)? "km" : ""));
        }
        view_last_modify.setText(obj.last_modify);
        if(obj.next != null) next.setText(obj.next + ((obj.type.compareTo("km")==0)? "km" : ""));
        if(obj.before != null) view_before.setText(obj.before);

    }

    private void onClick(){
        append.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Navigation.findNavController(view).navigate((R.id.action_navigation_item_view_to_itemViewDetailFragment));//내역 추가
            }
        });

        modify.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Navigation.findNavController(view).navigate((R.id.action_navigation_item_view_to_navigation_item_append));//아이템 수정
            }
        });
    }



}
