using UnityEngine;

public class Calculator : MonoBehaviour
{
    /* ------ 멤버 변수 (필드) ------ */
    public int number1, number2;

    /* ------ 함수 ------ */
    private void Start()
    {
        int addResult = AddMethod();
        int minusResult = MinusMethod();

        Debug.Log($"더한 값 : {addResult} / 뺀 값 : {minusResult}");
    }

    int AddMethod() 
    {
        int result = number1 + number2; // 지역 변수 result
        return result;
    }

    int MinusMethod()
    { 
        int result = number1 - number2; // 지역 변수 result
        return result;
    }
}
