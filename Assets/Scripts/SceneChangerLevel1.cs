using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerLevel1 : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("Level1"); 
    }
}
