using UnityEngine;

public class LearnStaticMamber : MonoBehaviour
{
    private void Start()
    {
        // 設定靜態屬性
        Cursor.visible = false;             // 指標.可視 = 否；

        // 取得靜態屬性
        print(Mathf.PI);                    // 數學.圓周率
        print(Random.value);                // 隨機.值 - 0 ~ 1 之間

        // 使用靜態方法
        print(Mathf.Abs(-77.7f));           // 數學.絕對值(數值)
        print(Random.Range(100, 200));      // 隨機.範圍(最小值，最大值)
    }

    private void Update()
    {
        print(Input.GetKeyDown("space"));   // 輸入.按下按鍵("按鍵名稱")
    }
}
