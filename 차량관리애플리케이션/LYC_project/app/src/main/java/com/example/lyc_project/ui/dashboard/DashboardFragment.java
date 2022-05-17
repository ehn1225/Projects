package com.example.lyc_project.ui.dashboard;

import android.content.Context;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.lifecycle.ViewModelProviders;
import androidx.navigation.Navigation;
import com.example.lyc_project.MainActivity;
import com.example.lyc_project.Object;
import com.example.lyc_project.R;

public class DashboardFragment extends Fragment {
    LinearLayout obj1, obj2, obj3, obj4, obj5, obj6;
    TextView textview1, textview2, textview3, textview4, textview5, textview6;
    ImageView imageview1, imageview2, imageview3, imageview4, imageview5, imageview6;
    Context context;
    DashboardViewModel model;

    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_dashboard, container, false);
        context = getContext();

        obj1 = (LinearLayout)view.findViewById(R.id.obj1);
        textview1 = (TextView)view.findViewById(R.id.textview1);
        imageview1 = (ImageView)view.findViewById(R.id.imageView1);
        obj2 = (LinearLayout)view.findViewById(R.id.obj2);
        textview2 = (TextView)view.findViewById(R.id.textview2);
        imageview2 = (ImageView)view.findViewById(R.id.imageView2);
        obj3 = (LinearLayout)view.findViewById(R.id.obj3);
        textview3 = (TextView)view.findViewById(R.id.textview3);
        imageview3 = (ImageView)view.findViewById(R.id.imageView3);
        obj4 = (LinearLayout)view.findViewById(R.id.obj4);
        textview4 = (TextView)view.findViewById(R.id.textview4);
        imageview4 = (ImageView)view.findViewById(R.id.imageView4);
        obj5 = (LinearLayout)view.findViewById(R.id.obj5);
        textview5 = (TextView)view.findViewById(R.id.textview5);
        imageview5 = (ImageView)view.findViewById(R.id.imageView5);
        obj6 = (LinearLayout)view.findViewById(R.id.obj6);
        textview6 = (TextView)view.findViewById(R.id.textview6);
        imageview6 = (ImageView)view.findViewById(R.id.imageView6);
        TextView []textview = { textview1, textview2, textview3, textview4, textview5, textview6};
        ImageView []imageview = {imageview1, imageview2, imageview3, imageview4, imageview5, imageview6};
        LinearLayout [] obj = {obj1,obj2,obj3,obj4,obj5,obj6};
        model = ViewModelProviders.of(getActivity()).get(DashboardViewModel.class);

        onCLick();
        for(int i = 0; i < 6; i++){//초기화
            if(((MainActivity)getActivity()).loadobj("obj"+(i+1)) == false) continue;
            Object object = model.getObject();
            if(object.icon == 0) //미등록일경우 0
                continue;
            imageview[i].setImageResource(object.icon);
            textview[i].setText(object.name);
        }

        return view;
    }
    public void onResume() {
        super.onResume();
        FragmentActivity activity = getActivity();
        if (activity != null) {
            ((MainActivity) activity).setActionBarTitle("Dashboard");
        }
    }

    private void onCLick(){
        obj1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                selectObject("obj1");
            }
        });
        obj2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                selectObject("obj2");
            }
        });
        obj3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                selectObject("obj3");
            }
        });
        obj4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                selectObject("obj4");
            }
        });
        obj5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                selectObject("obj5");
            }
        });
        obj6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                selectObject("obj6");
            }
        });
    }

    public void selectObject(String id) {
        ((MainActivity)getActivity()).loadobj(id); //해당 Object를 읽어서 메모리에 올림
        Object obj = model.getObject();
        if(obj.icon == 0)//미등록이면 append로, 등록이면 view로
            Navigation.findNavController(getView()).navigate((R.id.action_navigation_dashboard_to_navigation_item_append));
        else
            Navigation.findNavController(getView()).navigate((R.id.action_navigation_dashboard_to_navigation_item_view));
    }

}
