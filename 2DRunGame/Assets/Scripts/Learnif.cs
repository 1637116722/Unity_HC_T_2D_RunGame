using UnityEngine;

public class Learnif : MonoBehaviour
{
    private void Start()
    {
        if (true)
        {
            print("我是判斷式 :p");
        }
    }

    public bool open;

    public int score = 100;

    private void Update()
    {
        if (open)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        if (score >= 60)
        {
            print("pass");
        }
        else if (score >= 40)
        {
            print("test");
        }
        else
        {
            print("false");
        }
    }
}
