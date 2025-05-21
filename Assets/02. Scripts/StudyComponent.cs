using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    GameObject obj;

    public string changeName;

    private void Start()
    {
        obj = GameObject.Find("Main Camera");

        obj.name = changeName;
    }
}
