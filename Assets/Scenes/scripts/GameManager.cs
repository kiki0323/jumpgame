using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 使用 LoadScene 必要的引用程式敘述 !!
using UnityEngine.UI; // 別忘了要追加 UI 必要程式

public class GameManager : MonoBehaviour
{
    public GameObject hpGauge;     //置放血環的公開變數
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
