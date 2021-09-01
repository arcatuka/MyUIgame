using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class UIMenu : MonoBehaviour
{
    public GameObject MenuUI;
    private FoxMove Player;
    void Start()
    {
        MenuUI.SetActive(false);
        Player = FindObjectOfType<FoxMove>();
    }

        private void Update() {
        if(Input.GetKeyUp(KeyCode.Z))
        {
            MenuUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void SaveScene()
    {
        SavedgameJSON();
    }
    public void Resume()
    {
        LoadgameJSON();
        MenuUI.SetActive(false);
        Time.timeScale =1f;

    }
    public void loadDeckScene()
    {
        
        SceneManager.LoadScene(0);
    }

    private Save saveFoxPos()
    {
        Save save = new Save();

        save.playerXpos = Player.transform.position.x;
        save.playerYpos = Player.transform.position.y;


        return save;
    }
        private void SavedgameJSON()
    {
        Save save = saveFoxPos();

        string JsonString = JsonUtility.ToJson(save);

        StreamWriter sw = new StreamWriter(Application.dataPath + "/JSONdata.text");
        sw.Write(JsonString);
        sw.Close();
        Debug.Log("-=-=-=SAVED=-=-=-");
    }

    private void LoadgameJSON()
    {
        if(File.Exists(Application.dataPath + "/JSONdata.text"))
        {
            StreamReader sr = new StreamReader(Application.dataPath+ "/JSONdata.text");
            string JsonString = sr.ReadToEnd();
            sr.Close();
            Save save = JsonUtility.FromJson<Save>(JsonString);
            Player.transform.position = new Vector2(save.playerXpos,save.playerYpos);
        }
    }
 
}
   [System.Serializable]
    public class Save
    {
        public float playerXpos;
        public float playerYpos;

    
    }
