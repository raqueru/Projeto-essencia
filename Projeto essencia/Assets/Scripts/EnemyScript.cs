using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{ 
    private GameObject Player;
    public float Speed = 30;
    public float FollowDistance = 100f;

 



    private void Start()
    {
        Player= GameObject.FindGameObjectWithTag("Player");
    }


    // Update is called once per frame
    void Update()
    {
         
        if (Vector2.Distance(Player.transform.position, this.transform.position) < FollowDistance)
        {
            walktowardsplayer();
        }
        
    }

    void walktowardsplayer()
    { 
        transform.position=Vector2.MoveTowards(transform.position,Player.transform.position,Speed*Time.deltaTime);
     
        if(Player.transform.position.x<this.transform.position.x){
            transform.rotation= new Quaternion(0,180,0,0);
        }
        else transform.rotation= new Quaternion(0,0,0,0);

        
    }

    private static EnemyScript instance;
    public static EnemyScript GetInstance()
    {
        return instance;
    }

}