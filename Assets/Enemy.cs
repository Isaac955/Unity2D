using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ContactPoint2D[] listContacts = new ContactPoint2D[1];
            other.GetContacts(listContacts);

            if (listContacts[0].normal.y < -0.5f)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("C'est le joueur qui m'a touché !");
            }
        }
    }
}
