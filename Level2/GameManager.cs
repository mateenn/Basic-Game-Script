using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Door_anim NextLevel;

    public int nextLevel;
    public void GameOver()
    {
        Debug.Log("Game is Over");
        Invoke("RestartGame", 2f);
    }

    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Scene start again");

    }
    private void Start()
    {
        nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void Update() {
         if(NextLevel.nextLevel)
        {
            Debug.Log("Finally loading next level");
            SceneManager.LoadScene(nextLevel);
        }
    }
    // void nextSceneLoad()
    // {
       

    // }
}
