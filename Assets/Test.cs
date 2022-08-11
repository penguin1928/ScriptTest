using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    //int型の変数mpを宣言し、53で初期化してください
    private int hp = 100, mp = 53, power = 25, magic = 5;

    public void Attack()
    {
        Debug.Log("物理攻撃" + this.power + "のダメージを与えた");
    }

    //mpを消費して魔法攻撃をするMagic関数を作ってください
    //Magic関数内でmpを5以上の場合は5減らし、コンソールに 魔法攻撃をした。残りMPは〇〇。 と表示してください。
    //mpが足りない場合、MPが足りないため、魔法が使えない。 と表示してください
    public void Magic()
    {
        if (mp > 4)
        {
            mp -= this.magic;
            Debug.Log("魔法攻撃をした。残りMPは" +　mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        
    }

    public void Defence(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた。残りHPは" + hp + "。");
    }
}


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] intArray = { 5, 10, 15, 20, 25 };

        Debug.Log("-----------");
        //for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }

        Debug.Log("-----------");
        //for文を使い、配列の各要素の値を逆順に表示してください
        for (int i = (intArray.Length - 1); i > -1; i--)
        {
            Debug.Log(intArray[i]);
        }
        Debug.Log("-----------");


        Boss lastboss = new Boss();
        lastboss.Attack();

        //Magic関数を呼び出して、魔法を使ってください
        lastboss.Magic();
        int count = 1;

        //Magic関数を10回使った後に、さらにMagic関数を呼び出すと、mpが足りないメッセージを表示することを
        //確認してください
        while (count < 11)
        {
            lastboss.Magic();
            count++;
        }
        
        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



