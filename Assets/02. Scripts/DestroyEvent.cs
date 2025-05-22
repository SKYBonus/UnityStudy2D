using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
    public float destroyTime = 3f;
    private void Start()
    {
        Destroy(this.gameObject, destroyTime);
    }

    private void OnDestroy()
    {
        Debug.Log($"{this.gameObject.name}이 파괴되었습니다.");
    }
}

