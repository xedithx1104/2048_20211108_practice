using UnityEngine;
/// <summary>
/// �j��
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        int number = 1;
        while (number < 6 )
        {
            print("While�j��Ʀr�G" + number);
            number++;
        }

        for (int i = 1; i < 6; i++)
        {
            print("For�j��Ʀr�G" + i);
        }
    }
}
