using UnityEngine;

// 認識判斷式switch
public class LearnSwitch : MonoBehaviour
{
    public string equipment;

    private void Start()
    {
        switch (equipment)
        {
            case "刀子":
                print("你現在拿著刀子");
                break;
            case "叉子":
                print("你現在拿著叉子");
                break;
            default:
                print("你拿的不是武器");
                break;
        }
    }

}
