using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartH : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        PlayerHealth.destroyCount = 0;
        SceneManager.LoadScene("Hard");
    }
}
