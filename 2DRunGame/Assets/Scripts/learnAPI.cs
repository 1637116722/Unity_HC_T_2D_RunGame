
using UnityEngine;

public class learnAPI : MonoBehaviour
{
    public GameObject sphere;

    public Transform tra;

    public Transform cube;

    public Light DirectionalLight;

    public Camera cam;

    private void Start()
    {
        print(sphere.layer);

        print("球的坐标：" + tra.position);

        tra.localScale = new Vector3(7, 7, 7);
        DirectionalLight.color= new Color(0.8f, 0, 0);
        DirectionalLight.Reset();

        cam.orthographicSize = 3;
    }

    private void Update()
    {
        cube.Rotate(0, 0, 10);
    }
}
