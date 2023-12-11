using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swipe_manager : MonoBehaviour{
    public GameObject scrollbar;
    float scrollpos = 0;
    float[] pos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        pos = new float[transform.childCount];
        //creating smooth transition between array
        float distance = 1f/(pos.Length-1f);
        for(int i = 0; i<pos.Length; i++){
            pos[i] = distance*i;
        }
        //end smooth

        if(Input.GetMouseButton(0)){
            scrollpos = scrollbar.GetComponent<Scrollbar> ().value;
        }else{
            for(int i=o; i<pos.Length; i++){
                if(scrollpos<pos[i]+(distance/2) && scrollpos>pos[i]-(distance/2)){
                    scrollbar.GetComponent<Scrollbar>
                }
            }
        }
    }
}
