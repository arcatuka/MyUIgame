using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
     private Rigidbody2D rb;
    public bool Ismoving;
    public GameObject Button;
     private Vector2 movement;
     public LayerMask solidObjectlayer;

    private void Start() {
        
         rb = GetComponent<Rigidbody2D>();
    }
     private void Update() {
         if(!Ismoving)
         {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(movement != Vector2.zero)
        {
            var targetPos = transform.position;
            targetPos.x += movement.x;
            targetPos.y += movement.y;

            if(Iswalkable(targetPos))   
            StartCoroutine(Move(targetPos));
        }
        }
    }

    IEnumerator Move(Vector3 tarPos)
    {
        Ismoving = true;
        while((tarPos -transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, tarPos, movespeed * Time.deltaTime);
            yield return null;
        }
        transform.position = tarPos;
        Ismoving = false;
    }

    private bool Iswalkable(Vector3 tarPos)
    {
        if(Physics2D.OverlapCircle(tarPos,0.2f,solidObjectlayer)!= null)
        {
            return false;
        }
        return true;
    }
}
