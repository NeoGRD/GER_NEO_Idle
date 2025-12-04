using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public int price;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
    }

    public void ChangeGold()
    {
        goldAmount += power;
    }

    public void ChangePower()
    {
        if (goldAmount >= price)
        {
            goldAmount -= price;
            price = Mathf.CeilToInt(price * 1.2f);

            power += 1;
        }
    }

    public void Build5()
    {
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
    }

    public void Build10()
    {
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
        ChangePower();
    }

    // Update is called once per frame
    void Update()
    {
    
    }  
}
