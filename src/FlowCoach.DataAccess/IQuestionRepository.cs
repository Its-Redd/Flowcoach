using FlowCoach.Entities;

namespace FlowCoach.DataAccess
{
    public interface IQuestionRepository : IRepository<Question>
    {
        public IEnumerable<Question> GetFirst5QuestionsWith(QuestionCategory questionCategory);

        public IEnumerable<Question> GetNext5QuestionsWith(int lastQuestionId, QuestionCategory questionCategory);

        public IEnumerable<Question> GetAllQuestionsWith(QuestionCategory questionCategory);
    }
}
