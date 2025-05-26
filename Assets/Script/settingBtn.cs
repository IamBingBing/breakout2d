using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class settingBtn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Slider slider;
    public TextMeshProUGUI slidertext;
    void Start()
    {
        slider.gameObject.SetActive(false);
        slidertext.gameObject.SetActive(false);
    }
    public void settingvisual()
    {
        slider.gameObject.SetActive(!slider.gameObject.activeSelf);
        slidertext.gameObject.SetActive(!slidertext.gameObject.activeSelf);
    }
    
}
