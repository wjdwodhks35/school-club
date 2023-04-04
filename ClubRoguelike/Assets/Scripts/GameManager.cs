using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject foodShopUI;
    private VariableManager variableManager;

    void Start()
    {
        variableManager = VariableManager.Instance;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            foodShopUI.SetActive(!foodShopUI.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            variableManager.gold += 100;
        }
    }
}