using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] private int life;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } 
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public static GameManager GetInstance()
    {
        return instance;
    }

    public void Setup()
    {
        HUD?.GetInstance().UpdateTxtScore(life.ToString());
    }

    public void AddLife()
    {
        life += 1;
        Setup();
    }

    public void SubLife()
    {
        life -= 1;
        Setup();

        if (life <= 0)
        {
            Debug.Log("You Died!!!");
        }
    }
}
