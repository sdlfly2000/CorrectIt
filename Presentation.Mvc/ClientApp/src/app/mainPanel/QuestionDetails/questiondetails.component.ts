import { Component, OnInit } from '@angular/core';

import { QuestionService } from '../Questions/question.service';
import { QuestionModel } from '../Questions/Models/question.model';

@Component({
  selector: 'app-mainPanel',
  templateUrl: './questiondetails.component.html',
  providers: [QuestionService]
})
export class QuestionDetailsComponent implements OnInit {
  public questionDetails: QuestionModel;

  constructor(private questionService: QuestionService) {

  }

  ngOnInit(): void {

  }

  public getQuestionDetails(Code: string): void {
    this.questionService.retrieveQuestionDetails(Code).subscribe(result => {
      this.questionDetails = this.Map(result);
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
