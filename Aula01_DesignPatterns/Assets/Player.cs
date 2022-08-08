using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) 
        {
            GameManager.GetInstance().AddLife();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            GameManager.GetInstance().SubLife();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level01");
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Level02");
        }
    }
}
