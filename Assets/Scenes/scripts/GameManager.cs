using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �ϥ� LoadScene ���n���ޥε{���ԭz !!
using UnityEngine.UI; // �O�ѤF�n�l�[ UI ���n�{��

public class GameManager : MonoBehaviour
{
    public GameObject hpGauge;     //�m����������}�ܼ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DecreaseHp()
    {
        hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
