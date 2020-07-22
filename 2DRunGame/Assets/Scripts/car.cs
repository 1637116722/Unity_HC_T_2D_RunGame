using UnityEngine;

public class car : MonoBehaviour
{   [Header("品牌")]
    public string brand = "賓士";
    [Header("cc数"),Tooltip("汽车的cc数")]
    public int cc = 1500;
    [Header("重量"),Range(0,100)]
    public float weight = 20.5f;
    [Header("是否有天窗"),Tooltip("搭钩代表有，取消代表没有")]
    public bool window = true;
    [Header("速度"),Range(0,200)]
    public float apeed = 60.5f;

    public Color red = Color.red;
    public Color mycolor = new Color(0.5f, 0.5f, 0.9f);
    public Vector2 poszero = Vector2.zero;
    public Vector2 posone = Vector2.one;
    public Vector2 poscustom = new Vector2(9, 20);
    public Vector3 pos3 = new Vector3(3, 2, 1);
    public Vector3 pos4 = new Vector4(1, 2, 3, 4);

    public GameObject cam;
    public Transform traCam;
    public Camera cam1;
}
