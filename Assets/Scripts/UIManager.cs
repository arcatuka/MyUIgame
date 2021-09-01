using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public class UIManager : MonoBehaviour
{
    //public static UIManager instance;
    // Start is called before the first frame update
    
    public GameObject[] CardSlots;
    private FoxMove Player;


    // private void Awake() {
    //     if (instance == null)
    //     {
    //         instance= this;
    //     }
    //     else if ( instance != this)
    //     {
    //         Destroy(gameObject);
    //     }
    //     DontDestroyOnLoad(gameObject);
    // }

    private void Start() {
        DisplayCard();
    }

    private void DisplayCard()
    {
        for(int i = 0; i< EnemyManager.instance.Enemies.Count; i++)
        {
            CardSlots[i].transform.GetChild(0).GetComponent<Image>().sprite= EnemyManager.instance.Enemies[i].EnemySprite1;
            CardSlots[i].transform.GetChild(1).GetComponent<Text>().text= EnemyManager.instance.Enemies[i].EnemyDes1;

            if(EnemyManager.instance.Enemies[i].InfoTaken == false)
            {
                CardSlots[i].transform.GetChild(0).GetComponent<Image>().color= new Color(0,0,0) ;
            }
            else if (EnemyManager.instance.Enemies[i].InfoTaken == true)
            {
                CardSlots[i].transform.GetChild(0).GetComponent<Image>().color= new Color(255,255,255) ;

            }
        }
    }
    
    public void SelectCharacter(int _id)
    {
        if(EnemyManager.instance.Enemies[_id-1].InfoTaken == true)
        {
            EnemyManager.instance.currentIndex = _id;
            SceneManager.LoadScene(1);
        }
    }


    public void backList()
    {
        SceneManager.LoadScene(0);
    }

    public void gameMenu()
    {
        SceneManager.LoadScene(2);
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
            
        }
    }
}
