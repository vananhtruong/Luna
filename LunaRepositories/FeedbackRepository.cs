using LunaBusinessObject;
using LunaDataAccessLayer;
using LunaRepositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaRepositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly FeedbackDAO _context;
        public FeedbackRepository(FeedbackDAO context)
        {
            _context = context;
        }
        public List<Feedback> feedbacks()
        {
            return _context.feedbacks();
        }
    }
}
