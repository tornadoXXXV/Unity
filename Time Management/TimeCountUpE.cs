using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountUpE : MonoBehaviour
{
    private OriEnemyHealth eh;
    public static float clearTime = 0;
    private Text timeLabel;

    void Start()
    {
        eh = GameObject.Find("chou").GetComponent<OriEnemyHealth>();

        //Textコンポーネントにアクセス
        timeLabel = GetComponent<Text>();
        timeLabel.text = "" + clearTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (eh.enemyHP > 0)
        {
            clearTime += Time.deltaTime;
            timeLabel.text = "Time: " + clearTime;
        }  
    }
}
