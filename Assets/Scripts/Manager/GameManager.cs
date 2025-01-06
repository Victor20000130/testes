using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [Header("�������� Ŭ���� ����")]
    [SerializeField, Tooltip("��������1 Ŭ���� ����")] private bool isStage1Clear;
    [SerializeField, Tooltip("��������2 Ŭ���� ����")] private bool isStage2Clear;
    [SerializeField, Tooltip("��������3 Ŭ���� ����")] private bool isStage3Clear;
    [SerializeField, Tooltip("��������4 Ŭ���� ����")] private bool isStage4Clear;
    [SerializeField, Tooltip("��������5 Ŭ���� ����")] private bool isStage5Clear;

    [Header("���� �б���")]
    [SerializeField, Tooltip("���ǿ���")] private bool isHappyEnding;
    [SerializeField, Tooltip("��忣��")] private bool isBadEnding;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
