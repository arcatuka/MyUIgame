using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;
    public int currentIndex;
    public List<Enemy> Enemies = new List<Enemy>();

    private void Start() {
        currentIndex = 0;
    }
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
}
