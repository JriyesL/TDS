using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float value = 100;
    // Start is called before the first frame update
    void Update()
    {
        if(value <= 0){
            Destroy(gameObject);
        }
    }
    public void DealDamage(float damage)
    {
    value -= damage;
    }
}
