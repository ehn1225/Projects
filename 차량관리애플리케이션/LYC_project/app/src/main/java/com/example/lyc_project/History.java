package com.example.lyc_project;

import java.io.Serializable;

public class History implements Serializable {
    public String date;
    public String text;
    public String file;

    public History(String date, String text, String file){
        this.date = date;
        this.text = text;
        this.file = file;
    }
}
