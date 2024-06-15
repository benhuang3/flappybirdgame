using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject two_pipes_prefab; 
    public float spawnInterval = 2f; 
    public float pipespeed = 5f;

    private Camera mainCamera;
    private float timer = 0;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            // Debug.Log(timer);
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {

        // Vector3 screenCenter = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));
                
        // screenCenter.z = 0; // Set Z to 0 for 2D
        //                 Debug.Log("screenCenter: " + Camera.main.nearClipPlane);


        GameObject copy_two_pipes = Instantiate(two_pipes_prefab, new Vector3(10, 0, 0), Quaternion.identity);
        // if (new_x == 0){
        //     new_x = copy_two_pipes.transform.position.x + 10;
        // }
        // else{
        //     new_x = new_x + 10;
        // }
        // copy_two_pipes.transform.position = new Vector3(new_x, 0, 0);

        //, screenCenter, Quaternion.identity);
        GameObject pipe_top = copy_two_pipes.transform.GetChild(0).gameObject;
        GameObject pipe_bot = copy_two_pipes.transform.GetChild(1).gameObject;
        Rigidbody2D rb_top = pipe_top.GetComponent<Rigidbody2D>();
        Rigidbody2D rb_bot = pipe_bot.GetComponent<Rigidbody2D>();
        rb_top.velocity = new Vector2(-pipespeed, 0);
        rb_bot.velocity = new Vector2(-pipespeed, 0);

        Debug.Log(copy_two_pipes.transform.position);


        // Debug.Log("spawned pipe");
    }


}
