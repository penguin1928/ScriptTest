using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    //int�^�̕ϐ�mp��錾���A53�ŏ��������Ă�������
    private int hp = 100, mp = 53, power = 25, magic = 5;

    public void Attack()
    {
        Debug.Log("�����U��" + this.power + "�̃_���[�W��^����");
    }

    //mp������Ė��@�U��������Magic�֐�������Ă�������
    //Magic�֐�����mp��5�ȏ�̏ꍇ��5���炵�A�R���\�[���� ���@�U���������B�c��MP�́Z�Z�B �ƕ\�����Ă��������B
    //mp������Ȃ��ꍇ�AMP������Ȃ����߁A���@���g���Ȃ��B �ƕ\�����Ă�������
    public void Magic()
    {
        if (mp > 4)
        {
            mp -= this.magic;
            Debug.Log("���@�U���������B�c��MP��" +�@mp + "�B");
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
        }
        
    }

    public void Defence(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "�̃_���[�W���󂯂��B�c��HP��" + hp + "�B");
    }
}


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������
        int[] intArray = { 5, 10, 15, 20, 25 };

        Debug.Log("-----------");
        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }

        Debug.Log("-----------");
        //for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������
        for (int i = (intArray.Length - 1); i > -1; i--)
        {
            Debug.Log(intArray[i]);
        }
        Debug.Log("-----------");


        Boss lastboss = new Boss();
        lastboss.Attack();

        //Magic�֐����Ăяo���āA���@���g���Ă�������
        lastboss.Magic();
        int count = 1;

        //Magic�֐���10��g������ɁA�����Magic�֐����Ăяo���ƁAmp������Ȃ����b�Z�[�W��\�����邱�Ƃ�
        //�m�F���Ă�������
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



