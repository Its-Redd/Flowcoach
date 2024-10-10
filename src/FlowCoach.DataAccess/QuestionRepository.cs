using FlowCoach.Entities;

namespace FlowCoach.DataAccess
{
    public class QuestionRepository : Repository<Question>, IQuestionRepository
    {
        public QuestionRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<Question> GetAllQuestionsWith(QuestionCategory questionCategory)
        {
            return dataContext.Questions.Where(q => q.Category == questionCategory).ToList();
        }

        public IEnumerable<Question> GetFirst5QuestionsWith(QuestionCategory questionCategory)
        {
            return dataContext.Questions.Where(q => q.Category == questionCategory).Take(5).ToList();
        }

        public IEnumerable<Question> GetNext5QuestionsWith(int lastQuestionId, QuestionCategory questionCategory)
        {
            return dataContext.Questions.Where(q => q.Category == questionCategory && q.Id > lastQuestionId).Take(5).ToList();
        }
    }
}
