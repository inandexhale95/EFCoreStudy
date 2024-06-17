using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO_EFCore
{
    /*
     * 1. DbContext를 상속받는다.
     * 2. DbSet<T>을 찾는다.
     * 3. 모델링 class를 분석해서, 컬럼을 찾는다.
     * 4. 모델링 class에서 참조하는 클래스가 있다면, 해당 클래스도 분석한다.
     * 5. OnModelCreating 함수 호출 (추가 설정) (override)
     * 6. 데이터베이스의 전체 모델링 구조를 내부 메모리에 들고 있음
     */
    public class AppDbContext : DbContext
    {
        // Player라는 DB 테이블이 있는데, 세부적인 키/컬럼 정보는 Player 클래스를 참고한다.
        // 프로퍼티 명이 테이블 명의 기본값으로 생성된다.
        // public DbSet<Player> Players { get; set; }
        public DbSet<Item> Items { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectString = "Server=localhost;Database=efcore;Uid=root;Pwd=root123;";
            optionsBuilder.UseMySql(connectString, ServerVersion.AutoDetect(connectString));
        }

    }
}
