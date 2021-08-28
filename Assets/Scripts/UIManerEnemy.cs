using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManerEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    //public EnemyManager EManer;
    public GameObject Slot;
    //private UIManager Enemyinfo;

    private void Update() {
        DisplayCard();
    }

    private void DisplayCard()
    {
        Slot.transform.GetChild(0).GetComponent<Image>().sprite= EnemyManager.instance.Enemies[EnemyManager.instance.currentIndex-1].EnemySprite;
            //CardSlots[i].transform.GetChild(0).GetComponent<Image>().sprite= EManer.Enemies[i].EnemySprite;
            //CardSlots[i].transform.GetChild(1).GetComponent<Text>().text= EManer.Enemies[i].EnemyName;
        Slot.transform.GetChild(1).GetComponent<Text>().text= EnemyManager.instance.Enemies[EnemyManager.instance.currentIndex-1].EnemyName;
        Slot.transform.GetChild(2).GetComponent<TextMeshProUGUI>().text= EnemyManager.instance.Enemies[EnemyManager.instance.currentIndex-1].EnemyDes;
    }
}
