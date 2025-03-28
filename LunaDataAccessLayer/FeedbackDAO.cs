using LunaBusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunaDataAccessLayer
{
    public class FeedbackDAO
    {
        private readonly LunaContext _context;
        public FeedbackDAO(LunaContext context)
        {
            _context = context;
        }
        public List<Feedback> feedbacks()
        {
            return _context.Feedbacks.ToList();
        }
    }
}
