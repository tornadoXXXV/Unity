using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestTime : MonoBehaviour
{
    private Text BCTLabel;
    public float bestTimeE = 0;
    public float bestTimeN = 0;

    // Start is called before the first frame update
    void Start()
    {
        bestTimeE = PlayerPrefs.GetFloat("TIME_E", 0);
        bestTimeN = PlayerPrefs.GetFloat("TIME_N", 0);
        BCTLabel = GetComponent<Text>();
        
        if (TimeCountUpE.clearTime > TimeCountUpN.clearTimeN)
        {
            if (bestTimeE > TimeCountUpE.clearTime || bestTimeE == 0)
            {
                bestTimeE = TimeCountUpE.clearTime;
                PlayerPrefs.SetFloat("TIME_E", bestTimeE);
                PlayerPrefs.Save();
            }
            BCTLabel.text = "Best Time: " + bestTimeE;
        }

        else 
        {
            if (bestTimeN > TimeCountUpN.clearTimeN || bestTimeN == 0)
            {
                bestTimeN = TimeCountUpN.clearTimeN;
                PlayerPrefs.SetFloat("TIME_N", bestTimeN);
                PlayerPrefs.Save();
            }
            BCTLabel.text = "Best Time: " + bestTimeN;
        }
        // PlayerPrefs.DeleteAll();
        // Debug.Log(bestTimeE);
    }
}
