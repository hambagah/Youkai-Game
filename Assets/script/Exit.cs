using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    bool playerDetected;
    GameObject camera;
    public float playX, playY, playZ;
    public float camX, camY, camZ;

    void Start()
    {
        camera = GameObject.Find("Main Camera");
        playerDetected = false;
    }

    void Update()
    {
        if (playerDetected)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            playerDetected = true;
            col.transform.position = new Vector3(playX, playY, playZ);
            camera.transform.position = new Vector3(camX, camY, camZ);
        }
    }
}
