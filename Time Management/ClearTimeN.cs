using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearTimeN : MonoBehaviour
{
    private Text CTLabel;

    // Start is called before the first frame update
    void Start()
    {
        
        //Textコンポーネントにアクセス
        CTLabel = GetComponent<Text>();
        CTLabel.text = "Clear Time: " + TimeCountUpN.clearTimeN;
    }
}

