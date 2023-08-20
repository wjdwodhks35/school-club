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
            variableManager.onGame = !variableManager.onGame;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            variableManager.gold += 100;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (variableManager.potion == 1)
            {
                variableManager.potion = 0;
                if (variableManager.maxHealth <= variableManager.health + 2)
                {
                    variableManager.health = variableManager.maxHealth;
                }
                else
                {
                    variableManager.health += 2;
                }
            }
        }
    }
}