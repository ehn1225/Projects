package com.example.lyc_project.ui.notifications;

import android.app.AlertDialog;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentActivity;
import androidx.lifecycle.Observer;
import androidx.lifecycle.ViewModelProviders;
import androidx.navigation.Navigation;

import com.example.lyc_project.MainActivity;
import com.example.lyc_project.R;

import org.w3c.dom.Text;

import java.io.File;
import java.util.ArrayList;

public class NotificationsFragment extends Fragment {

    TextView notification_dev_info;
    TextView item_list_show, item_list_delete, item_image_show, item_image_delete, item_all_delete;
    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
        View view = inflater.inflate(R.layout.fragment_notifications, container, false);
        notification_dev_info = (TextView)view.findViewById(R.id.notification_dev_info);
        item_list_show = (TextView)view.findViewById(R.id.item_list_show);
        item_list_delete = (TextView)view.findViewById(R.id.item_list_delete);
        item_image_show = (TextView)view.findViewById(R.id.item_image_show);
        item_image_delete = (TextView)view.findViewById(R.id.item_image_delete);
        item_all_delete = (TextView)view.findViewById(R.id.item_all_delete);

        notification_dev_info.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                View historyView = (View)View.inflate(getActivity(), R.layout.dev_info,null);
                AlertDialog.Builder dlg = new AlertDialog.Builder(getActivity());
                dlg.setTitle("개발정보");
                dlg.setView(historyView);
                dlg.setNegativeButton("닫기",null);
                dlg.show();
            }
        });
        item_image_show.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                PrintFile(new File(((MainActivity)getActivity()).getCacheDir().toString()));
            }
        });

        item_list_show.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                PrintFile(new File(((MainActivity)getActivity()).getFilesDir().toString()));
            }
        });

        item_image_delete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                clearFile(((MainActivity)getActivity()).getCacheDir());
                Toast.makeText(getContext(), "전체 이미지파일 삭제완료", Toast.LENGTH_SHORT).show();
            }
        });
        item_list_delete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                clearFile(((MainActivity)getActivity()).getFilesDir());
                Toast.makeText(getContext(), "전체 아이템파일 삭제완료", Toast.LENGTH_SHORT).show();
            }
        });
        item_all_delete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                clearFile(((MainActivity)getActivity()).getFilesDir());
                clearFile(((MainActivity)getActivity()).getCacheDir());
                Toast.makeText(getContext(), "전체파일 삭제완료", Toast.LENGTH_SHORT).show();
            }
        });

        return view;
    }
    public void onResume() {
        super.onResume();
        FragmentActivity activity = getActivity();
        if (activity != null) {
            ((MainActivity) activity).setActionBarTitle("Setting");
        }
    }
    private void PrintFile(File file) {
        if (null != file) {
            String list="";
            File[] files = file.listFiles();

            for(File tempFile : files)
                list += tempFile.getName() + "\n";
            Toast.makeText(getContext(), (list.compareTo("") == 0)? "파일없음" : list, Toast.LENGTH_SHORT).show();
        }
    }

    private void clearFile(File cacheDirFile) {
        if (null != cacheDirFile && cacheDirFile.isDirectory()) {
            clearSubFiles(cacheDirFile);
        }
    }
    private void clearSubFiles(File cacheDirFile) {
        if (null == cacheDirFile || cacheDirFile.isFile()) return;
        for (File cacheFile : cacheDirFile.listFiles()) {
            if (cacheFile.isFile()) {
                if (cacheFile.exists()) {
                    cacheFile.delete();
                }
            } else {
                clearSubFiles(cacheFile);
            }
        }
    }
}
