using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldText : MonoBehaviour
{
    private TextMeshProUGUI goldText;
    private VariableManager variableManager;

    void Start()
    {
        goldText = GetComponent<TextMeshProUGUI>();
        variableManager = VariableManager.Instance;
    }

    void Update()
    {
        goldText.text = variableManager.gold.ToString();
    }
}
