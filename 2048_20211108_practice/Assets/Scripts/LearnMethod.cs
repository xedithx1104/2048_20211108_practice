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
        Drive(200,"���X�X�I�I");
        Drive(300);
        Drive(50, effect:"���Y");

        int t = Ten();
        print("�Ǧ^��k�ȡG" + t);

        print("���ϥ��ܼ��x�s�Ǧ^�ȡG" + Ten());

        int damage = Damage(90, 30);
        print("90�����O�P30���m�O���ˮ`�G" + damage);

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
    public void Drive(int speed, string sound = "���X�I�X", string effect ="�ǹ�")
    {
        print("�}���A�ɳt�G" + speed);
        print("���ġG" + sound);
        print("�S�ġG" + effect);

    }
    public int Ten()
    {
        return 10;
    }

    ///<summary>
    ///�p��ˮ`�ȡA�����O - ���m�O = �ˮ`��
    ///</summary>
    ///<param name="attack">�����O</param>
    ///<param name="defence">���m�O</param>
    ///<returns>�ˮ`��</returns>
    public int Damage(int attack, int defence)
    {
        return attack - defence;
    }
}
