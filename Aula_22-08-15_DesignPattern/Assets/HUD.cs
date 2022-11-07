using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private static HUD instance;
    [SerializeField] private Text txtLife;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        GameManager.GetInstance().Setup();
    }

    public static HUD GetInstance()
    {
        return instance;
    }

    public void UpdateTxtScore(string score)
    {
        instance.txtLife.text = score;
    }
}
