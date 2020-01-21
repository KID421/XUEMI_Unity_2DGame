using UnityEngine;

public class LearnMamber : MonoBehaviour
{
    public GameObject objA;
    public GameObject objB;

    private void Start()
    {
        objA.name = "測試物件A";

        print(objB.name);
    }

    public Transform objC;

    private void Update()
    {
        objC.Rotate(60, 0, 0);
    }
}
