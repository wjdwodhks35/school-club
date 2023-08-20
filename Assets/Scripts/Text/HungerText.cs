using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HungerText : MonoBehaviour
{
    private TextMeshProUGUI hungText;
    private VariableManager variableManager;

    // Start is called before the first frame update
    void Start()
    {
        hungText = GetComponent<TextMeshProUGUI>();
        variableManager = VariableManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        hungText.text = variableManager.hunger.ToString() + "/100";
    }
}
