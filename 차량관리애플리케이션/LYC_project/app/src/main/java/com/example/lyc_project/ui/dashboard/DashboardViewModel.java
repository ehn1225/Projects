package com.example.lyc_project.ui.dashboard;

import android.widget.Toast;

import androidx.lifecycle.ViewModel;

import com.example.lyc_project.Object;

public class DashboardViewModel extends ViewModel {
    public Object on_process_obj;
    public int pos;

    public void setObject(Object obj) {
        on_process_obj = obj;
    }

    public Object getObject() {
        return on_process_obj;
    }

    public void setPos(int pos) {
        this.pos = pos;
    }

    public int getPos() {
        return pos;
    }
}