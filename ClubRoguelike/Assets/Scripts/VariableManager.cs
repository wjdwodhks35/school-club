using UnityEngine;
using UnityEngine.UI;

public class VariableManager : MonoBehaviour
{
    public static VariableManager Instance { get; private set; }

    public int gold;
    public int health;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // ...
}
