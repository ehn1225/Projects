package com.example.lyc_project.ui.item;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.RadioButton;
import android.widget.TextView;
import android.widget.Toast;
import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.lifecycle.ViewModelProviders;
import androidx.navigation.Navigation;
import com.example.lyc_project.Item;
import com.example.lyc_project.MainActivity;
import com.example.lyc_project.Object;
import com.example.lyc_project.R;
import com.example.lyc_project.ui.dashboard.DashboardViewModel;

public class ItemAppendFragment extends Fragment {
    ImageView iconview;
    Object obj;
    Button apply;
    RadioButton rbt1,rbt2,icon1,icon2,icon3,icon4;
    LinearLayout km_odd_layout;
    EditText item1_title,item1_cycle,item2_title,item2_cycle,item3_title,item3_cycle,item4_odd, item_name;
    String item4_title, item4_cycle, type= "km";;
    TextView item1_type,item2_type,item3_type; //type용
    int icon = R.drawable.ic_directions_car_black_24dp;

    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_item_append, container, false);
        apply = (Button)view.findViewById(R.id.append_apply);
        rbt1 = (RadioButton)view.findViewById(R.id.append_radioButton1);
        rbt2 = (RadioButton)view.findViewById(R.id.append_radioButton2);
        icon1 = (RadioButton)view.findViewById(R.id.append_icon_radioButton1);
        icon2 = (RadioButton)view.findViewById(R.id.append_icon_radioButton2);
        icon3 = (RadioButton)view.findViewById(R.id.append_icon_radioButton3);
        icon4 = (RadioButton)view.findViewById(R.id.append_icon_radioButton4);
        iconview = (ImageView)view.findViewById(R.id.append_icon_imageview);
        km_odd_layout = (LinearLayout)view.findViewById(R.id.append_km_odd_layout);
        item1_title = (EditText)view.findViewById(R.id.append_item1_name);
        item1_cycle = (EditText)view.findViewById(R.id.append_item1_cycle);
        item1_type = (TextView)view.findViewById(R.id.append_item1_type);
        item2_title = (EditText)view.findViewById(R.id.append_item2_name);
        item2_cycle = (EditText)view.findViewById(R.id.append_item2_cycle);
        item2_type = (TextView)view.findViewById(R.id.append_item2_type);
        item3_title = (EditText)view.findViewById(R.id.append_item3_name);
        item3_cycle = (EditText)view.findViewById(R.id.append_item3_cycle);
        item3_type = (TextView)view.findViewById(R.id.append_item3_type);
        item4_odd = (EditText)view.findViewById(R.id.append_item4_cycle);
        item_name = (EditText)view.findViewById(R.id.append_name);

        Initialize();
        onClick();
        return view;
    }

    private void Initialize() {
        DashboardViewModel model = ViewModelProviders.of(getActivity()).get(DashboardViewModel.class);
        obj = model.getObject();
        if(obj.icon != 0){ //저장된 아이템만 로딩, 0이면 새로 생성된 아이템
            EditText [] item_title = {item1_title, item2_title, item3_title};
            EditText [] item_cycle = {item1_cycle, item2_cycle, item3_cycle};
            item_name.setText(obj.name);
            setLayout(obj.type);
            for(int i = 1; i < 3; i++){
                if(obj.item_list[i] == null)
                    continue;
                item_title[i-1].setText(obj.item_list[i].item_name);
                item_cycle[i-1].setText(""+obj.item_list[i].item_cycle);
            }
            if(obj.item_list[0] != null)
                item4_odd.setText(obj.item_list[0].criteria);
            icon = obj.icon;
            switch (icon){
                case R.drawable.ic_directions_car_black_24dp :
                    break;
                case R.drawable.ic_local_hospital_black_24dp :
                    icon1.setChecked(false);
                    icon2.setChecked(true);
                    break;
                case R.drawable.ic_event_available_black_24dp :
                    icon1.setChecked(false);
                    icon3.setChecked(true);
                    break;
                case R.drawable.ic_grade_black_24dp :
                    icon1.setChecked(false);
                    icon4.setChecked(true);
                    break;
            }
            iconview.setImageResource(icon);
        }
    }

    public void onResume() {
        super.onResume();
        FragmentActivity activity = getActivity();
        if (activity != null) {
            ((MainActivity) activity).setActionBarTitle("Append/Modify");
        }
    }

    private void onClick(){
        rbt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                setLayout("km");
            }
        });
        rbt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                setLayout("month");
            }
        });
        apply.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(item_name.getText().toString().compareTo("") == 0)
                    Toast.makeText(getContext(), "내용을 작성해주세요.", Toast.LENGTH_SHORT).show();

                obj.name = item_name.getText().toString();
                String criteria;
                if(type.compareTo("km") == 0){
                    if(item4_odd.getText().toString().compareTo("") == 0){
                        Toast.makeText(getContext(), "내용을 작성해주세요.", Toast.LENGTH_SHORT).show();
                        return;
                    }
                    item4_title = "누적주행거리";
                    criteria = item4_odd.getText().toString();
                }
                else{
                    item4_title = "기준일자";
                    criteria = ((MainActivity) getActivity()).getDate();
                }
                item4_cycle = "0";

                obj.icon = icon;
                obj.type = type;
                String [] item_title = {item4_title, item1_title.getText().toString(), item2_title.getText().toString(), item3_title.getText().toString()};
                String [] item_cycle = {item4_cycle, item1_cycle.getText().toString(), item2_cycle.getText().toString(), item3_cycle.getText().toString()};

                for(int i = 0; i< 4; i++){
                    if(item_title[i].length() > 0 && item_cycle[i].length()> 0){//내용이 있다면
                        if(obj.item_list[i] == null || i == 0)//새거거나 기본항목
                            obj.item_list[i] = new Item(item_title[i], criteria, Integer.parseInt(item_cycle[i]));
                        else //기존에 있던 아이템이라면 업데이트를 함. 아이템 삭제는
                            obj.item_list[i].updateItem(item_title[i], Integer.parseInt(item_cycle[i]));
                    }
                }

                obj.last_modify = ((MainActivity) getActivity()).getDate();
                if(((MainActivity) getActivity()).saveobj()){
                    Navigation.findNavController(view).navigate((R.id.action_navigation_item_append_to_navigation_dashboard));
                }else
                    Toast.makeText(getContext(), "저장불가! 데이터를 초기화 해주세요", Toast.LENGTH_SHORT).show();
            }
        });
        icon1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                iconview.setImageResource(icon = R.drawable.ic_directions_car_black_24dp);
            }
        });
        icon2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                iconview.setImageResource(icon = R.drawable.ic_local_hospital_black_24dp);
            }
        });
        icon3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                iconview.setImageResource(icon = R.drawable.ic_event_available_black_24dp);
            }
        });
        icon4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                iconview.setImageResource(icon = R.drawable.ic_grade_black_24dp);
            }
        });
    }

    private void setLayout(String type){
        TextView [] text_view_type = {item1_type,item2_type,item3_type};

        if(type.compareTo("km")==0){
            km_odd_layout.setVisibility(View.VISIBLE);
            rbt1.setChecked(true);
            rbt2.setChecked(false);
            for(int i = 0; i< 3; i++){
                text_view_type[i].setText("km");
            }
        }
        else{
            km_odd_layout.setVisibility(View.GONE);
            rbt1.setChecked(false);
            rbt2.setChecked(true);
            for(int i = 0; i< 3; i++){
                text_view_type[i].setText("개월");
            }
        }
        this.type = type;
    }

}
