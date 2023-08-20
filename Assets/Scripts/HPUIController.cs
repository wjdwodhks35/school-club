using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUIController : MonoBehaviour
{
    private VariableManager variableManager;
    public int HPCut;
    public int HPHalfCut;
    public Sprite full;
    public Sprite half;
    public Sprite empty;
    
    // Start is called before the first frame update
    void Start()
    {
        variableManager = VariableManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        if(variableManager.health <= HPCut)
        {
            GetComponent<Image>().sprite = empty;
        }
        else if (variableManager.health <= HPHalfCut)
        {
            GetComponent<Image>().sprite = half;
        }
        else
        {
            GetComponent<Image>().sprite = full;
        }
    }
}
