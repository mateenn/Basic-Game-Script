using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drinkTrigger : MonoBehaviour
{
    [SerializeField]
    private Image sitDrink;

    [SerializeField]
    private Image standDrink;

    [SerializeField]
    private Image duaButton;

    public GameObject colaCan;

    public GameObject thePlayer;

    public GameObject trashSystemTrigger;

    public GameObject firstMissionWay;

    public GameObject drinkTriggerSelf;

     public GameObject sitDrinkCutscene;

     public GameObject standDrinkCutscene;

     AudioSource duaAudio;
    public float sitDrinkDelay = 14f;

    bool buttonTrigger;

    bool sitTrigger;

 //   bool sitDua;

 //   bool standDua;

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

      void Start()
    {
        duaAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
        sitDrink.enabled = true;
        standDrink.enabled = true;
        buttonTrigger = true;
        Debug.Log("Enabling the Button");
        }
    }

     void OnTriggerExit(Collider other)
     {
        sitDrink.enabled = false;
        standDrink.enabled = false;
     }

     void RemainingGameContine()
     {
         duaButton.enabled = false;
         thePlayer.SetActive(true);
         colaCan.SetActive(true);
         drinkTriggerSelf.SetActive(false);
        // timePlayer.SetActive(false);
        sitDrinkCutscene.SetActive(false);
       standDrinkCutscene.SetActive(false);
       trashSystemTrigger.SetActive(true);
       firstMissionWay.SetActive(false);
       Debug.Log("Trash Trigger is true now");

     }

     void test()
     {
         Debug.Log("Test function is triggring");
     }

     void duaSound()
     {
         duaButton.enabled = true;
        Invoke("RemainingGameContine", 8f);
     }
 

    
    void Update()
    {
        if(buttonTrigger)
        {
             if(playerInput.Level2.sitDrink.triggered)
        {
            //timePlayer.SetActive(true);
              sitDrink.enabled = false;
            standDrink.enabled = false;
            colaCan.SetActive(false);
            thePlayer.SetActive(false);
           // timePlayer.SetActive(true);
            Debug.Log("Sit Button Trigger");
           sitDrinkCutscene.SetActive(true);
           Invoke("duaSound", sitDrinkDelay);

        }
        if(playerInput.Level2.standDrink.triggered)
        {
            sitDrink.enabled = false;
            standDrink.enabled = false;
            colaCan.SetActive(false);
            standDrinkCutscene.SetActive(true);
            thePlayer.SetActive(false);
            Invoke("duaSound", 10f);

            Debug.Log("Stand Button Trigger");
        }
        }
               if(playerInput.Level2.Dua.triggered)
         {
             duaAudio.Play();
             duaButton.enabled = false;
             Debug.Log("Dua is Playing");
             Invoke("RemainingGameContine", 5f);
         }
      
    }
}
