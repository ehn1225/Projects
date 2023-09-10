package com.example.lyc_project;

import android.content.Context;
import android.os.Bundle;
import android.widget.TextView;
import androidx.appcompat.app.ActionBar;
import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.widget.Toolbar;
import androidx.lifecycle.ViewModelProviders;
import androidx.navigation.NavController;
import androidx.navigation.Navigation;
import androidx.navigation.ui.AppBarConfiguration;
import androidx.navigation.ui.NavigationUI;
import com.example.lyc_project.ui.dashboard.DashboardViewModel;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Locale;

public class MainActivity extends AppCompatActivity {
    TextView toolbar_title;
    DashboardViewModel model;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        toolbar_title = (TextView)findViewById(R.id.toolbar_title);
        model = ViewModelProviders.of(this).get(DashboardViewModel.class);

        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        BottomNavigationView navView = findViewById(R.id.nav_view);
        AppBarConfiguration appBarConfiguration = new AppBarConfiguration.Builder(R.id.navigation_home, R.id.navigation_dashboard, R.id.navigation_notifications).build();
        NavController navController = Navigation.findNavController(this, R.id.nav_host_fragment);
        NavigationUI.setupActionBarWithNavController(this, navController, appBarConfiguration);
        NavigationUI.setupWithNavController(navView, navController);
        ActionBar actionBar = getSupportActionBar();
        actionBar.setDisplayShowTitleEnabled(false); // 기존 title 지우기

    }

    public void setActionBarTitle(String title) {
            toolbar_title.setText(title);
    }

    public boolean saveobj(){//메모리에 있는 Object 저장
        Object obj = model.getObject();
        try{
            FileOutputStream fout = openFileOutput(obj.id+".bin", Context.MODE_PRIVATE);
            ObjectOutputStream os = new ObjectOutputStream(fout);
            os.writeObject(obj);
            os.close();
            fout.close();
            return true;
        }
        catch (Exception e){
            e.printStackTrace();
        }
        return false;
    }

    public boolean loadobj(String obj_id){//메모리에 Object 올림
        Object obj;
        String filename = obj_id + ".bin";
        if(isExist(filename)) {
            try {
                FileInputStream fin = openFileInput(filename);
                ObjectInputStream os = new ObjectInputStream(fin);
                obj = (Object) os.readObject();
                if(obj.type.compareTo("month") == 0)
                    obj.item_list[0].criteria = getDate();
                model.setObject(obj);
                return true;
            }catch (Exception e) {
                e.printStackTrace();
                return false;
            }
        }
        model.setObject(new Object(obj_id));
        return true;
    }

    public boolean isExist(String filename){
        String fileChk = "/data/data/com.example.lyc_project/files/" + filename;
        File file = new File(fileChk);
        return file.exists();
    }

    public String getDate(){
        Date currentTime = Calendar.getInstance().getTime();
        String date_text = new SimpleDateFormat("yyyy-MM-dd", Locale.getDefault()).format(currentTime);
        return date_text;
    }

}
