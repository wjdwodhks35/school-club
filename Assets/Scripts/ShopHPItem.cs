using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ShopHPItem : MonoBehaviour
{
    private VariableManager variableManager;

    public string iName;
    public int price;
    public int hp;
    public int hung;
    
    // Start is called before the first frame update
    void Start()
    {
        variableManager = VariableManager.Instance;
    }

    public void OnClick()
    {
        if (variableManager.gold >= price && (variableManager.hunger + hung) <= 100)
        {
            //°ñµå ÀÖÀ½
            variableManager.gold -= price;
            variableManager.hunger += hung;
            if (variableManager.maxHealth <= variableManager.health + hp)
            {
                variableManager.health = variableManager.maxHealth;
            }
            else
            {
                variableManager.health += hp;
            }
        }
        else
        {
            //°ñµå ºÎÁ·
        }
    }
}
