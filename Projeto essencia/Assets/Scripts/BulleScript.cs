using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulleScript : MonoBehaviour
{
    [Header("Shoot Configuration")]

    public GameObject Bullet;
    private GameObject Player;


    public float Strenght = 20;

    void Start(){
          Player= GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        Vector2 direction = (Player.transform.position - this.transform.position).normalized;
        Shoot(direction);
    
    }

    public void Shoot(Vector2 direction)
    {

        GameObject bullet = Instantiate(Bullet, this.transform.position, Bullet.transform.rotation);



        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();

        bulletRB.AddForce(direction * Strenght, ForceMode2D.Impulse);
         

    }

}