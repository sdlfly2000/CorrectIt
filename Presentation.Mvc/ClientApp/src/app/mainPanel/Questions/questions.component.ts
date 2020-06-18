import { Component, OnInit } from '@angular/core';

import { QuestionService } from './question.service';
import { QuestionModel } from './Models/question.model';

@Component({
  selector: 'app-mainPanel',
  templateUrl: './questions.component.html',
  providers: [QuestionService]
})
export class QuestionComponent implements OnInit {
  public questions: QuestionModel[];

  constructor(private questionService: QuestionService) {
    
  }

  ngOnInit(): void {
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
