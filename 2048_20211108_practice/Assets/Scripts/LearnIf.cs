using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool opendoor;
    public int score = 99;

    private void Start()
    {
        if (true)
        {
            print("���L�� true");

        }
        if (false)
        {
            print("���L�� false");

        }

        if (opendoor)
        {
            print("�}��");
        }
        else
        {
            print("����");
        }

    }
    private void Update()
    {
        if (score >= 60)
        {
            print("�ή�");
        }
        else if (score >= 40)
        {
            print("�ɦ�");
        }
        else
        {
            print("����");
        }
    }

}
