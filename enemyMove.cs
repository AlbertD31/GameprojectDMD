using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{


    Rigidbody2D body2D;

    [Range (0.0f, 10.0f)]
    public float enemySpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        Vector2 velocity = new Vector2(enemySpeed, 0);
        
    }

    // Update is called once per frame
    void Update()
    {

        body2D.velocity = new Vector2(transform.localScale.x, 0) * enemySpeed;
       

    }
}
