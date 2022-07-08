using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MenuScript : MonoBehaviour
{
    [Header("Text Boxes")]
    public TMP_Text titleTextbox;
    public TMP_Text creditsTextbox;
    public TMP_Text copyrightTextbox;
    public TMP_Text messageTextbox;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnGameStart()
    {
        Debug.Log("Game Started");
    }

    public void OnGameExit()
    {
        Debug.Log("Exited Game");
    }
    // Update is called once per frame

}
