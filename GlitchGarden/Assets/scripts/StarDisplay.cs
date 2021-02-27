using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int Stars = 100;
    Text StarText;

    // Start is called before the first frame update
    void Start()
    {
        StarText = GetComponent<Text>();
        UpdateDisplay();
    }
    public void UpdateDisplay()
    {
        StarText.text = Stars.ToString();
    }
    public void AddStars(int Amount)
    {
        Stars += Amount;
        UpdateDisplay();
    }
    public bool HaveEnoughStars(int amount )
    {
        return Stars >= amount;
    }
    public void SpendStars(int Expenditure)
    {
        if (Stars >= Expenditure)
        {
            Stars -= Expenditure;
            UpdateDisplay();
        }
    }

   
}
