using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    GameObject BULLET ;
    // Start is called before the first frame update
    void Start()
    {
        BULLET = GameObject.Find("GameManager");
        Destroy(gameObject, 3); // 3���A�R���ۤv

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // ��b�Y�I���L���I���骺�F���
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "cat")
        {
            Destroy(gameObject); // �I�즳�I���骺�F��N�R���ۤv
            BULLET.GetComponent<GameManager>().DecreaseHp();
        }

    }

}
