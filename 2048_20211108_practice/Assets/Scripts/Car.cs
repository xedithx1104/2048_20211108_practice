using UnityEngine;
public class Car : MonoBehaviour
{
    #region ���y�k&�|�j������
    [Header("�T����CC��")][Range(1000,5000)]
    public int cc = 2000;
    [Tooltip("�o�O�T�����q�A�d��O3~20"), Range(3,20)]
    public float weight = 3.5f;
    public string brand = "���h";
    public bool hasSkyWindow = true;
    #endregion
    #region �C�����`�θ������
    // �C�� Color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpha = new Color(0, 1, 0, 0.3f);
    #endregion
}
