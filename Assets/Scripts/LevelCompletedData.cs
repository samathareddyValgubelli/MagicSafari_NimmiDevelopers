using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompletedData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameUI.Instance.levelNumber += 1;
    }

    public void OnClickRestart()
    {
        Scene scene = SceneManager.GetActiveScene();

        SceneManager.LoadScene(scene.name);
    }

    public void OnClickNext()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadSceneAsync(sceneIndex + 1);

    }
}
