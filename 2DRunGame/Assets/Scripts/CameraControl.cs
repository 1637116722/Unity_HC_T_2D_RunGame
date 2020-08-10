using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("目标：要追踪的物件")]
    public Transform target;
    [Header("追踪速度"), Range(0, 100)]
    public float speed = 1;
    [Header("摄影机拍摄的上限和下限")]
    public Vector2 limit = new Vector2(0, 0.5f);



    ///<summary>
    ///追踪
    ///<summary>
    
    private void Track()
    {
        Vector3 posA = transform.position;
        Vector3 posB = target.position;
        posB.z = -10;
        posB.y = Mathf.Clamp(posB.y,limit.x,limit.y);
        posA = Vector3.Lerp(posA, posB, speed * Time.deltaTime);
        transform.position = posA;

    }

    private void LateUpdate()
    {
        Track();
    }
}
