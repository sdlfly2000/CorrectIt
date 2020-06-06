import { Component, Inject } from '@angular/core';

import { QuestionService } from '../Services/Question/question.service';
import { QuestionModel } from '../Services/Question/Models/question.model';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  providers: [QuestionService]
})
export class HomeComponent {
  public questions: QuestionModel[];

  constructor(private questionService: QuestionService) {
    this.getQuestions();
  }

  public getQuestions(): void
  {
    this.questionService.retrieveQuestions().subscribe(results => {
      this.questions = [];
      for (var model of results) {
        this.questions.push(this.Map(model));
      }
    }, error => console.error(error));
  }

  private Map(questionModel: any): QuestionModel {
    let retModel = new QuestionModel();

    retModel.QuestionCode = questionModel.questionCode;
    retModel.QuestionCategory = questionModel.questionCategory;
    retModel.QuestionTitle = questionModel.questionTitle;
    retModel.QuestionCreatedBy = questionModel.questionCreatedBy;
    retModel.QuestionComments = questionModel.questionComments;
    retModel.QuestionCreatedOn = questionModel.questionCreatedOn;

    return retModel;
  }
 }
