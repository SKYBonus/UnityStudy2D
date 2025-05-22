using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); //수평
        float v = Input.GetAxis("Vertical"); //수직

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
