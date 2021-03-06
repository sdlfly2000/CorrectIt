﻿using Application.Services.Questions.Contractors;

namespace Application.Services.Questions.Processes
{
    public interface IQuestionProcess
    {
        QuestionsResponse Get();
        QuestionsResponse Get(string questionCode);
        QuestionsResponse Get(QuestionsRequest request);
    }
}