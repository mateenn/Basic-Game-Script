using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{

    [SerializeField]
    private Image openDoor;
    
    [SerializeField]
    private Image duaButton;

    private Animator _anim;
    private Player playerInput;
     AudioSource audioSource;
    bool buttonTrigger = false;

           private void Awake()
    {
       playerInput = new Player();
        _anim =  GetComponent<Animator>();
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
      audioSource = GetComponent<AudioSource>();   
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            openDoor.enabled = true;
            buttonTrigger = true;
            duaButton.enabled = true;
        
        }
    }
    void OnTriggerExit(Collider other)
   {
       openDoor.enabled = false;
      duaButton.enabled = false;
  
   }

    // Update is called once per frame
    void Update()
         {
             if(buttonTrigger)
             {
              if(playerInput.Level1.DoorOpen.triggered)
        {
            _anim.SetBool("open" , true);
        }
             }
              if(playerInput.Level1.Dua.triggered)
        {
            Debug.Log("Dua button trigging");
             audioSource.Play();
        }

         }
}
