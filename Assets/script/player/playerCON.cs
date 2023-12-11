using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class playerCON : MonoBehaviour{

    private NavMeshAgent navmeshagent;
    [SerializeField] private float speed;
    [SerializeField] private float gravity;

    public CharacterController character;
    public FixedJoystick joystick;
    public GameObject orang;
    private Animator anim_orang;
    
    bool sembunyi=true;

    Vector3 velocity;
    
    void Start(){
        navmeshagent = GetComponent<NavMeshAgent>();
        anim_orang = GetComponent<Animator>(); 
        triggerhide();
    }
    public void triggerhide(){
        // if(orang.activeInHierarchy == false){
        //     orang.SetActive(true);
        //     anim_orang.Play("unhide");
            
        // }else{
        //     anim_orang.Play("hide");
            
        //     orang.SetActive(false);
        // }
        if(sembunyi){
            anim_orang.Play("unhide");
            sembunyi = false;
            //orang.SetActive(true);
        }else{
            anim_orang.Play("hide");
            sembunyi = true;
            //orang.SetActive(false);
        }
    }

    public void Update(){
        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;
        character.Move(move * speed * Time.deltaTime);

        velocity.y -= gravity * Time.deltaTime;
        character.Move(velocity * Time.deltaTime);
    }
}
