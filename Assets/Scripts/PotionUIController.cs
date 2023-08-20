using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PotionUIController : MonoBehaviour
{
    private VariableManager variableManager;
    public Sprite potion1;

    // Start is called before the first frame update
    void Start()
    {
        variableManager = VariableManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (variableManager.potion == 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        if (variableManager.potion == 1)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = potion1;
        }
    }
}
