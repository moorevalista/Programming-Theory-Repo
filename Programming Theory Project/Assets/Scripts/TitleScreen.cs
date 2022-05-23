using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TitleScreen : MonoBehaviour
{
    public TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNew() {
        SceneManager.LoadScene(1);
        Debug.Log("Your name : " + playerName.text);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)) {
            StartNew();
        }
    }
}
