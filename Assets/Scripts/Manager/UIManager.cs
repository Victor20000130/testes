using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�÷��̾� ȭ�鿡 �����Ǵ� UI, �ı������ʴ´�.
public class UIManager : MonoBehaviour
{
    private FadeInOut fadeInOutObj;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
