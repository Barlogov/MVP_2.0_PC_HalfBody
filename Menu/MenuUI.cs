using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    async public void UI_ConnectToTheServer()
    {
        NetworkConnection connection = NetworkConnection.getInstance();
        if (await connection.ConnectToTheServer())
        {
            SceneManager.LoadScene("MainScene");
        } else
        {
            Debug.Log(this + ": Could not load the scene");
        }
       
        
    }
}
