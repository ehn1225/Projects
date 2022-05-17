package com.example.lyc_project.ui.item;

import android.app.Activity;
import android.app.DatePickerDialog;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.DatePicker;
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
import com.example.lyc_project.History;
import com.example.lyc_project.MainActivity;
import com.example.lyc_project.Object;
import com.example.lyc_project.R;
import com.example.lyc_project.ui.dashboard.DashboardViewModel;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.util.Calendar;

public class ItemViewDetailFragment extends Fragment {
    Button apply, setDate;
    String date, text, img;
    Bitmap bit_img;
    EditText edittext, view_detail_odd;
    TextView startdate;
    DatePickerDialog dialog;
    DashboardViewModel model;
    RadioButton rbt1,rbt2,rbt3,rbt4,rbt5;
    LinearLayout view_detail_odd_layout;
    ImageView view_detail_icon_view;
    int select_item_index = 0;
    private DatePickerDialog.OnDateSetListener listener = new DatePickerDialog.OnDateSetListener() {
        @Override
        public void onDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth) {
            date = year + "년 " + (monthOfYear+1) + "월 " + dayOfMonth +"일";
            startdate.setText(date);
        }
    };

    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_item_view_detail, container, false);
        apply = (Button)view.findViewById(R.id.view_detail_apply);
        startdate = (TextView)view.findViewById(R.id.view_detail_date);
        edittext = (EditText) view.findViewById(R.id.view_detail_text);
        Calendar cal = Calendar.getInstance();
        dialog = new DatePickerDialog(getContext(), listener, cal.get(Calendar.YEAR), cal.get(Calendar.MONTH), cal.get(Calendar.DAY_OF_MONTH));
        setDate = (Button)view.findViewById(R.id.view_detail_date_button);
        rbt1 = (RadioButton)view.findViewById(R.id.view_detail_radioButton1); //선택안함
        rbt2 = (RadioButton)view.findViewById(R.id.view_detail_radioButton2); //item1
        rbt3 = (RadioButton)view.findViewById(R.id.view_detail_radioButton3); //item2
        rbt4 = (RadioButton)view.findViewById(R.id.view_detail_radioButton4); //item3
        rbt5 = (RadioButton)view.findViewById(R.id.view_detail_radioButton5); //odd
        view_detail_odd =  (EditText) view.findViewById(R.id.view_detail_odd); //odd 입력

        view_detail_odd_layout = (LinearLayout)view.findViewById(R.id.view_detail_odd_layout);
        view_detail_icon_view = (ImageView)view.findViewById(R.id.view_detail_icon_view) ;
        setDate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dialog.show();
            }
        });
        model = ViewModelProviders.of(getActivity()).get(DashboardViewModel.class);

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

    private void onClick(){
        apply.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {//저장하기
                Object obj = model.getObject();
                if(obj.type.compareTo("km") == 0 && rbt1.isChecked() == false && view_detail_odd.getText().toString().length() == 0){
                    Toast.makeText(getContext(), "누적주행거리를 입력하세요.", Toast.LENGTH_SHORT).show();
                    return;
                }
                text = edittext.getText().toString() + "\n\n 작업한 아이템 : " + ((select_item_index > -1) ? obj.item_list[select_item_index].item_name : "선택안함");
                History history = new History(date,text,img);
                obj.history_list.add(history);
                if(img != null)
                    saveBitmapToJpeg(bit_img,img); //영수증저장
                obj.last_modify = ((MainActivity) getActivity()).getDate();
                if(select_item_index > -1){ //선택한 아이템의 기준일자를 갱신함.
                    if(obj.type.compareTo("km") == 0)
                        obj.item_list[select_item_index].criteria = view_detail_odd.getText().toString();
                    else
                        obj.item_list[select_item_index].criteria = ((MainActivity) getActivity()).getDate();
                    obj.before = ((MainActivity) getActivity()).getDate();
                }
                if(((MainActivity) getActivity()).saveobj())
                    Navigation.findNavController(view).navigate((R.id.action_navigation_item_view_detail_to_navigation_item_view));
                else
                    Toast.makeText(getContext(), "저장불가! 데이터를 초기화 해주세요.", Toast.LENGTH_LONG).show();
            }
        });

        view_detail_icon_view.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {//갤러리에서 이미지 로딩
                Intent intent = new Intent();
                intent.setType("image/*");
                intent.setAction(Intent.ACTION_GET_CONTENT);
                startActivityForResult(intent, 1);
            }
        });

        rbt1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                select_item_index = -1;
            }
        });

        rbt2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                select_item_index = 1;
            }
        });

        rbt3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                select_item_index = 2;
            }
        });

        rbt4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                select_item_index = 3;
            }
        });

        rbt5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                select_item_index = 0;
            }
        });
    }
    private void Initialize() {
        Object obj = model.getObject();
        RadioButton [] rbt_title = {rbt2, rbt3, rbt4};
        for(int i = 1; i < 4; i++){
            if(obj.item_list[i] == null){
                rbt_title[i-1].setVisibility(View.GONE);
                continue;
            }
            rbt_title[i-1].setText(obj.item_list[i].item_name);
        }

        if(obj.type.compareTo("km") == 0){
            rbt5.setVisibility(View.VISIBLE);
            view_detail_odd_layout.setVisibility(View.VISIBLE);
        }
    }

    public void onActivityResult(int requestCode, int resultCode, Intent data) {
        if (requestCode == 1) {
            if (resultCode == (Activity.RESULT_OK)) {
                try {
                    InputStream in = ((MainActivity)getActivity()).getContentResolver().openInputStream(data.getData());
                    bit_img = BitmapFactory.decodeStream(in);
                    img = ""+System.currentTimeMillis()+ ".jpg";
                    in.close();
                    view_detail_icon_view.setImageBitmap(bit_img);
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }
    }

    private void saveBitmapToJpeg(Bitmap bitmap, String fileName) {
        File storage = ((MainActivity)getActivity()).getCacheDir();
        File tempFile = new File(storage, fileName);

        try {
            tempFile.createNewFile();
            FileOutputStream out = new FileOutputStream(tempFile);
            bitmap.compress(Bitmap.CompressFormat.JPEG, 100, out);
            out.close();
        }
        catch (FileNotFoundException e) {
            Toast.makeText(getContext(), "FileNotFoundException", Toast.LENGTH_SHORT).show();
        }
        catch (IOException e) {
            Toast.makeText(getContext(), "IOException", Toast.LENGTH_SHORT).show();
        }
    }
}