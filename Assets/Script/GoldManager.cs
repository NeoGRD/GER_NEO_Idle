using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int ClickPower;

    public int HutAmount;
    public int humanAmount;
    public int hutpower;
    public int hutprice;
    public int EncampementAmount;
    public int EncampementPower;
    public int EncampementPrice;
    public int HammeauAmount;
    public int HammeauPower;
    public int HammeauPrice;
    public int VillageAmount;
    public int VillagePower;
    public int VillagePrice;
    public int VilleAmount;
    public int VillePower;
    public int VillePrice;
    public int MetropoleAmount;
    public int MetropolePower;
    public int MetropolePrice;
    public int MegapoleAmount;
    public int MegapolePower;
    public int MegapolePrice;
    public TextMeshProUGUI humanText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI HutpriceText;
    public TextMeshProUGUI HutAmountText;
    public TextMeshProUGUI EncampementAmountText;
    public TextMeshProUGUI EncampementPriceText;
    public TextMeshProUGUI HammeauAmountText;
    public TextMeshProUGUI HammeauPriceText;
    public TextMeshProUGUI VillageAmountText;
    public TextMeshProUGUI VillagePriceText;
    public TextMeshProUGUI VilleAmountText;
    public TextMeshProUGUI VillePriceText;
    public TextMeshProUGUI MetropoleAmountText;
    public TextMeshProUGUI MetropolePriceText;
    public TextMeshProUGUI MegapoleAmountText;
    public TextMeshProUGUI MegapolePriceText;

    public int CPHS;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hutpower = 1;
        EncampementPower = 1;
        HammeauPower = 1;
        VillagePower = 1;
        VillePower = 1;
        MetropolePower = 1;
        MegapolePower = 1;

        ClickPower = 1;
        CPHS = 0;

        InvokeRepeating("ClickPerHalfSecond",1.0f, 0.5f);

    }

    public void ClickPerHalfSecond()
    {
        humanAmount += CPHS;
    }

    public void ClickUpgrade01()
    {
        if (humanAmount >= 100)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 100;
        }
    }
    public void ClickUpgrade02()
    {
        if (humanAmount >= 300)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 300;
        }
    }
    public void ClickUpgrade03()
    {
        if (humanAmount >= 1000)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 1000;

        }
    }
    public void ClickUpgrade04()
    {
        if (humanAmount >= 3000)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 3000;
        }
    }
    public void ClickUpgrade05()
    {
        if (humanAmount >= 6000)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 6000;
        }
    }
    public void ClickUpgrade06()
    {
        if (humanAmount >= 10000)
        {
            ClickPower = ClickPower * 2;
        }
    }
    public void ClickUpgrade07()
    {
        if (humanAmount >= 13000)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 13000;
        }
    }
    public void ClickUpgrade08()
    {
        if (humanAmount >= 50000)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 50000;
        }
    }
    public void ClickUpgrade09()
    {
        if (humanAmount >= 100000)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 100000;
        }
    }
    public void ClickUpgrade10()
    {
        if (humanAmount >= 1000000)
        {
            ClickPower = ClickPower * 2;
            humanAmount -= 1000000;
        }
    }

    public void BirthHuman()
    {
        humanAmount += ClickPower;
    }
    ///-----------------------------------------------------------------///
    public void ChangeHutPower()
    {
        if (humanAmount >= hutprice)
        {
            humanAmount -= hutprice;
            hutprice = Mathf.CeilToInt(hutprice * 1.2f);

            hutpower += 1;
            HutAmount += 1;
            CPHS += 1;
        }
    }
    public void Build5Huts()
    {
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();

    }
    public void Build10Huts()
    {
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
        ChangeHutPower();
    }
    ///-----------------------------------------------------------------///
    public void ChangeCampPower()
    {
        if (humanAmount >= EncampementPrice)
        {
            humanAmount -= EncampementPrice;
            EncampementPrice = Mathf.CeilToInt(EncampementPrice * 1.2f);

            EncampementPower += 1;
            EncampementAmount += 1;
            CPHS += 1;
        }
    }

    public void Build5Camp()
    {
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
    }
    public void Build10Camp()
    {
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();

    }
    ///-----------------------------------------------------------------///
    public void ChangeHammeauPower()
    {
        if (humanAmount >= EncampementPrice)
        {
            humanAmount -= EncampementPrice;
            EncampementPrice = Mathf.CeilToInt(EncampementPrice * 1.2f);

            EncampementPower += 1;
            EncampementAmount += 1;
            CPHS += 1;
        }
    }

    public void Build5Hamm()
    {
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
    }
    public void Build10Hamm()
    {
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();
        ChangeCampPower();

    }
    ///-----------------------------------------------------------------///
    public void ChangeVillagePower()
    {
        if (humanAmount >= VillagePrice)
        {
            humanAmount -= VillagePrice;
            VillagePrice = Mathf.CeilToInt(VillagePrice * 1.2f);

            VillagePower += 1;
            VillageAmount += 1;
            CPHS += 1;
        }
    }

    public void Build5Village()
    {
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
    }
    public void Build10Village()
    {
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();
        ChangeVillagePower();


    }
    ///-----------------------------------------------------------------///
    ///-----------------------------------------------------------------///



    // Update is called once per frame
    void Update()
    {
        humanText.text = $"Humans :{humanAmount}";
        powerText.text = $"Taux de natalité :{hutpower}";
        HutAmountText.text = $"Nombre de hutte :{HutAmount}";
        HutpriceText.text = $"Prix pour hutte :{hutprice}";
        EncampementAmountText.text = $"Nombre d'encampement :{EncampementAmount}";
        EncampementPriceText.text = $"Prix encampement :{EncampementPrice}";
        HammeauAmountText.text = $"Nombre hammeau :{HammeauAmount}";
        HammeauPriceText.text = $"Prix hammeau :{HammeauPrice}";
        VillageAmountText.text = $"Nombre village :{VillageAmount}";
        VillagePriceText.text = $"Prix village :{VillagePrice}";
        VilleAmountText.text = $"Nombre ville :{VilleAmount}";
        VillePriceText.text = $"Prix ville :{VillePrice}";
        MetropoleAmountText.text = $"Nombre metropole :{MetropoleAmount}";
        MetropolePriceText.text = $"Prix metropole :{MetropolePrice}";
        MegapoleAmountText.text = $"Nombre megapole :{MegapoleAmount}";
        MegapolePriceText.text = $"Prix megapole :{MegapolePrice}";
    }  
}
