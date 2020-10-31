﻿using INK_API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INK_API._Services.Interface
{
    public interface ICommentService : IECService<CommentDto>
    {
        Task<List<CommentDto>> GetAllCommentByScheduleID(int scheduleID);
    }
}
