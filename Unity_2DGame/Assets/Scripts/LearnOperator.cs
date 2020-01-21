using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public float a = 10;
    public float b = 3;

    public int c = 99;
    public int d = 1;

    private void Start()
    {
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        print(c < d);
        print(c > d);
        print(c <= d);
        print(c >= d);
        print(c == d);
        print(c != d);

        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        print(!true);
        print(!false);
    }
}
