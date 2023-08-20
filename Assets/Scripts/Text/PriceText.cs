using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PriceText : MonoBehaviour
{
    private TextMeshProUGUI nameText;
    private ShopHPItem parentValue;
    
    // Start is called before the first frame update
    void Start()
    {
        nameText = GetComponent<TextMeshProUGUI>();
        parentValue = transform.parent.GetComponent<ShopHPItem>();

        nameText.text = parentValue.price.ToString() + "G";
    }
}
