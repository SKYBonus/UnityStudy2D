using UnityEngine;

public class Calculator : MonoBehaviour
{
    /* ------ ��� ���� (�ʵ�) ------ */
    public int number1, number2;

    /* ------ �Լ� ------ */
    private void Start()
    {
        int addResult = AddMethod();
        int minusResult = MinusMethod();

        Debug.Log($"���� �� : {addResult} / �� �� : {minusResult}");
    }

    int AddMethod() 
    {
        int result = number1 + number2; // ���� ���� result
        return result;
    }

    int MinusMethod()
    { 
        int result = number1 - number2; // ���� ���� result
        return result;
    }
}
