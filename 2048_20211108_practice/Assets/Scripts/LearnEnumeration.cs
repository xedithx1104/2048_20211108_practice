using UnityEngine;
/// <summary>
/// �C�|
/// </summary>
public class LearnEnumeration : MonoBehaviour
{
    public enum StateEnemy
    {
        Idle, Walk, Track, Attack, Dead
    }

    public StateEnemy state;
    private void Update()
    {
        switch (state)
        {
            case StateEnemy.Idle:
                print("���ݤ�");
                break;
            case StateEnemy.Walk:
                print("������");
                break;
            case StateEnemy.Track:
                print("�l�ܤ�");
                break;
            case StateEnemy.Attack:
                print("������");
                break;
            case StateEnemy.Dead:
                print("���`��");
                break;
            default:
                break;
        }

    }
}
