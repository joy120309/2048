using UnityEngine;

public class CSharpStudy : MonoBehaviour
{
    int hp;
    int money = 5000;

    int a = 43;
    int b = 23;


    bool result = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        money = money - 3000;
        money -= 3000;
        money = money + 500;
        money = money / 2;
        money /= 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
