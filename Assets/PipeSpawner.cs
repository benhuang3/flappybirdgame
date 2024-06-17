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

    public PlayerController PlayerController_PipeSpawner;

    public Queue<GameObject> activePipes = new Queue<GameObject>();



    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval && PlayerController_PipeSpawner.isAlive)
        {
            // Debug.Log(timer);
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float randomNumber = (float)Random.Range(35, 65) / 100; // Generates a random number between 1 and 10
    // Debug.Log("Random Number: " + randomNumber);

        Vector3 screenCenter = Camera.main.ViewportToWorldPoint(new Vector3(1.3f, randomNumber, Camera.main.nearClipPlane));
                
        screenCenter.z = 0; // Set Z to 0 for 2D

        GameObject copy_two_pipes = Instantiate(two_pipes_prefab, screenCenter, Quaternion.identity);
        GameObject pipe_top = copy_two_pipes.transform.GetChild(0).gameObject;
        GameObject pipe_bot = copy_two_pipes.transform.GetChild(1).gameObject;
        Rigidbody2D rb_top = pipe_top.GetComponent<Rigidbody2D>();
        Rigidbody2D rb_bot = pipe_bot.GetComponent<Rigidbody2D>();
        rb_top.velocity = new Vector2(-pipespeed, 0);
        rb_bot.velocity = new Vector2(-pipespeed, 0);

        activePipes.Enqueue(copy_two_pipes);
        StartCoroutine(DeletePipe(copy_two_pipes));
    }

    IEnumerator DeletePipe(GameObject delete_pipe)
    {
        // Executes the first line of code
        yield return new WaitForSeconds(5);
        Debug.Log("Pipe Deleted");
        Destroy(delete_pipe);
        activePipes.Dequeue();


    }


}
