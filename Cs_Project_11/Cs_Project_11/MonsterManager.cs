using System;
using System.Collections.Generic;

public class MonsterManager : Singleton<MonsterManager>
{
    List<Monster> m_monList = new List<Monster>();
    public int Count { get { return m_monList.Count; } }
    public void Add(Monster mon) { m_monList.Add(mon); }
    public bool Remove(Monster mon) { return m_monList.Remove(mon); }
    public void RemoveAll() { m_monList.RemoveAll(element => element.m_isAlive == false); }
    public void Clear() { m_monList.Clear(); }
    public Monster GetMonster(int idx)
    {
        return m_monList[idx];
    }
    public void InitMonsters()
    {
        for (int i = 0; i < m_monList.Count; i++)
        {
            m_monList[i].InitMonster();
        }
    }
    public void DrawMonstersInfo()
    {
        for (int i = 0; i < m_monList.Count; i++)
        {
            m_monList[i].MonsterInfo();
        }
        Console.WriteLine();
    }
}