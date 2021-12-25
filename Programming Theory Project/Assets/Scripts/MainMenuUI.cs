using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class MainMenuUI : MonoBehaviour
{
    public string stringName;
    public TMP_InputField nameInput;
    public KeyCode Enterkey;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        stringName = nameInput.text;
        if(Input.GetKeyDown(Enterkey)){
            SceneManager.LoadScene(1); 
            this.gameObject.SetActive(false);
        }
        
    }
    
}
