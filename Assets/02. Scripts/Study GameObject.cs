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
        obj.name = "���� ĳ����";

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {obj.transform.childCount}");

        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ �̸� : {obj.transform.GetChild(0).name}");

        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ �̸� : " +
                 $"{obj.transform.GetChild(obj.transform.childCount - 1).name}");
    }
}
