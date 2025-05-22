using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh mesh;
    public Material mat;

    void Start()
    {
        CreateCube();
    }
    public void CreateCube()
    {
        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = mesh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
    }
}
