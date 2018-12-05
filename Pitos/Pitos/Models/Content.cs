using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pitos.Models
{
    /// <summary>
    /// 2018.12.04
    /// Panbb
    /// 内容实体
    /// </summary>
    public class Content
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public int status { get; set; }
        public DateTime add_time { get; set; }
        public DateTime modify_time { get; set; }
    }
}
