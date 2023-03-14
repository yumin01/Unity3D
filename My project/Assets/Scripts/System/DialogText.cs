using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogText : MonoBehaviour
{
    [SerializeField]
    private DialogSystem dialogSystem;
    private IEnumerator Start()
    {
        // 첫번째 대사 분기 시작
        yield return new WaitUntil(() => dialogSystem.UpdateDialog(0, true));
    }
}
