using System;
using System.Collections;
using MonsterBase;
using MonsterBoss;

public class Stage
{
    protected ArrayList m_MobList = new ArrayList();
    public void Start()
    {
        m_MobList.Add(new Monster());
        m_MobList.Add(new Monster());
        m_MobList.Add(new Monster_Boss());
    }
    public void DrawMonster()
    {
        for (int i = 0; i < m_MobList.Count; i++) 
        {
            Monster tmp = (Monster)m_MobList[i];
            tmp.Info();
        }
    }
    public bool CheckClear() {
        for (int i = 0; i < m_MobList.Count; i++)
        {
            Monster tmp = (Monster)m_MobList[i];
            if (tmp.ISLive())
                    return false;
        }
        return true;
    }
}