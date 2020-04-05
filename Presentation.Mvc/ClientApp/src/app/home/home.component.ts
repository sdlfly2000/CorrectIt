import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  public questions: QuestionModel[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<QuestionModel[]>(baseUrl + 'api/Question/Get').subscribe(result => {
      this.questions = result;
    }, error => console.error(error));
  }

}
