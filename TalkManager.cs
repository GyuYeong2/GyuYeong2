using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    Dictionary<int, Sprite> portraitData;

    public Sprite[] portraitArr;

    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        portraitData = new Dictionary<int, Sprite>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(1000, new string[] { "(�� �ٸ� �������..��������� �� Ű�� ũ����)","�ȳ��ϼ��� ���׳״�","����ÿ� ���ڸ� ��ٷȼ�.","���� ��ٷȴٰ��?","�ð��� ���� � ���� ������ÿ�","(���� ��ٷȴٰ�? ����....)","���׳׸� ������" });
        talkData.Add(2000, new string[] { "(������...?)", "����....", "������ ���� ��𰡰� ���⼭ ����ִ°ž�?","���� �Ƴ��� ������ �Ҿ���Ⱦ�!!","�������� �� ��⸦ ����� ���� �� �� ����� �ƴϾ�","���� ���� ��� ������ ����;�","�׷��ϱ� �� ���� �հ� ��⸦ �ϰ�;�","����...�� ���� ���� ���� ������","����....�����̶� �����ϼ̰ŵ�","����...�׷��� �ٵ� �������� ��°ž�","�׷��� ���� ��� ��?","�� ������ ã��. �ź��� ������ ž�� ������ ���ٰž�","�˰ھ� ���������� ��ﳪ�� ���� �˷���","���� ���� ���� ���� ��� �Ҿ���ȴµ�...","���� ��ó�� �����ž�","(��ó�� ã�ƺ���)","��ȭ�� ���� �ڿ� �����̽� �ٸ� �� �� �� �����ּ���"});
        talkData.Add(100, new string[] { "��û ū �漮�̴�." });
        talkData.Add(200, new string[] { "���ڱ� ������ ������ ���." });
        talkData.Add(300, new string[] { "�ʰ� �����̾�?" });
        talkData.Add(500, new string[] { "������ ���� ������ �����Դϴ�" });

        //Quest Talk
        talkData.Add(1000 + 10 , new string[] { "�ΰ�", "���� �Ƴ��� ������ �Ҿ���Ⱦ�","�� ������ ã���ָ� �� �����ٰ�" });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == talkData[id].Length)
            return null;
        else
            return talkData[id][talkIndex];
    }

    public Sprite GetPortrait(int id, int portraitIndex)
    {
        return portraitData[id + portraitIndex];
    }
}
