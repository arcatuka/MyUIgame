using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyinBattle : MonoBehaviour
{
    public static EnemyinBattle instance;
    // Start is called before the first frame update
    private void Awake() {
        if(instance == null)
        {
            instance = this;
        }
        else
        if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public int positionEmanage=0;

}
