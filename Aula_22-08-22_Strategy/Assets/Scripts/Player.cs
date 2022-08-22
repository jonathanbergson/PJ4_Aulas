using UnityEngine;

public class Player : MonoBehaviour
{
    public IAttackBehaviour attack;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack.DoAttack();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            attack = new AttackKick();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            attack = new AttackPunch();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            attack = new AttackFireBall();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            attack = new AttackPoison();
        }
    }
}
