using UnityEngine;

/// <summary>
/// �K�n
/// </summary>
public class LearnMethod : MonoBehaviour
{
    public void Test()
    {
        print("�ڬO���դ�k");
    }

    private void Start()
    {
        Test();
        Test();
        Drive90();
        Drive150();
        Drive(70);
        Drive(200);
    }

    //�����ݨD
    //���񭵮�
    //�T���i�H�[�t�A�ɳt��90
    //�T���i�H�[�t�A�ɳt��150

    public void Drive90()
    {
        print("�}���A�ɳt�G" + 90);
        print("����");
    }
    public void Drive150()
    {
        print("�}���A�ɳt�G" + 150);
        print("����");
    }
    public void Drive(int speed)
    {
        print("�}���A�ɳt�G" + speed);
        print("����");
    }

}
