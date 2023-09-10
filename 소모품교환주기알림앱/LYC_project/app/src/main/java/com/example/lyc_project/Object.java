package com.example.lyc_project;

import java.io.Serializable;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;

public class Object implements Serializable {
    public String id;
    public String name;
    public int icon;
    public String next;
    public String before;
    public String last_modify;
    public String type;
    public Item [] item_list;
    public ArrayList<History> history_list;

    public Object(String id){
        this.id = id;
        item_list = new Item[4];
        history_list = new ArrayList<History>();
    }

    public void Refresh() {
        //next, brefore를 연산함.
        String next = "";
        int item_count = 0, index = 1;
        for (int i = 1; i < 4; i++) {
            if (item_list[i] == null) continue;//아이템이 없으면 넘어감
            item_count++;
            index = i;
        }

        if (item_count == 1)
            next = item_list[index].get_Item_next();
        else {
            if (type.compareTo("km") == 0) {//km단위
                int i_next = 0x0fffffff;//임의의 MAX
                for (int i = 1; i < 4; i++) {
                    if (item_list[i] == null) continue;//아이템이 없으면 넘어감
                    if (i_next > Integer.parseInt(item_list[i].get_Item_next()))
                        i_next = Integer.parseInt(item_list[i].get_Item_next());
                }
                next = "" + i_next;
            }
            else {//month 단위
                SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd");
                try{
                    Date date = dateFormat.parse("2999-12-31");
                    for (int i = 1; i < 4; i++) {
                        if (item_list[i] == null) continue;//아이템이 없으면 넘어감
                        Date day2 = dateFormat.parse(item_list[i].get_Item_next());
                        if (date.compareTo(day2) > 0 )
                            date = day2;
                    }
                    next = dateFormat.format(date.getTime());
                }
                catch(ParseException e){
                    e.printStackTrace();
                }
            }
        }
        this.next = next;
    }
}