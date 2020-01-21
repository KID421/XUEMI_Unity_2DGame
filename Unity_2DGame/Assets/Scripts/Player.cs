using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator aniPlayer;
    private SpriteRenderer sprPlayer;

    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10;

    /// <summary>
    /// 移動方法：角色移動、動畫與翻面
    /// </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");

        transform.Translate(speed * h * Time.deltaTime, 0, 0);

        aniPlayer.SetBool("跑步開關", h != 0);

        if (Input.GetKeyDown(KeyCode.A))
        {
            sprPlayer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            sprPlayer.flipX = false;
        }
    }

    private void Start()
    {
        aniPlayer = GetComponent<Animator>();
        sprPlayer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
    }
}
