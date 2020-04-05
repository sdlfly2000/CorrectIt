import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { QuestionModel } from './Models/question.model'

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public questions: QuestionModel[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<QuestionModel[]>(baseUrl + 'api/Question/Get').subscribe(results => {
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
