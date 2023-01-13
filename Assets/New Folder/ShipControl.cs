using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
     rigidbody2d = GetComponent<Rigidbody2D>();
    }
    

     void Update()
    
     {
        horizontal = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.C))
        {
            Launch();
        }
        
    }

    void FixedUpdate() 
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 5f * horizontal * Time.deltaTime;
       rigidbody2d.MovePosition(position);
        
    }

    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        Bonebullet projectile = projectileObject.GetComponent<Bonebullet>();
        projectile.Launch(new Vector2(0,1), 300);

        
    }
}
