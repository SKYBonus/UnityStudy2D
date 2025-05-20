using UnityEngine;

public class StudyLog : MonoBehaviour
{
    void Start()
    {
        Debug.Log(" Start 함수 실행 "); // 일반 로그
        Debug.LogWarning(" Start 함수 실행 "); // 경고 로그
        Debug.LogError(" Start 함수 실행 "); // 에러 로그
        
    }

    void Update()
    {
        Debug.Log(" Update 함수 실행 ");
    }
}
