using System.Diagnostics;
using UnityEngine;
using UnityEngine.Playables;
using TMPro;

public class TextDisplays : MonoBehaviour
{
    public int HutAmount;
    public int goldAmount;
    public int power;
    public int price;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI HutAmountText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goldText.text = $"Humans :{goldAmount}";
        powerText.text = $"Taux de natalité :{power}";
        priceText.text = $"Price :{price}";
        HutAmountText.text = $"Nombre de hutte :{HutAmount}";
    }
}
