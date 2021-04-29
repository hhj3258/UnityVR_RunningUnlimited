using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMap : MonoBehaviour
{
    private Transform playerPosition;
    float delay = 0f;
    private void Start()
    {
        playerPosition = GameObject.Find("Head").transform;
    }
    void Update()
    {
        delay += Time.deltaTime;
        if (playerPosition.position.z > this.gameObject.transform.position.z + 50)
            Destroy(this.gameObject);
    }
}
