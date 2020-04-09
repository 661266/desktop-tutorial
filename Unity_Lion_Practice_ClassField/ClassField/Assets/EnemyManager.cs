
using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [Header("怪物1號")]
    public Enemy Monster1;

    [Header("怪物2號")]
    public Enemy Monster2;

    private void Start()
    {
        
        Monster1.mp = 100;
        Monster2.hp = 300;
        Monster1.def = 50;
        Monster1.arms = "木棍";
        Monster2.arms = "短刀";
        Monster1.key = true;
        Monster2.box = true;

        print("怪物1號的mp:" + Monster1.mp);
        print("怪物2號的arms:" + Monster2.arms);
    }

}

