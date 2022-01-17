using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountUpN : MonoBehaviour
{
    private EnemyHealth eh;
    public static float clearTimeN = 0;
    private Text timeLabel;

    void Start()
    {
        eh = GameObject.Find("MeteorShooter").GetComponent<EnemyHealth>();

        //Textコンポーネントにアクセス
        timeLabel = GetComponent<Text>();
        timeLabel.text = "" + clearTimeN;
    }

    // Update is called once per frame
    void Update()
    {
        if (eh.enemyHP > 0)
        {
            clearTimeN += Time.deltaTime;
            timeLabel.text = "Time: " + clearTimeN;
        }  
    }
}
