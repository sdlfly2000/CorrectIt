﻿using Application.Services.Questions.Contractors;

namespace Application.Services.Questions.Actions
{
    public interface IQuestionAction
    {
        QuestionsResponse Get();
        QuestionsResponse Get(QuestionsRequest request);
    }
}