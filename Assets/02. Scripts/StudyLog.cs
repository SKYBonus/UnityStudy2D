using UnityEngine;

public class StudyLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log(" Start �Լ� ���� "); // �Ϲ� �α�
        Debug.LogWarning(" Start �Լ� ���� "); // ��� �α�
        Debug.LogError(" Start �Լ� ���� "); // ���� �α�
        
    }

    void Update()
    {
        Debug.Log(" Update �Լ� ���� ");
    }
}
