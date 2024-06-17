using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO_EFCore
{
    /* 클래스 이름 = 테이블 이름
     * 
     */
    public class Player
    {
        public int PlayerId { get; set; } // Primary Key, ClassName에 Id를 붙이는 것이 기본 컨벤션
        public string Name { get; set; }    
    }

    [Table("Item")]
    public class Item
    {
        public int ItemId { get; set; }
        public int TemplateId { get; set; }
        public DateTime CreateDate { get; set; }

        // 다른 클래스를 참조 -> FK
        public int OwnerId { get; set; }
        public Player Owner { get; set; }
    }
}
