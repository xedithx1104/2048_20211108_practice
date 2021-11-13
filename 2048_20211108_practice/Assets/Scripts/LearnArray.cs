using UnityEngine;

/// <summary>
/// 陣列
/// </summary>
public class LearnArray : MonoBehaviour
{
    public int[] scores;
    
    public float[] attacks = new float[3];

    public string[] props = { "紅水", "藍水", "蘋果" };
    private void Start()
    {
        print("第三個道具：" + props[2]);
        props[0] = "黃水";
        print("道具的數量：" + props.Length);

        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = i * 10 + 10;
        }
    }

}
