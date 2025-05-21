using System.Collections.Generic;
using UnityEngine;

public class StudyArray : MonoBehaviour
{
    /* ------ 인스펙터 확인 불가 ------ */
    int number1 = 1;
    private int number2 = 2;

    /* ------ 인스펙터 확인 가능 ------ */
    public int number3 = 3;

    [SerializeField]
    private int number4 = 4;

    [SerializeField] private int number5 = 5;
}
