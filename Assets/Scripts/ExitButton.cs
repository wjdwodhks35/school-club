using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public GameObject foodShopUI;
    private VariableManager variableManager;

    private void Start()
    {
        variableManager = VariableManager.Instance;
    }

    public void OnClick()
    {
        foodShopUI.SetActive(!foodShopUI.activeSelf);
        variableManager.onGame = true;
    }
}
