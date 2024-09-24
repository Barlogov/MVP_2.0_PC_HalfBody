using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPossitionsSetting : MonoBehaviour
{

    public Slider Slider;
    public Text SliderText;

    public Transform CameraPos;


    private void Update()
    {
        CameraPos.position =  new Vector3(CameraPos.position.x, Slider.value, CameraPos.position.z);
        SliderText.text = Slider.value.ToString();
    }

}
