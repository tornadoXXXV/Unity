using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class title2explain : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("explain");
    }
}
