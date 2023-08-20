using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HungValueText : MonoBehaviour
{
    private TextMeshProUGUI hungText;
    private ShopHPItem parentValue;

    // Start is called before the first frame update
    void Start()
    {
        hungText = GetComponent<TextMeshProUGUI>();
        parentValue = transform.parent.GetComponent<ShopHPItem>();

        hungText.text = "+" + parentValue.hung.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
