using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PotionPriceText : MonoBehaviour
{
    private TextMeshProUGUI nameText;
    private ShopPotion parentValue;

    // Start is called before the first frame update
    void Start()
    {
        nameText = GetComponent<TextMeshProUGUI>();
        parentValue = transform.parent.GetComponent<ShopPotion>();

        nameText.text = parentValue.price.ToString() + "G";
    }
}
