using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class senstiveslider : MonoBehaviour
{
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        slider.onValueChanged.AddListener(delegate { setSensitive(); });    
    }



    void setSensitive()
    {
        GameManager.Instance.sensitive = slider.value;
        
    }
    
}
