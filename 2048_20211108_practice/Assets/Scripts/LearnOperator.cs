using UnityEngine;

/// <summary>
/// �{�ѹB��l
/// </summary>
public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int hp = 100;

    private void Start()
    {
        #region �ƾǹB��l
        print("�[�k�G" + (a + b));
        print("��k�G" + (a - b));
        print("���k�G" + (a * b));
        print("���k�G" + (a / b));
        print("�l�ơG" + (a % b));

        c = c + 1;
        print("C���G�G" + c);
        c++;
        print("C���G�G" + c);

        hp = hp + 10;
        print("HP���G�G" + hp);
        hp += 10;
        print("HP���G�G" + hp);
        #endregion
        #region ����B��l
        print("a > b " + (a > b));
        print("a < b " + (a < b));
        print("a >= b " + (a >= b));
        print("a <= b " + (a <= b));
        print("a = b " + (a == b));
        print("a != b " + (a != b));
        #endregion
        #region �޿�B��l
        print("t && t " + (true && true));
        print("f && t " + (false && true));
        print("t && f " + (true && false));
        print("f && f " + (false && false));

        print("t || t " + (true || true));
        print("f || t " + (false || true));
        print("t || f " + (true || false));
        print("f || f " + (false || false));

        print(!true);
        print(!(a > b));
        print(!(true && true));

        #endregion


    }
}
