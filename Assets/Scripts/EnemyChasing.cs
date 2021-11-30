using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyChasing : MonoBehaviour
{
    private SpriteRenderer sprite;
    public GameObject Enemy;
    private void Start() {
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update() {
       sprite.sprite= EnemyManager.instance.Enemies[EnemyinBattle.instance.positionEmanage-1].EnemySprite1;
    }
}
