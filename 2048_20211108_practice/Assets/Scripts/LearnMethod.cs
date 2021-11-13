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
        Drive(200,"咻——碰碰");
        Drive(300);
        Drive(50, effect:"石頭");

        int t = Ten();
        print("傳回方法值：" + t);

        print("不使用變數儲存傳回值：" + Ten());

        int damage = Damage(90, 30);
        print("90攻擊力與30防禦力的傷害：" + damage);

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
    public void Drive(int speed, string sound = "咻—碰—", string effect ="灰塵")
    {
        print("開車，時速：" + speed);
        print("音效：" + sound);
        print("特效：" + effect);

    }
    public int Ten()
    {
        return 10;
    }

    ///<summary>
    ///計算傷害值，攻擊力 - 防禦力 = 傷害值
    ///</summary>
    ///<param name="attack">攻擊力</param>
    ///<param name="defence">防禦力</param>
    ///<returns>傷害值</returns>
    public int Damage(int attack, int defence)
    {
        return attack - defence;
    }
}
