using System.Threading.Tasks;
using System;

public class Monster
{
    public int m_hp { get; set; }
    public int m_def { get; set; }
    public int m_Atk { get; set; }
    public bool m_isAlive { get; set; }

    public void InitMonster()
    {
        m_hp = 100;
        m_def = 20;
        m_Atk = 150;
        m_isAlive = true;
    }
    public void MonsterInfo()
    {
        Console.WriteLine("HP : {0}", m_hp);
        Console.WriteLine("DEF : {0}", m_def);
        Console.WriteLine("ATK : {0}", m_Atk);
    }
}