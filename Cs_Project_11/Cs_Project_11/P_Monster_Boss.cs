using System;
using MonsterBase;
namespace MonsterBoss
{
    public class Monster_Boss : Monster
    {
        protected override void Start()
        {
            base.Start();
            Console.WriteLine("보스몬스터 초기화!");
        }
        public override void InitStat()
        {
            m_HP = 100;
            m_Atk = 50;
        }
    }
}