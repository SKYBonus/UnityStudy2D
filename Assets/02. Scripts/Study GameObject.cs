using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        CreateAmongus();
    }
    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "어몽어스 캐릭터";

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {obj.transform.childCount}");

        Debug.Log($"캐릭터의 첫번째 자식 오브젝트 이름 : {obj.transform.GetChild(0).name}");

        Debug.Log($"캐릭터의 마지막 자식 오브젝트 이름 : " +
                 $"{obj.transform.GetChild(obj.transform.childCount - 1).name}");
    }
}
