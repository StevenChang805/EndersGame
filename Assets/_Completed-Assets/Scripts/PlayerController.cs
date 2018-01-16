using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    
    private Rigidbody2D rb2d;
    
    void Start () 
    {
        rb2d = GetComponent<Rigidbody2D> ();
        Random rnd = new Random();
        int x = rnd.next(-12.5, 12.5);
        int y = rnd.next(-12.5, 12.5);
        this.transform.position = new Vector2(x, y);
    }
    
    void FixedUpdate() 
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce (movement * speed);
    }
}
