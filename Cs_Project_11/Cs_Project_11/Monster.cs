using System;

namespace MonsterBase
{
    public class Monster
    {
        public int m_HP { get; set; }
        public int m_Atk { get; set; }
        public Monster() { Start(); }
        virtual protected void Start()
        {
            InitStat();
        }
        virtual public void InitStat()
        {
            m_HP = 10;
            m_Atk = 20;
        }
        public bool ISLive()
        {
            return m_HP > 0;
        }
        public void Info()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("HP : " + m_HP);
            Console.WriteLine("Atk : " + m_Atk);
            Console.WriteLine("----------------");
        }
    }
}