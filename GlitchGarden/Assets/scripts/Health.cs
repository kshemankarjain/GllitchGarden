using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject DeathVFX;
    
    public void  DealDamage(float Damage )
    {
        health -= Damage;
        if (health <= 0 )
        {
            Destroy(gameObject);
            TriggerDeathVFX();
        }

    }
    public void TriggerDeathVFX()
    {
        if( !DeathVFX) { return; } 
        GameObject DeathVfxGameobject =  Instantiate(DeathVFX, transform.position, transform.rotation);
        Destroy(DeathVfxGameobject , 1f);

    }
    
}
