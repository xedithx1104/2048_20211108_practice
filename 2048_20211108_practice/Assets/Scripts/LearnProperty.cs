using UnityEngine;

public class LearnProperty : MonoBehaviour
{   //���
    public int passwordField = 123456789;
    //�ݩ�
    public int passwordProperty { get; set; }
    public int myPasswordProperty { get => 999; }
    //��Ū����g�k
    public string nameCharacter
    {
        get
        {
            print("�ڦb�ݩ�nameCharacter�̭�:D");
            return "Kei";
        }
    }
    //�߼g����g�k
    public float attack
    {
        set
        {
            print("�����O�G" + value);
        }
    }
    private void Start()
    {   
        passwordProperty = 777;
        print("�ݩʱK�X�G" + passwordProperty);
        //myPasswordProperty = 999; //�߿W
        print("�ڪ��ݩʱK�X�G" + myPasswordProperty);
        print(nameCharacter);
        //print(attack); //�߼g
        attack = 99.9f;
    }

}
