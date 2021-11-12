using UnityEngine;

/// <summary>
/// 摘要
/// </summary>
public class LearnMethod : MonoBehaviour
{
    public void Test()
    {
        print("我是測試方法");
    }

    private void Start()
    {
        Test();
        Test();
        Drive90();
        Drive150();
        Drive(70);
        Drive(200);
    }

    //企劃需求
    //播放音效
    //汽車可以加速，時速為90
    //汽車可以加速，時速為150

    public void Drive90()
    {
        print("開車，時速：" + 90);
        print("音效");
    }
    public void Drive150()
    {
        print("開車，時速：" + 150);
        print("音效");
    }
    public void Drive(int speed)
    {
        print("開車，時速：" + speed);
        print("音效");
    }

}
