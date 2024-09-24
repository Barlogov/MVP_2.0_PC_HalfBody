using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debug_UI : MonoBehaviour
{
    public Text fps_text;

    public int tagrgetFPS = 60;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
        Application.targetFrameRate = tagrgetFPS;
    }

    private void Update()
    {
        fps_text.text = $"FPS: {(int)(1f / Time.unscaledDeltaTime)}";
    }

    public void UI_LimitFPS(bool isLimited)
    {
        if (isLimited)
        {
            Application.targetFrameRate = tagrgetFPS;
        } else
        {
            Application.targetFrameRate = -1;
        }
        
    }

}
