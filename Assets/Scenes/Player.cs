using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid2D;          // �Ψө�߫}�����餽�}�ܼ�
    float jumpForce = 680.0f;     // ���D�O�w�]��
    float walkForce = 30.0f;      // ���ʱ��O�w�]��
    float maxWalkSpeed = 2.0f;    // ����ʪ��t�׭�
    float a = 1f;
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();  // ���o�߫}������
    }

    void Update()
    {
        // ���D
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid2D.AddForce(transform.up * jumpForce);
        }
        // ���k����
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // �C�����⪺�t��
        float speedx = Mathf.Abs(rigid2D.velocity.x);

        // �t�׭���
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }
    }
}
