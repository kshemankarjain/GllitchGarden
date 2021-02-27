using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
   Defender defender;
    private void OnMouseDown()
    {
        AttemptToPlaceDefenederAt(GetSquareClicked());


    }
    public void SetSelectedDefender(Defender DefenderToSelect)
    {
        defender = DefenderToSelect;

    }
    private void AttemptToPlaceDefenederAt(Vector2 gridpos)
    {
        var stardisplay = FindObjectOfType<StarDisplay>();
        var defendercost = defender.GetStarCost();
        if (stardisplay.HaveEnoughStars(defendercost))
        {
            SpawnDefender(gridpos);
            stardisplay.SpendStars(defendercost);
        }

    }
    private Vector2 GetSquareClicked()
    {
        Vector2 clickpos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldpos = Camera.main.ScreenToWorldPoint(clickpos);
        Vector2 GridPos = SnapToGrid(worldpos);
        return GridPos;
    }
    private Vector2 SnapToGrid(Vector2 RawWorldPos)
    {
        float newX = Mathf.RoundToInt(RawWorldPos.x);
        float newY = Mathf.RoundToInt(RawWorldPos.y);
        return new Vector2(newX, newY);


    }
    private void SpawnDefender(Vector2 RoundedPos)
    {
        Defender NewDefender = Instantiate(defender, RoundedPos, Quaternion.identity)as Defender;
    }
}
