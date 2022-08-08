using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    void Awake()
    {
        Debug.Log("Bolinha teste");

        if (instance == null)
        {
            instance = this;
        }
    }

    public GameManager getInstance()
    {
        return instance;
    }
}
