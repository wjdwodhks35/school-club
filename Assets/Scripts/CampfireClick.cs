using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampfireClick : MonoBehaviour
{
    private VariableManager variableManager;

    public GameObject flame;
    public GameObject glow;
    bool isUsed = false;

    private void Start()
    {
        variableManager = VariableManager.Instance;
    }

    void OnMouseDown()
    {
        if (isUsed || !variableManager.onGame)
        {
            return;
        }
        variableManager.health = variableManager.maxHealth;
        variableManager.hunger = 0;
        flame.SetActive(false); glow.SetActive(false);
        isUsed = true;
    }
}
