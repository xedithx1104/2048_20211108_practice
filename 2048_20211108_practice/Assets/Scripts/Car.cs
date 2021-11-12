using UnityEngine;
public class Car : MonoBehaviour
{
    #region 欄位語法&四大基本類型
    [Header("汽車的CC數")][Range(1000,5000)]
    public int CC = 2000;
    [Tooltip("這是汽車重量，範圍是3~20"), Range(3,20)]
    public float weight = 3.5f;
    public string brand = "賓士";
    public bool hasSkyWindow = true;
    #endregion
    #region 遊戲內常用資料類型
    // 顏色 Color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpha = new Color(0, 1, 0, 0.3f);
    // 座標 Vector 2-4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    // 按鍵 KeyCode 
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    public KeyCode kcML = KeyCode.Mouse0;
    // 遊戲物件 GameObject
    public GameObject carBox;
    public GameObject carOil;
    // 元件 Component
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion
    #region 存取欄位資料 Set Get
    private void Start()
    {
        print("哈囉，世界");
        print("CC數是：" + CC);
        print("重量是：" + weight);
        brand = "BMW";
        CC = 3500;
    }
    #endregion
}
