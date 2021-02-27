using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject Gun;
    AttackerSpawner MyLaneSpawner;
    Animator animatior;
    private void Start()
    {
        SetLaneSpawner();
        animatior = GetComponent<Animator>();
    }

    private void Update()
    {
        if(IsAttackerInLane())
        {
           
            animatior.SetBool("IsAttacking", true);
        }else
        {
            
            animatior.SetBool("IsAttacking", false);
        }
    }
   
    public void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach(AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough = (Mathf.Abs( spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if(IsCloseEnough)
            {
                MyLaneSpawner = spawner;
            }
        }

    }
    private bool IsAttackerInLane()
    {
        if (MyLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
            return true;
    }
    public void Fire()
    {
        Instantiate(Projectile,Gun.transform.position, transform.rotation);
    }
}
