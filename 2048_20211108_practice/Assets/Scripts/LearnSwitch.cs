using UnityEngine;

// �{�ѧP�_��switch
public class LearnSwitch : MonoBehaviour
{
    public string equipment;

    private void Start()
    {
        switch (equipment)
        {
            case "�M�l":
                print("�A�{�b���ۤM�l");
                break;
            case "�e�l":
                print("�A�{�b���ۤe�l");
                break;
            default:
                print("�A�������O�Z��");
                break;
        }
    }

}
