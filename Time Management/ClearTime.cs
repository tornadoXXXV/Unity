using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTime : MonoBehaviour
{
    private Text CTLabel;

    // Start is called before the first frame update
    void Start()
    {
        //Textコンポーネントにアクセス
        CTLabel = GetComponent<Text>();
        if (TimeCountUpE.clearTime > TimeCountUpN.clearTimeN)
        {
            CTLabel.text = "Clear Time: " + TimeCountUpE.clearTime;
        }

        else 
        {
            CTLabel.text = "Clear Time: " + TimeCountUpN.clearTimeN;
        }
        
    }
}
