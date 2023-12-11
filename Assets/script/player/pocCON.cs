using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pocCON : MonoBehaviour{
    public GameObject Y;
    private bool isFunction1Active = true;
    //public GameObject X;

    public void OnButtonClickFunction1()
    {
        // Function 1 logic
        Debug.Log("Button clicked - Function 1");
        Y.SetActive(true);
    }

    public void OnButtonClickFunction2()
    {
        // Function 2 logic
        Debug.Log("Button clicked - Function 2");
        Y.SetActive(false);
    }
    public void OnButtonClick()
    {
        if (isFunction1Active)
        {
            // Function 1 logic (active)
            Debug.Log("Button clicked - Function 1 is active");
            isFunction1Active = false;
        }
        else
        {
            // Function 2 logic (active)
            Debug.Log("Button clicked - Function 2 is active");
            isFunction1Active = true;
        }
    }

}
