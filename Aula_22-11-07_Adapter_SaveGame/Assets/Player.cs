using UnityEngine;
//using System.IO;

public class Player: MonoBehaviour
{
    private void Start(){

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerData data = new PlayerData();
            data.position = transform.position;
            data.rotation = transform.rotation.eulerAngles;
            string s = JsonUtility.ToJson(data, true);
            //File.WriteAllText(Application.dataPath + "sava.json", s);
        }
    }
}
