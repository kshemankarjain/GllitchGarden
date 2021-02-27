using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker attackerprefab;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay,maxSpawnDelay));
            SpawnAttacker();
        }
    }
    private void SpawnAttacker()
    {
      Attacker NewAttacker =   Instantiate(attackerprefab, transform.position, transform.rotation) as Attacker;
        NewAttacker.transform.parent = transform;
    }
    void Update()
    {
        
    }
}
