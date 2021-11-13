using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool opendoor;
    public int score = 99;

    private void Start()
    {
        if (true)
        {
            print("布林值 true");

        }
        if (false)
        {
            print("布林值 false");

        }

        if (opendoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

    }
    private void Update()
    {
        if (score >= 60)
        {
            print("及格");
        }
        else if (score >= 40)
        {
            print("補考");
        }
        else
        {
            print("死當");
        }
    }

}
