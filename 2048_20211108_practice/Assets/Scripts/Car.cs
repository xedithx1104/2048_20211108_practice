using UnityEngine;
public class Car : MonoBehaviour
{
    #region 欄位語法&四大基本類型
    [Header("汽車的CC數")][Range(1000,5000)]
    public int cc = 2000;
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
    #endregion
}
