using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelSelector : MonoBehaviour
{
    public void Village()
    {
        SceneManager.LoadScene("Village");
    }

    public void Forest()
    {
        SceneManager.LoadScene("Forest");
    }

    public void Castle()
    {
        SceneManager.LoadScene("Castle");
    }
}
