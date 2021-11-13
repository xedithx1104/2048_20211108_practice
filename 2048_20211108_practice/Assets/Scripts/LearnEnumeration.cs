using UnityEngine;
/// <summary>
/// 列舉
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
                print("等待中");
                break;
            case StateEnemy.Walk:
                print("走路中");
                break;
            case StateEnemy.Track:
                print("追蹤中");
                break;
            case StateEnemy.Attack:
                print("攻擊中");
                break;
            case StateEnemy.Dead:
                print("死亡中");
                break;
            default:
                break;
        }

    }
}
