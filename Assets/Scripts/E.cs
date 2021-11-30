using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E : MonoBehaviour
{
    // Start is called before the first frame update
    public float EnemyDistance;
    public float speed;
    private Transform player;
   // public static Sprite enemybattlesprite = null;

    private void Start() {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    private void Update() {
        float distancefromPlayer =Vector2.Distance(player.position, transform.position);
        if (distancefromPlayer < EnemyDistance)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.position, speed * Time.deltaTime);
        }
    }
    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, EnemyDistance);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        for(int i = 0; i< EnemyManager.instance.Enemies.Count; i++)
        {

        }
        if(other.CompareTag("Player"))
        {
            for(int i = 0; i< EnemyManager.instance.Enemies.Count; i++)
            {
                if(this.gameObject.name == EnemyManager.instance.Enemies[i].EnemyName1)
                {
                    EnemyinBattle.instance.positionEmanage =EnemyManager.instance.Enemies[i].EID1 ;
                }
            }
            SceneManager.LoadScene(3);
        }
    }
}
