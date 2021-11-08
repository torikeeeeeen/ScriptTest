using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; // MP　※発展課題

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    // 魔法攻撃用の関数
    public void Magic()
    {
        // 残りmpの値による条件分岐
        if (this.mp >= 5)
        {
            // 残りmpを5減らす
            this.mp -= 5;
            // 残りmpが5以上だったならば表示
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            // 残りmpが5未満ならば表示
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour
{

    // 発展：魔法を使う回数
    private int count = 10; //魔法を使う回数


    // Start is called before the first frame update
    void Start()
    {
        // ----基本課題ここから----

        // 配列の初期化
        int[] array = { 1, 2, 4, 8, 16 };

        // 配列の各要素を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        // 配列の各要素を逆順に表示
        for (int i = array.Length; i > 0; i--)
        {
            Debug.Log(array[i-1]);
        }

        // ----基本課題ここまで----


        // ----発展課題ここから----

        // Bossクラスの変数を宣言
        Boss lastboss = new Boss();

        // 攻撃用の関数呼び出し
        lastboss.Attack();

        // 防御用の関数呼び出し
        lastboss.Defence(3);

        // 魔法攻撃を指定回数だけ繰り返し行う
        for (int i = 0; i < count; i++)
        {
            //魔法攻撃用の関数呼び出し
            lastboss.Magic();
        }

        //魔法をさらにもう一回使う
        lastboss.Magic();

        // ----発展課題ここまで----
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
