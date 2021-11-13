using UnityEngine;
/// <summary>
/// °j°é
/// </summary>
public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        int number = 1;
        while (number < 6 )
        {
            print("While°j°é¼Æ¦r¡G" + number);
            number++;
        }

        for (int i = 1; i < 6; i++)
        {
            print("For°j°é¼Æ¦r¡G" + i);
        }
    }
}
