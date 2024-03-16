using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AidKit : MonoBehaviour
{
    public float healAmount = 50;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        var PlayerHealth = other.gameObject.GetComponent<PlayerHealth>();
        if(PlayerHealth != null)
        {
            if(PlayerHealth.value < 100){
            PlayerHealth.AddHealth(healAmount);
            Destroy(gameObject);
        }
        }
    }
}
