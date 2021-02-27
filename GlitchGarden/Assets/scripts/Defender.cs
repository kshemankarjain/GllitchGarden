using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int StarCost = 100;
  
    public void AddingStars(int amount )
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }
    public int GetStarCost()
    {
        return StarCost;
    }
}
