using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public AudioClip clearSound;
    public float time;
    private Text timeLabel;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Textコンポーネントにアクセス
        timeLabel = GetComponent<Text>();
        timeLabel.text = "Time: " + time;
    }

    void Update()
    {
        if (time >= 0)
        {
            time -= Time.deltaTime;
            timeLabel.text = "Time: " + Mathf.Round(time);
        }

        else 
        {
            if (count == 0)
            {
                count += 1;
                AudioSource.PlayClipAtPoint(clearSound, Camera.main.transform.position);
                Invoke("StageClear", 2.0f);
            }
        }    
    }

    void StageClear()
    {
        SceneManager.LoadScene("ClearH");
    }
}