using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sens : MonoBehaviour
{
    public float speed = 3.0f;
    public float chamgeTime = 3.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
      rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         timer -= Time.deltaTime;

        if(timer < 0)
        {
            direction = -direction;
            timer = chamgeTime;
        }
    }
    private void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        
            position.x = position .x + Time.deltaTime * speed * direction;
       
        rigidbody2D.MovePosition(position);
    }
}
