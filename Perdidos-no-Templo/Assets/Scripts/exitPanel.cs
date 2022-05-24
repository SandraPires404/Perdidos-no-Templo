using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitPanel : MonoBehaviour
{

    public void showExitPanel (GameObject panel)
    {
        panel.SetActive (true);
    }
    public void hideExitPanel(GameObject panel)
    {
        panel.SetActive(false);
    }

    public void showSmokeyBackground(GameObject bg)
    {
        bg.SetActive(true);
    }

    public void hideSmokeyBackground(GameObject bg)
    {
        bg.SetActive(false);
    }


    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
