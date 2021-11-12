using UnityEngine;

public class LearnProperty : MonoBehaviour
{   //欄位
    public int passwordField = 123456789;
    //屬性
    public int passwordProperty { get; set; }
    public int myPasswordProperty { get => 999; }
    //唯讀完整寫法
    public string nameCharacter
    {
        get
        {
            print("我在屬性nameCharacter裡面:D");
            return "Kei";
        }
    }
    //唯寫完整寫法
    public float attack
    {
        set
        {
            print("攻擊力：" + value);
        }
    }
    private void Start()
    {   
        passwordProperty = 777;
        print("屬性密碼：" + passwordProperty);
        //myPasswordProperty = 999; //唯獨
        print("我的屬性密碼：" + myPasswordProperty);
        print(nameCharacter);
        //print(attack); //唯寫
        attack = 99.9f;
    }

}
