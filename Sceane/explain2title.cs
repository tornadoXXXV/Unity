using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class explain2title : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("title");
    }
}
