using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPreviousScene : MonoBehaviour
{
    private int prevSceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        prevSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(prevSceneToLoad);
    }
}
