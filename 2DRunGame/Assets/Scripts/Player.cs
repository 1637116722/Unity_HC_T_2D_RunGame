using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 5;
    [Header("跳越高度"), Range(0, 1000)]
    public int jump = 350;
    [Header("血量"), Range(0, 2000)]
    public float hp = 500;

    public bool isGround;
    public int coin;

    [Header("音效區域")]
    public AudioClip soundHit;
    public AudioClip soundSlide;
    public AudioClip soundJump;
    public AudioClip soundCoin;

    public Animator ani;
    public Rigidbody2D rid;
    public CapsuleCollider2D cap;
    public AudioSource and;
    #endregion

    #region 方法
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        transform.Translate(speed* Time.deltaTime, 0, 0);
    }

    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {
        // 動畫控制器.設定布林值("參數名稱"，布林值)
        // true 玩家是否按下空白鍵
        bool Space = Input.GetKeyDown(KeyCode.Space);

        RaycastHit2D hit = Physics2D.Raycast(transform.position + new Vector3(0.05f, -1f), -transform.up, 0.01f, 1 << 8);

        if (hit)
        {
            isGround = true;
            ani.SetBool("跳開關", false);
        }
        else
        {
            isGround = false;
        }

        if (isGround)
        {
            if (Space)
            {
                ani.SetBool("跳開關", true);
                rid.AddForce(new Vector2(0, jump));
                and.PlayOneShot(soundJump, 0.3f);
            }

        }

    }

    /// <summary>
    /// 滑行
    /// </summary>
    private void Slide()
    {
        bool s = Input.GetKeyDown(KeyCode.S);
        ani.SetBool("滑行開關", s);


        if (s)
        {
            //zhanli 0.1   0.1   2    4
            cap.offset = new Vector2(0.1f, 0.1f);
            cap.size = new Vector2(2f, 2f);
        }
        else
        {
            //huaxing 0.1   -1   2    2
            cap.offset = new Vector2(0.1f, -1f);
            cap.size = new Vector2(2f, 2f);
        }
    }

    /// <summary>
    /// 吃金幣
    /// </summary>
    private void EatCoin()
    {

    }

    /// <summary>
    /// 受傷
    /// </summary>
    private void Hit()
    {

    }

    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }

    /// <summary>
    /// 過關
    /// </summary>
    private void Pass()
    {

    }

    #endregion

    #region 事件
    private void Start()
    {

    }

    private void Update()
    {
        Jump();
        Slide();
        Move();
    }
    //绘制图示事件
    private void OnDrawGizmos()
    {
        //图示.颜色 =颜色.红色
        Gizmos.color = Color.red;
        //图示。绘制射线（起点，方向）
        //transform此物件的变形元件
        //transform.position 此物件的坐标
        //transform.up 此物件的上方     X
        //transform.right 此物件的右方  Y
        //transform.forward 此物件前方  Z
        Gizmos.DrawRay(transform.position + new Vector3(0.05f, -1f), -transform.up * 0.01f);
    }
}
    


    #endregion
