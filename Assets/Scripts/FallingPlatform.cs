using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public float fallingTime;

    private TargetJoint2D target;
    private BoxCollider2D boxColl;
    
        // Start is called before the first frame update
    void Start()
    {
        target = GetComponent<TargetJoint2D>();
        boxColl = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
        {
            {
        Invoke("Falling", fallingTime);
            }
        }

    void Falling()
    {
        target.enabled= false;
        boxColl.isTrigger = true;
    }

     void OnTriggerEnter2D(Collider2D collider) 
    {
        if(collider.gameObject.layer == 9)
        {            
                    Destroy(gameObject);
        }
    }
}
