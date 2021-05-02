using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class trashSystemTrigger : MonoBehaviour
{
      [SerializeField]
    private Image trashCanButton;

    [SerializeField]
    private Image throwTrashButton;

    public GameObject trashCanCutscene;

    public GameObject thorwTrashCutscene;

    public GameObject selfTrashTrigger;

    public GameObject finalMissionTrigger;

    public GameObject colaCan;

    public GameObject thePlayer;

    //public GameObject sitDrinkCutscene;

    private Player playerInput;

    private void Awake()
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
       trashCanButton.enabled = true;
       throwTrashButton.enabled = true;
        Debug.Log("Enabling the Button");
        }
    }

     void OnTriggerExit(Collider other)
     {
      trashCanButton.enabled = false;
      throwTrashButton.enabled = false;
      
     }

     void gameContiue()
     {
         thePlayer.SetActive(true);
         trashCanCutscene.SetActive(false);
          trashCanButton.enabled = false;
          thorwTrashCutscene.SetActive(false);
       throwTrashButton.enabled = false;
         selfTrashTrigger.SetActive(false);
         finalMissionTrigger.SetActive(true);
     }
     void Update()
    {
        
      
        if(playerInput.Level2.trashCan.triggered)
        {
            colaCan.SetActive(false);
            thePlayer.SetActive(false);
            trashCanCutscene.SetActive(true);
            Invoke("gameContiue", 3.3f);
        
            Debug.Log("Trash Can Enabled");

        }
         if(playerInput.Level2.throwTrash.triggered)
        {
            colaCan.SetActive(false);
            thePlayer.SetActive(false);
            thorwTrashCutscene.SetActive(true);
            Invoke("gameContiue", 5f);
            Debug.Log("Throw Trash Enabled");

        }
       
    }
}
