using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartE : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        PlayerHealth.destroyCount = 0;
        TimeCountUpE.clearTime = 0;
        TimeCountUpN.clearTimeN = 0;
        SceneManager.LoadScene("Easy");
    }
}
