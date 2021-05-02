using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacleTrigger : MonoBehaviour
{
    [SerializeField]
    private Image obstacleRemoverButton;

    public GameObject obstacleRemoveCutscene;

    public GameObject selfTrigger;

    public GameObject mainPlayer;
    public GameObject obstacle;

    public bool nextLevel;

    private Player playerInput;

    void Awake()
    {
        playerInput = new Player();
        
    }
      private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
      void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            obstacleRemoverButton.enabled = true;
        }
    }

     void OnTriggerExit(Collider other)
     {
         obstacleRemoverButton.enabled = false;
    
      
     }
 
     void Update()
    {
        
      
        if(playerInput.Level2.removeObstacle.triggered)
        {
            Debug.Log("Obstacle Remover Button is trigger");
             obstacleRemoverButton.enabled = false;
            mainPlayer.SetActive(false);
            obstacle.SetActive(false);
            obstacleRemoveCutscene.SetActive(true);
            Invoke("loadNextLevel",13f);

        }
    }
    
     public void loadNextLevel()
     {
         nextLevel = true;
         Debug.Log("Loading Next Level");
         mainPlayer.SetActive(true);
         obstacleRemoveCutscene.SetActive(false);
         selfTrigger.SetActive(false);

     }
}
