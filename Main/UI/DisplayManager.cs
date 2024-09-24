using UnityEngine;

public class DisplayManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        for(int i = 0; i < Display.displays.Length; i++)
        {
            Display.displays[i].Activate();
        }
    }

}
