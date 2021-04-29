using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{

    public TextMeshProUGUI textUi;
    public TextMeshProUGUI textUi2;
    public Image back;
    public TextMeshProUGUI restartTime;
    float aliveTime = 0f;

    private void Start()
    {
        textUi2.enabled = false;
        back.enabled = false;
        restartTime.enabled = false;
    }

    
    float cntDown = 0f;
    float gauge=0;
    // Update is called once per frame
    void Update()
    {
        aliveTime += Time.deltaTime;
        //Debug.Log(aliveTime);
        textUi.text = aliveTime.ToString();

        cntDown -= Time.deltaTime;
        restartTime.text = (int)cntDown +"";

        if (back.fillAmount == 1)
        {
            back.fillAmount = 0;
        }
        back.fillAmount += 1f/3f * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("Obstacle"))
        {
            textUi2.text = textUi.text;
            textUi.enabled = false;
            textUi2.enabled = true;
            back.enabled = true;
            restartTime.enabled = true;
            cntDown = 4f;
            back.fillAmount = 0;
        }
    }
}