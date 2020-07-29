using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   private void Start()
    {
        print(Random.value);
        print(Mathf.PI);


        Time.timeScale = 10;

        float r=Random.Range(100.9f, 200.5f);
        print("隨機值:" + r);

        int ri = Random. Range(1,3);
        print("隨機整數:" + ri);
        Cursor.visible = false;
        print("-9的绝对值:" + Mathf.Abs(-9));
    }
    private void Update()
    {
        // print("遊戲時間:" + Time.time);
        print("玩家是否按任意键：" + Input.anyKeyDown);
    }
}
