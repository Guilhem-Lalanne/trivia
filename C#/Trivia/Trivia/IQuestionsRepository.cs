using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trivia
{
    public interface IQuestionsRepository
    {
        QuestionsStack GetQuestionsStack(string category);
    }

    class QuestionsFileRepository : IQuestionsRepository
    {
        public QuestionsStack GetQuestionsStack(string category)
        {
            throw new NotImplementedException();
        }
    }

    class QuestionssqlRepository : IQuestionsRepository
    {
        public QuestionsStack GetQuestionsStack(string category)
        {
            throw new NotImplementedException();
        }
    }

    public class GeneratedQuestionsRepository : IQuestionsRepository
    {
        public QuestionsStack GetQuestionsStack(string category)
        {
            var questionsStack = new QuestionsStack(category);
            for (var i = 0; i < 50; i++)
            {
                questionsStack.Generate(i);
            }
            return questionsStack;
        }
    }
}
