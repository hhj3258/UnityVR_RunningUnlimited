using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public TextMeshProUGUI textUi;
    //public GameObject player;
    private HeadMove HM;
    // Start is called before the first frame update
    void Start()
    {
        HM = FindObjectOfType<HeadMove>();
        textUi.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Obstacle"))
        {

            HM.RunSpeed = 0;
            HM.Accel = 0;
            textUi.enabled = true;

            StartCoroutine(WaitThree());

        }
    }

    IEnumerator WaitThree()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(0);
    }

}
