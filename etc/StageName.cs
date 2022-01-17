using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageName : MonoBehaviour
{
    private Text stageNameText;

    // Start is called before the first frame update
    void Start()
    {
        stageNameText = this.gameObject.GetComponent<Text>();

        stageNameText.text = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        stageNameText.color = Color.Lerp(stageNameText.color, new Color(1, 1, 1, 0), 1.0f * Time.deltaTime);
    }
}
