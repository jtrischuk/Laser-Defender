using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    [SerializeField] float delayInSeconds = 2f;

    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        FindObjectOfType<GameSession>().ResetGame();
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver()
    {

        StartCoroutine(WaitBeforeLoading());
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator WaitBeforeLoading()
    {

        yield return new WaitForSeconds(delayInSeconds);

        SceneManager.LoadScene("Game Over");

        
    }
}
