using UnityEngine;
using UnityEngine.UI;

public class VariableManager : MonoBehaviour
{
    public static VariableManager Instance { get; private set; }

    public int gold;
    public int health;
    public int maxHealth;
    public int hunger;

    public int potion;

    public bool onGame = true;

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
