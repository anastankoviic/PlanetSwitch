
using System;
using UnityEngine;

public class CameraMoveUp : MonoBehaviour
{
    public Transform player;  //kamera prati igraca

    void Update()
    {
        if (!player) //ako ga nema
        {
            TryToFindPlayer(); //nadji ga
            return;
        }

        if (player.position.y > transform.position.y)  //ako je pozicija igraca veca od pozicije kamera(visina)
        {
            //promeni visinu kamere na visinu igraca
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
    }

    
    private void TryToFindPlayer() //sprecava error
    {
        
        var obj = GameObject.FindGameObjectWithTag("Player"); //trazi objekat sa tagom player

        if (obj != null) //ako objekat nije null
        {
         player = obj.transform; //nista vraca poziciju
        }
        else
        {
         player = null; //vraca null
        }
    }
}

