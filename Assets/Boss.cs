using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
    private int hp = 100;
    private int power = 25;


    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }


    public void Defence(int damege)
    {
        Debug.Log(damege + "のダメージを受けた");

        this.hp -= damege;
    }

    int[] array = {53};

}
