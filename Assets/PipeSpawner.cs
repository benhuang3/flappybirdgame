using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject parent_two_pipes; // The star prefab to instantiate
    public float spawnInterval = 1f; // Time interval between spawns
    public float pipespeed = 5f;

    private Camera mainCamera;
    private float timer;

    void Start()
    {
        SpawnPipe();
    }

    // void Update()
    // {
    //     timer -= Time.deltaTime;

    //     if (timer <= 0f)
    //     {
    //         SpawnStar();
    //         Debug.Log("printed");
    //         timer = spawnInterval;
    //     }
    // }

    void SpawnPipe()
    {

        Vector3 screenCenter = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, Camera.main.nearClipPlane));
        screenCenter.z = 0; // Set Z to 0 for 2D

        GameObject copy_two_pipes = Instantiate(parent_two_pipes);
        //, screenCenter, Quaternion.identity);

        // Rigidbody2D rb = pipes.GetComponent<Rigidbody2D>();

        // rb.velocity = new Vector2(-pipespeed, 0);
        Debug.Log("spawned pipe");
    }


}
