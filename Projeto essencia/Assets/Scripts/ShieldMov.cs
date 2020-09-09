using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMov : MonoBehaviour
{
    public GameObject player;
    public float fRadius; //distancia do escudo pro player
    private Transform pivot;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerMov>().gameObject;
        pivot = new GameObject().transform;
        transform.parent = pivot;

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 v3Pos = Camera.main.WorldToScreenPoint(player.transform.position); //pega a posicao do player no mundo
        v3Pos = Input.mousePosition - v3Pos;//garante que vai ser sempre a msm distancia do player independente da distancia do mouse
        float angle = Mathf.Atan2(v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;
        v3Pos = Quaternion.AngleAxis(angle, Vector3.forward) * (Vector3.right * fRadius);//mexe o escudo pra direcao do mouse
        transform.position = player.transform.position + v3Pos;
        transform.right = player.transform.position - transform.position;//rotaciona sempre o escudo em direcao ao player
    }

}
