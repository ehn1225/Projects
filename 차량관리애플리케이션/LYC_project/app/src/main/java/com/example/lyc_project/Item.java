package com.example.lyc_project;

import java.io.Serializable;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

public class Item implements Serializable {
    public String item_name;
    public String criteria; //km은 integer, month는 date //지닌작업 일자
    public int item_cycle;

    public Item(){
        item_name = "미등록";
        criteria = "";
        item_cycle = 0;
    }

    public Item(String item_name, String criteria, int item_cycle){//신규용
        this.item_name = item_name;
        this.criteria = criteria;
        this.item_cycle = item_cycle;
    }
    public void updateItem(String item_name, int item_cycle){//수정용, 수정할때 기준일자는 변경하면 안됨
        this.item_name = item_name;
        this.item_cycle = item_cycle;
    }

    public String get_Item_next(){
        String next = "";
        try{
            int criteria = Integer.parseInt(this.criteria);
            next = "" + (criteria + item_cycle);
        }
        catch (java.lang.NumberFormatException e){
            try{
                Calendar cal = Calendar.getInstance();
                SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
                Date date = sdf.parse(this.criteria);
                cal.setTime(date);
                cal.add(Calendar.MONTH, item_cycle);
                next = sdf.format(cal.getTime());
            }
            catch (ParseException f){
                f.printStackTrace();
            }
        }
        catch (Exception e){
            e.printStackTrace();
        }
        return next;
    }
}
