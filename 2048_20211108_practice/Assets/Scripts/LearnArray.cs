using UnityEngine;

/// <summary>
/// �}�C
/// </summary>
public class LearnArray : MonoBehaviour
{
    public int[] scores;
    
    public float[] attacks = new float[3];

    public string[] props = { "����", "�Ť�", "ī�G" };
    private void Start()
    {
        print("�ĤT�ӹD��G" + props[2]);
        props[0] = "����";
        print("�D�㪺�ƶq�G" + props.Length);

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = i * 10 + 10;
        }
    }

}
