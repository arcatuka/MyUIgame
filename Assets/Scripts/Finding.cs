using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finding : MonoBehaviour
{
    [SerializeField]
    private GameObject button;
    public bool enablewrite = false;
    private GameObject Player;

    // public GameObject MenuUI;
    // public bool checking =false;
    // [SerializeField]
    // private float range;
    // private Player player;
    // public bool Inside=false;
    // private void Awake() {
    //     player = GetComponent<Player>();
    // }

    // Update is called once per frame
    // void Update()
    // {
    //     Collider2D[] collsArr=Physics2D.OverlapCircleAll(transform.position, range);
    //     foreach(Collider2D collider2D in collsArr)
    //     {
    //         if(collider2D.TryGetComponent<E>(out E enemy))
    //         {
    //             Inside = true;
                
    //         }
    //         else Inside = false;
    //     }
    // }
    // private void OnDrawGizmosSelected() {
    //     Gizmos.color = Color.blue;
    //     Gizmos.DrawWireSphere(transform.position, range);
    // }
    private void Start() {
        button.SetActive(false);
        // MenuUI.SetActive(false);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            button.SetActive(true);
            if( enablewrite == true)
            {
            foreach(Enemy enemy in EnemyManager.instance.Enemies )
            {
                if (other.gameObject.name == enemy.EnemyName)
                {
                   enemy.infoTaken = true;
                }
            }
            }
            
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.CompareTag("Enemy"))
        {
            button.SetActive(false);
            enablewrite = false;
            
        }
    }
    // private void Update() {
    //     if(Input.GetKeyUp(KeyCode.Z))
    //     {
    //         MenuUI.SetActive(true);
    //         Time.timeScale = 0f;
    //     }
    // }

    // public void Resume()
    // {
    //     MenuUI.SetActive(false);
    //     Time.timeScale =1f;

    // }
    // public void loadDeckScene()
    // {
    //     SceneManager.LoadScene(0);
    // }
    public void checking()
    {
        enablewrite = true;
    }


}
