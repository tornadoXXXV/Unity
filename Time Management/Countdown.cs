using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    // public staticをつけることで、このScoreManagerスクリプトがついている他のオブジェクトと
    // scoreのデータを共有することができるようになります。
    public float time;
    private Text timeLabel;

    // Start is called before the first frame update
    void Start()
    {
        //Textコンポーネントにアクセス
        timeLabel = GetComponent<Text>();
        timeLabel.text = "" + time;
    }

    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            timeLabel.text = "" + Mathf.Round(time);
        }
        else
        {
            timeLabel.color = Color.Lerp(timeLabel.color, new Color(1, 1, 1, 0), 1.0f * Time.deltaTime);
        }
    }
}