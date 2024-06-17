using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController PlayerController_CollisionScript;
    public PipeSpawner PipeSpawner_CollisionScript;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)  
    {
        Debug.Log(collision.gameObject);
        if (collision.gameObject.layer == LayerMask.NameToLayer("pipes"))
        {   
            Debug.Log("dead");
            PlayerController_CollisionScript.isAlive  = false;
            foreach (GameObject i in PipeSpawner_CollisionScript.activePipes)
            {
                GameObject pipe_top = i.transform.GetChild(0).gameObject;
                GameObject pipe_bot = i.transform.GetChild(1).gameObject;
                Rigidbody2D rb_top = pipe_top.GetComponent<Rigidbody2D>();
                Rigidbody2D rb_bot = pipe_bot.GetComponent<Rigidbody2D>();
                rb_top.velocity = new Vector2(0, 0);
                rb_bot.velocity = new Vector2(0, 0);
            }
        }
        // if (collision.gameObject.layer == LayerMask.NameToLayer("pipes"))
        // {   
        //     Debug.Log("hit pipe");
        // }
    }
 
}
