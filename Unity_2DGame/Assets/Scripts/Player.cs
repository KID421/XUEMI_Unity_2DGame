using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Animator aniPlayer;
    private SpriteRenderer sprPlayer;
    private float hp = 100;
    private float hpMax;
    private Image hpBar;
    private bool dead;
    private GameManager gm;

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

    /// <summary>
    /// 死亡方法：播放死亡動畫、關閉腳本
    /// </summary>
    private void Dead()
    {
        aniPlayer.SetTrigger("死亡觸發");
        this.enabled = false;
        dead = true;
        gm.GameOver();
    }

    private void Start()
    {
        aniPlayer = GetComponent<Animator>();
        sprPlayer = GetComponent<SpriteRenderer>();
        hpBar = GameObject.Find("血條").GetComponent<Image>();
        gm = FindObjectOfType<GameManager>();

        hpMax = hp;
    }

    private void Update()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dead) return;

        if (collision.tag == "陷阱")
        {
            hp -= 20;
            hpBar.fillAmount = hp / hpMax;

            if (hp <= 0) Dead();
        }

        if (collision.tag == "櫻桃")
        {
            hp += 5;
            hp = Mathf.Clamp(hp, 0, hpMax);
            hpBar.fillAmount = hp / hpMax;
        }

        Destroy(collision.gameObject);
    }
}
