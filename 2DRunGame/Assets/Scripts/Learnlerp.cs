using UnityEngine;

public class Learnlerp : MonoBehaviour
{
    public float A = 0;
    public float B = 100;
    private void Start()
    {
        float result = Mathf.Lerp(A, B, 0.5f);
        print(result);
    }
    public float C = 0;
    public float D = 100;

    public Vector2 v2A = new Vector2(0, 0);
    public Vector2 v2B= new Vector2(100, 100);

    public Color cA = new Color(0f, 0f, 0f);
    public Color cB = new Color(0.7f, 0.5f, 0.3f);

    private void Update()
    {
        C = Mathf.Lerp(C, D, 0.5f * Time.deltaTime);
        v2A = Vector2.Lerp(v2A, v2B, 0.7f * Time.deltaTime);
        cA = Color.Lerp(cA, cB, 0.7f * Time.deltaTime);
    }
}
