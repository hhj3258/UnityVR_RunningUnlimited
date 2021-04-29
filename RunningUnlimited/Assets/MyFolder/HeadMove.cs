using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMove : MonoBehaviour
{
    public GameObject mainCam;
    private float moveSpeed = 10.0f;

    private float runSpeed = 10.0f;
    private float positionX = 0f;
    private float accel = 0.5f;

    public float RunSpeed
    {
        set
        {
            runSpeed = value;
        }
    }
    public float Accel
    {
        set
        {
            accel = value;
        }
    }


    private void Start()
    {
        
        StartCoroutine(SpeedUp());
    }

    // Update is called once per frame
    void Update()
    {
        positionX = this.transform.position.x - mainCam.transform.rotation.z * moveSpeed / 90f;

        this.transform.position = new Vector3(positionX, this.transform.position.y, this.transform.position.z);
        Debug.Log(runSpeed);
        Run();
    }

    void Run()
    {
        this.transform.position += this.transform.forward * runSpeed * Time.deltaTime;
    }

    IEnumerator SpeedUp()
    {
        
        while (runSpeed < 13f)
        {
            yield return new WaitForSeconds(3.0f);

            runSpeed += accel;
        }
    }
}
