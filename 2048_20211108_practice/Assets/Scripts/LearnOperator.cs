using UnityEngine;

/// <summary>
/// 認識運算子
/// </summary>
public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int hp = 100;

    private void Start()
    {
        #region 數學運算子
        print("加法：" + (a + b));
        print("減法：" + (a - b));
        print("乘法：" + (a * b));
        print("除法：" + (a / b));
        print("餘數：" + (a % b));

        c = c + 1;
        print("C結果：" + c);
        c++;
        print("C結果：" + c);

        hp = hp + 10;
        print("HP結果：" + hp);
        hp += 10;
        print("HP結果：" + hp);
        #endregion
        #region 比較運算子
        print("a > b " + (a > b));
        print("a < b " + (a < b));
        print("a >= b " + (a >= b));
        print("a <= b " + (a <= b));
        print("a = b " + (a == b));
        print("a != b " + (a != b));
        #endregion
        #region 邏輯運算子
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
