using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class startButton : MonoBehaviour
{
    public GameObject mainMenu;

    public void startGame()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1f;
    }

}
