using UnityEngine;

public class Foob : MonoBehaviour
{
    Fooa fooa;
    void Start()
    {
        fooa = new Fooa();
        fooa.num = 10;
        fooa.Bar();
    }
}
