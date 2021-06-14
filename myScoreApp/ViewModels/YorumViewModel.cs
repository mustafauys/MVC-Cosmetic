using myScoreApp.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myScoreApp.ViewModels
{
    public class YorumViewModel
    {
        public int mekanId { get; set; }
        public int MainCommentId { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }

        List<MainComment> mainComments { get; set; }
        List<SubComment> subComments { get; set; }
    }
}
