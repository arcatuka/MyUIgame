using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIMenu : MonoBehaviour
{
    public GameObject MenuUI;
    void Start()
    {
        MenuUI.SetActive(false);
    }

        private void Update() {
        if(Input.GetKeyUp(KeyCode.Z))
        {
            MenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Resume()
    {
        MenuUI.SetActive(false);
        Time.timeScale =1f;

    }
    public void loadDeckScene()
    {
        SceneManager.LoadScene(0);
    }
}
