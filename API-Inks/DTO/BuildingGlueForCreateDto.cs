using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INK_API.DTO
{
    public class BuildingGlueForCreateDto
    {
        public BuildingGlueForCreateDto()
        {
            CreatedDate = DateTime.Now;
        }

        public int CreatedBy { get; set; }
        public int BuildingID { get; set; }
        public string Qty { get; set; }
        public int GlueID { get; set; }
        public string GlueName { get; set; }
        public int MixingInfoID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
