using UnityEngine;

public class Summon : GAgent
{
    void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("playerSafe", 1, false);
        goals.Add(s1, 3);

        SubGoal s2 = new SubGoal("enemyDefeated", 1, false);
        goals.Add(s2, 1);

        SubGoal s3 = new SubGoal("followPlayer", 1, false);
        goals.Add(s3, 5);


        // Invoke("GetTired", Random.Range(10, 20));
        // Invoke("NeedRelief", Random.Range(10, 20));
    }

    private void GetTired()
    {
        beliefs.ModifyState("exhausted", 0);
        Invoke("GetTired", Random.Range(10, 20));
    }

    private void NeedRelief()
    {
        beliefs.ModifyState("busting", 0);
        Invoke("NeedRelief", Random.Range(10, 20));
    }
}
