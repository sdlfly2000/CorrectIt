import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { QuestionService } from '../Questions/question.service';
import { QuestionModel } from '../Questions/Models/question.model';

@Component({
  selector: 'app-QuestionDetails',
  templateUrl: './questiondetails.component.html',
  providers: [QuestionService]
})
export class QuestionDetailsComponent implements OnInit {
  public questionDetails: QuestionModel;
  private Code: string;

  constructor(private questionService: QuestionService, private activatedRoute: ActivatedRoute) {

  }

  ngOnInit(): void {
    this.Code = this.activatedRoute.snapshot.paramMap.get("code");
    this.getQuestionDetails(this.Code);
  }

  private getQuestionDetails(Code: string): void {
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
