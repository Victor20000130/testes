using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    [SerializeField] private float fadedTime = 0.5f; // FadeIn, FadeOut �� �ҿ� �ð�
    [SerializeField] private Image fadeInoutImg; // ���̵� ȿ���� �� �̹���

    [SerializeField] private bool isFadeIn; // ���̵� �� ���� Ȯ��
    [SerializeField] private bool isFadeOut; // ���̵� �ƿ� ���� Ȯ��

    void Start()
    {
        if (fadeInoutImg != null)
        {
            // �ʱ� ���� �� ���� (������ ���̰ų� �����ϰ�)
            Color color = fadeInoutImg.color;
            color.a = 1f; // ������ ������ (1)���� ����
            fadeInoutImg.color = color;
        }
    }

    public IEnumerator FadeIn()
    {
        isFadeIn = true;
        float elapsedTime = 0f;
        Color color = fadeInoutImg.color;

        while (elapsedTime < fadedTime)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Lerp(1f, 0f, elapsedTime / fadedTime); // ���� ���� ���������� ����
            fadeInoutImg.color = color;
            yield return null;
        }

        color.a = 0f; // ������ ����
        fadeInoutImg.color = color;
        isFadeIn = false;
    }

    public IEnumerator FadeOut()
    {
        isFadeOut = true;
        float elapsedTime = 0f;
        Color color = fadeInoutImg.color;

        while (elapsedTime < fadedTime)
        {
            elapsedTime += Time.deltaTime;
            color.a = Mathf.Lerp(0f, 1f, elapsedTime / fadedTime); // ���� ���� ���������� ����
            fadeInoutImg.color = color;
            yield return null;
        }

        color.a = 1f; // ������ ������
        fadeInoutImg.color = color;
        isFadeOut = false;
    }

    // ����׿�: Ű �Է����� �׽�Ʈ
   /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // F Ű�� FadeOut ����
        {
            StartCoroutine(FadeOut());
        }
        if (Input.GetKeyDown(KeyCode.G)) // G Ű�� FadeIn ����
        {
            StartCoroutine(FadeIn());
        }
    }*/
}
