using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class ShopPotion : MonoBehaviour
{
    private VariableManager variableManager;

    public int price;
    public int potion;

    // Start is called before the first frame update
    void Start()
    {
        variableManager = VariableManager.Instance;
    }

    public void OnClick()
    {
        if (variableManager.gold >= price && variableManager.potion == 0)
        {
            //∞ÒµÂ ¿÷¿Ω
            variableManager.gold -= price;
            variableManager.potion = potion;
        }
        else
        {
            //∞ÒµÂ ∫Œ¡∑
        }
    }
}
