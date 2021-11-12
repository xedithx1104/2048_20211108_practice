using UnityEngine;
public class Car : MonoBehaviour
{
    #region ���y�k&�|�j������
    [Header("�T����CC��")][Range(1000,5000)]
    public int CC = 2000;
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
    // �y�� Vector 2-4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    // ���� KeyCode 
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    public KeyCode kcML = KeyCode.Mouse0;
    // �C������ GameObject
    public GameObject carBox;
    public GameObject carOil;
    // ���� Component
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion
    #region �s������� Set Get
    private void Start()
    {
        print("���o�A�@��");
        print("CC�ƬO�G" + CC);
        print("���q�O�G" + weight);
        brand = "BMW";
        CC = 3500;
    }
    #endregion
}
