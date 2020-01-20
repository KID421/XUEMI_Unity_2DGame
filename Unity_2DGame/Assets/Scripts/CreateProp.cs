using UnityEngine;

public class CreateProp : MonoBehaviour
{
    [Header("要生成的道具")]
    public GameObject prop;
    [Header("X 軸最小值")]
    public float xMin;
    [Header("X 軸最大值")]
    public float xMax;
    [Header("生成頻率"), Range(0.1f, 3f)]
    public float interval = 1;

    /// <summary>
    /// 建立道具物件
    /// </summary>
    private void CreatePropObject()
    {
        float x = Random.Range(xMin, xMax);             // 取得隨機 X 座標
        Vector3 pos = new Vector3(x, 7, 0);             // 三維向量(隨機X，高度，0)

        Instantiate(prop, pos, Quaternion.identity);    // 實例化(物件，座標，角度)
    }

    private void Start()
    {
        float r = Random.Range(0f, 2f);

        InvokeRepeating("CreatePropObject", r, interval);   // 延遲重複呼叫("方法名稱"，延遲，頻率)
    }
}
